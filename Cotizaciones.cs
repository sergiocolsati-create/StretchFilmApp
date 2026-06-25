using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace StretchFilmApp
{
    /// <summary>
    /// Formulario para gestionar cotizaciones con validación de margen automática.
    /// Calcula ganancia en tiempo real y persiste en TXT usando Utilitario.
    /// </summary>
    public partial class Cotizaciones : Form
    {
        /// <summary>Lista en memoria con los registros cargados desde el archivo.</summary>
        private readonly List<string[]> datos = new List<string[]>();

        /// <summary>Ruta absoluta al archivo TXT de cotizaciones.</summary>
        private readonly string ruta = Path.Combine(Application.StartupPath, "Data2", "cotizaciones.txt");

        /// <summary>
        /// Constructor: inicializa controles, carga datos y vincula eventos.
        /// </summary>
        public Cotizaciones()
        {
            InitializeComponent();

            Theme.EstilizarGrid(dgvCotizaciones);
            CargarCombos();
            AsegurarArchivoEjemplo();
            Utilitario.CargarArchivoTXT(ruta, datos, dgvCotizaciones);
            FormatearGrilla();
            ColorearFilas();

            pnlNueva.Visible = false;
            btnNuevaCotizacion.Click += (s, e) => pnlNueva.Visible = !pnlNueva.Visible;
            btnLimpiar.Click += (s, e) => LimpiarCampos();
            btnGuardar.Click += (s, e) => GuardarCotizacion();

            // Recalcula ganancia en tiempo real.
            numCajas.ValueChanged += (s, e) => ActualizarVistaPrevia();
            numPrecio.ValueChanged += (s, e) => ActualizarVistaPrevia();
            numMargen.ValueChanged += (s, e) => ActualizarVistaPrevia();
        }

        // ─── Inicialización ──────────────────────────────────────────────────────

        /// <summary>
        /// Llena el ComboBox de estado. Cliente y Producto son TextBox libres.
        /// </summary>
        private void CargarCombos()
        {
            cmbEstado.Items.AddRange(new object[]
                { "APROBADA", "PENDIENTE", "RECHAZADA", "VENCIDA" });
        }

        /// <summary>
        /// Crea el archivo TXT con filas de ejemplo si todavía no existe.
        /// Los valores numéricos se guardan limpios (sin S/. ni %).
        /// </summary>
        private void AsegurarArchivoEjemplo()
        {
            if (File.Exists(ruta)) return;
            Directory.CreateDirectory(Path.GetDirectoryName(ruta));

            string s = Utilitario.SEPARADOR.ToString();
            string[] demo =
            {
                string.Join(s, "#486c6", "RucosSAc",                          "Stretch Film 25µm x 500m",             "1",   "40.00",  "25.0", "8.00",    "APROBADA",  "20/5/2026"),
                string.Join(s, "#48fbf", "Distribuidora Lima Norte S.A.C.",    "Stretch Film 20µm alta resistencia",   "60",  "6.25",   "25.0", "75.00",   "APROBADA",  "31/5/2026"),
                string.Join(s, "#ec048", "Test S.A.C",                          "Stretch Film 25µm carga paletizada",   "120", "35.63",  "25.0", "855.60",  "APROBADA",  "17/5/2026"),
                string.Join(s, "#0bd2d", "Empaques Perú E.I.R.L.",             "Stretch Film Industrial alta tracción","200", "35.63",  "25.0", "1425.20", "APROBADA",  "17/5/2026"),
                string.Join(s, "#43eff", "Exportaciones del Pacífico S.A.C.",  "Stretch Film 25µm x 500m",             "40",  "6.25",   "25.0", "50.00",   "APROBADA",  "30/5/2026"),
                string.Join(s, "#b7019", "Industrias Textiles Andinas S.R.L.", "Stretch Film 25µm",                    "30",  "35.63",  "25.0", "214.38",  "APROBADA",  "17/5/2026"),
            };
            File.WriteAllLines(ruta, demo, Encoding.UTF8);
        }

        // ─── Grilla ──────────────────────────────────────────────────────────────

        /// <summary>
        /// Recorre la grilla ya cargada por Utilitario y aplica formato visual
        /// (S/. y %) a las columnas numéricas sin tocar la lista <see cref="datos"/>.
        /// </summary>
        private void FormatearGrilla()
        {
            foreach (DataGridViewRow fila in dgvCotizaciones.Rows)
            {
                FormatearCelda(fila, "colPrecio", "S/.", "");
                FormatearCelda(fila, "colGanancia", "S/.", "");
                FormatearCelda(fila, "colMargen", "", "%");
            }
        }

        /// <summary>
        /// Agrega prefijo/sufijo a una celda solo si aún no los tiene,
        /// evitando duplicar símbolos al recargar.
        /// </summary>
        private void FormatearCelda(DataGridViewRow fila, string nombreCol,
                                    string prefijo, string sufijo)
        {
            var celda = fila.Cells[nombreCol];
            string valor = celda.Value?.ToString() ?? "";
            if (!valor.StartsWith(prefijo) || !valor.EndsWith(sufijo))
                celda.Value = $"{prefijo}{valor}{sufijo}";
        }

        /// <summary>
        /// Aplica colores a Estado (verde = APROBADA) y Margen (siempre verde).
        /// </summary>
        private void ColorearFilas()
        {
            var fontBold = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            foreach (DataGridViewRow fila in dgvCotizaciones.Rows)
            {
                var celdaEstado = fila.Cells["colEstado"];
                celdaEstado.Style.ForeColor =
                    celdaEstado.Value?.ToString() == "APROBADA" ? Theme.Verde : Theme.TextoTenue;
                celdaEstado.Style.Font = fontBold;

                fila.Cells["colMargen"].Style.ForeColor = Theme.Verde;
                fila.Cells["colMargen"].Style.Font = fontBold;
            }
        }

        // ─── Panel "Nueva cotización" ─────────────────────────────────────────────

        /// <summary>
        /// Calcula ganancia = cajas × precio × (margen / 100) y actualiza la etiqueta
        /// de vista previa en tiempo real mientras el usuario edita los campos.
        /// </summary>
        private void ActualizarVistaPrevia()
        {
            decimal ganancia = numCajas.Value * numPrecio.Value * (numMargen.Value / 100);
            lblGananciaPrevia.Text = $"Ganancia est.: S/.{ganancia:N2}";
        }

        /// <summary>
        /// Valida los campos, calcula la ganancia, construye el registro limpio,
        /// lo agrega a <see cref="datos"/>, persiste con Utilitario y actualiza la grilla.
        /// </summary>
        private void GuardarCotizacion()
        {
            // -- Validaciones --
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Ingresa el nombre del cliente.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show("Ingresa el nombre del producto.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducto.Focus();
                return;
            }
            if (numPrecio.Value <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a cero.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbEstado.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un estado.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // -- Cálculos --
            decimal precio = numPrecio.Value;
            decimal margen = numMargen.Value;
            decimal cajas = numCajas.Value;
            decimal ganancia = cajas * precio * (margen / 100m);

            // -- Registro limpio (sin S/. ni %) para el TXT --
            string[] nuevo =
            {
                "#" + DateTime.Now.ToString("HHmmss"),
                txtCliente.Text.Trim(),
                txtProducto.Text.Trim(),
                cajas.ToString("0"),
                precio.ToString("0.00"),
                margen.ToString("0.0"),
                ganancia.ToString("0.00"),
                cmbEstado.SelectedItem.ToString(),
                dtpVence.Value.ToString("d/M/yyyy")
            };

            // -- Persistir: primero lista, luego disco con Utilitario --
            datos.Add(nuevo);
            Utilitario.GuardarArchivoTXT(ruta, datos);

            // -- Agregar fila a la grilla con formato visual --
            int indice = dgvCotizaciones.Rows.Add();
            DataGridViewRow fila = dgvCotizaciones.Rows[indice];
            fila.Cells["colNum"].Value = nuevo[0];
            fila.Cells["colCliente"].Value = nuevo[1];
            fila.Cells["colProducto"].Value = nuevo[2];
            fila.Cells["colCajas"].Value = nuevo[3];
            fila.Cells["colPrecio"].Value = $"S/.{nuevo[4]}";
            fila.Cells["colMargen"].Value = $"{nuevo[5]}%";
            fila.Cells["colGanancia"].Value = $"S/.{nuevo[6]}";
            fila.Cells["colEstado"].Value = nuevo[7];
            fila.Cells["colVence"].Value = nuevo[8];

            ColorearFilas();
            LimpiarCampos();
            pnlNueva.Visible = false;
        }

        /// <summary>
        /// Restablece todos los campos del panel a su estado inicial.
        /// </summary>
        private void LimpiarCampos()
        {
            txtCliente.Clear();
            txtProducto.Clear();
            numCajas.Value = 0;
            numPrecio.Value = 0;
            numMargen.Value = 25;
            cmbEstado.SelectedIndex = -1;
            dtpVence.Value = DateTime.Today;
            lblGananciaPrevia.Text = "Ganancia est.: S/.0.00";
        }
    }
}