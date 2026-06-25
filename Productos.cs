using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace StretchFilmApp
{
    /// <summary>
    /// Formulario para gestionar productos.
    /// Permite registrar, visualizar y persistir productos en TXT,
    /// incluyendo la ruta de una imagen asociada a cada producto.
    /// </summary>
    public partial class Productos : Form
    {
        /// <summary>Lista en memoria con los registros cargados desde el archivo.</summary>
        private readonly List<string[]> datos = new List<string[]>();

        /// <summary>Ruta absoluta al archivo TXT de productos.</summary>
        private readonly string ruta = Path.Combine(Application.StartupPath, "Data2", "productos.txt");

        /// <summary>Carpeta donde se guardan las imágenes de los productos.</summary>
        private readonly string carpetaImagenes = Path.Combine(Application.StartupPath, "Data2", "Imagenes");

        /// <summary>Ruta de la imagen seleccionada para el producto que se está registrando.</summary>
        private string rutaImagenSeleccionada = "";

        /// <summary>
        /// Constructor: inicializa controles, carga datos y vincula eventos.
        /// </summary>
        public Productos()
        {
            InitializeComponent();

            Directory.CreateDirectory(carpetaImagenes);

            Theme.EstilizarGrid(dgvProductos);

            CargarCombos();
            AsegurarArchivoEjemplo();
            Utilitario.CargarArchivoTXT(ruta, datos, dgvProductos);
            ColorearEstados();
            ActualizarResumen();

            pnlNuevo.Visible = false;
            pnlNuevo.AgregarBotonCerrar(LimpiarCampos);
            btnNuevoProducto.Click += (s, e) => pnlNuevo.Visible = !pnlNuevo.Visible;
            btnLimpiar.Click += (s, e) => LimpiarCampos();
            btnGuardar.Click += (s, e) => GuardarProducto();
            btnSeleccionarImagen.Click += (s, e) => SeleccionarImagen();
            dgvProductos.CellDoubleClick += DgvProductos_CellDoubleClick;
        }

        // ─── Inicialización ──────────────────────────────────────────────────────

        /// <summary>
        /// Llena el ComboBox de Estado con sus opciones fijas.
        /// </summary>
        private void CargarCombos()
        {
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.SelectedIndex = 0;
        }

        /// <summary>
        /// Crea el archivo TXT con filas de ejemplo si todavía no existe.
        /// Formato: codigo, nombre, descripcion, proveedor, precio, stock, estado, rutaImagen
        /// </summary>
        private void AsegurarArchivoEjemplo()
        {
            if (File.Exists(ruta)) return;
            Directory.CreateDirectory(Path.GetDirectoryName(ruta));

            string s = Utilitario.SEPARADOR.ToString();
            string[] demo =
            {
                string.Join(s, "SF-20",     "Stretch Film 20µm x 500m",   "Alta resistencia",           "Plastificados del Norte S.A.C.", "28.50", "350", "Activo", ""),
                string.Join(s, "SF-25",     "Stretch Film 25µm x 500m",   "Uso diario",                 "Plastificados del Norte S.A.C.", "32.00", "520", "Activo", ""),
                string.Join(s, "SF-IND",    "Stretch Film Industrial 23µm","Líneas automatizadas",      "PolyPack Industrial E.I.R.L.",   "35.50", "240", "Activo", ""),
                string.Join(s, "SF-NEG-30", "Stretch Film Negro 30µm",    "Protección UV",              "PolyPack Industrial E.I.R.L.",   "38.00", "180", "Activo", ""),
            };
            File.WriteAllLines(ruta, demo, Encoding.UTF8);
        }

        // ─── Grilla ──────────────────────────────────────────────────────────────

        /// <summary>
        /// Aplica color verde a ESTADO Activo, gris para Inactivo.
        /// </summary>
        private void ColorearEstados()
        {
            var fontBold = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                var celda = fila.Cells["colEstado"];
                string estado = celda.Value?.ToString() ?? "";
                celda.Style.ForeColor = estado == "Activo" ? Theme.Verde : Theme.TextoTenue;
                celda.Style.Font = fontBold;
            }
        }

        /// <summary>
        /// Si la columna de imagen tiene una ruta válida, la abre en el visor
        /// de imágenes predeterminado del sistema al hacer doble clic sobre la celda.
        /// </summary>
        private void DgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvProductos.Columns[e.ColumnIndex].Name != "colImagen") return;

            string rutaImg = dgvProductos.Rows[e.RowIndex].Cells["colImagen"].Value?.ToString();
            if (string.IsNullOrWhiteSpace(rutaImg) || !File.Exists(rutaImg))
            {
                MessageBox.Show("Este producto no tiene una imagen asociada.", "Sin imagen",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(rutaImg) { UseShellExecute = true });
        }

        /// <summary>
        /// Actualiza el subtítulo y las tarjetas de resumen (total, activos, stock total).
        /// </summary>
        private void ActualizarResumen()
        {
            int total = datos.Count;
            int activos = 0;
            int stockTotal = 0;

            foreach (string[] p in datos)
            {
                // 1. Validamos que tenga la estructura correcta y que esté "Activo"
                if (p.Length >= 7 && p[6] == "Activo")
                {
                    activos++;

                    // 2. Si está activo, sumamos su stock (ya no hace falta validar p.Length >= 6 porque p.Length >= 7)
                    if (int.TryParse(p[5], out int n))
                    {
                        stockTotal += n;
                    }
                }
            }

            lblSubtitulo.Text = $"{total} producto{(total != 1 ? "s" : "")} · {activos} activo{(activos != 1 ? "s" : "")}";
            lblTotalProductos.Text = total.ToString();
            lblActivos.Text = activos.ToString();
            lblStockTotal.Text = stockTotal.ToString("N0");
        }

        // ─── Panel "Nuevo producto" ──────────────────────────────────────────────

        /// <summary>
        /// Abre el diálogo para elegir una imagen y la copia a la carpeta
        /// de imágenes de la aplicación con un nombre único, evitando colisiones.
        /// </summary>
        private void SeleccionarImagen()
        {
            using (var dialogo = new OpenFileDialog())
            {
                dialogo.Filter = "Imágenes (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
                dialogo.Title = "Selecciona la imagen del producto";

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    string extension = Path.GetExtension(dialogo.FileName);
                    string nombreUnico = Guid.NewGuid().ToString("N") + extension;
                    string destino = Path.Combine(carpetaImagenes, nombreUnico);

                    File.Copy(dialogo.FileName, destino, true);
                    rutaImagenSeleccionada = destino;
                    lblNombreImagen.Text = Path.GetFileName(dialogo.FileName);
                }
            }
        }

        /// <summary>
        /// Valida, construye el registro, lo agrega a la lista y grilla,
        /// y persiste en disco usando Utilitario.
        /// </summary>
        private void GuardarProducto()
        {
            // -- Validaciones --
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Ingresa el código del producto.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingresa el nombre del producto.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtProveedor.Text))
            {
                MessageBox.Show("Ingresa el proveedor.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProveedor.Focus();
                return;
            }
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Ingresa un precio válido.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }
            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Ingresa un stock válido.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return;
            }

            // -- Construir registro con valores limpios --
            string[] nuevo =
            {
                txtCodigo.Text.Trim(),
                txtNombre.Text.Trim(),
                txtDescripcion.Text.Trim(),
                txtProveedor.Text.Trim(),
                precio.ToString("0.00"),
                stock.ToString(),
                cmbEstado.SelectedItem.ToString(),
                rutaImagenSeleccionada
            };

            // -- Persistir: primero lista, luego disco --
            datos.Add(nuevo);
            Utilitario.GuardarArchivoTXT(ruta, datos);

            // -- Agregar fila a la grilla --
            int indice = dgvProductos.Rows.Add();
            DataGridViewRow fila = dgvProductos.Rows[indice];
            fila.Cells["colCodigo"].Value = nuevo[0];
            fila.Cells["colNombre"].Value = nuevo[1];
            fila.Cells["colDescripcion"].Value = nuevo[2];
            fila.Cells["colProveedor"].Value = nuevo[3];
            fila.Cells["colPrecio"].Value = nuevo[4];
            fila.Cells["colStock"].Value = nuevo[5];
            fila.Cells["colEstado"].Value = nuevo[6];
            fila.Cells["colImagen"].Value = nuevo[7];

            ColorearEstados();
            ActualizarResumen();
            LimpiarCampos();
            pnlNuevo.Visible = false;
        }

        /// <summary>
        /// Restablece todos los campos del panel a su estado inicial.
        /// </summary>
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtProveedor.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            cmbEstado.SelectedIndex = 0;
            lblNombreImagen.Text = "Sin imagen seleccionada";
            rutaImagenSeleccionada = "";
        }
    }
}