using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace StretchFilmApp
{
    /// <summary>
    /// Formulario para gestionar proveedores.
    /// Permite registrar, visualizar y persistir proveedores en TXT.
    /// </summary>
    public partial class Proveedores : Form
    {
        List<string[]> datos = new List<string[]>();
        string ruta = Path.Combine(Application.StartupPath, "Data2", "proveedores.txt");

        public Proveedores()
        {
            InitializeComponent();

            // Configurar columnas
            dgvProveedores.ColumnCount = 7;
            dgvProveedores.Columns[0].Name = "PROVEEDOR";
            dgvProveedores.Columns[1].Name = "RUC";
            dgvProveedores.Columns[2].Name = "CONTACTO";
            dgvProveedores.Columns[3].Name = "TELEFONO";
            dgvProveedores.Columns[4].Name = "EMAIL";
            dgvProveedores.Columns[5].Name = "PRODUCTOS";
            dgvProveedores.Columns[6].Name = "ESTADO";

            dgvProveedores.Columns[0].Width = 200;
            dgvProveedores.Columns[1].Width = 120;
            dgvProveedores.Columns[2].Width = 120;
            dgvProveedores.Columns[3].Width = 110;
            dgvProveedores.Columns[4].Width = 120;
            dgvProveedores.Columns[5].Width = 80;
            dgvProveedores.Columns[6].Width = 90;

            // Columnas de acción
            dgvProveedores.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "EDITAR",
                HeaderText = "ACCIONES",
                Text = "✏",
                UseColumnTextForButtonValue = true,
                Width = 40
            });
            dgvProveedores.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "DESACTIVAR",
                HeaderText = "",
                Text = "Desactivar",
                UseColumnTextForButtonValue = true,
                Width = 90
            });
            dgvProveedores.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "ELIMINAR",
                HeaderText = "",
                Text = "🗑",
                UseColumnTextForButtonValue = true,
                Width = 40
            });

            Theme.EstilizarGrid(dgvProveedores);
            CargarCombos();
            AsegurarArchivoEjemplo();
            Utilitario.CargarArchivoTXT(ruta, datos, dgvProveedores);   // 👈 movido aquí
            ColorearEstados();
            ActualizarContador();                                       // 👈 movido aquí

            pnlNueva.Visible = false;
            btnNuevoProveedor.Click += (s, e) => pnlNueva.Visible = !pnlNueva.Visible;
            btnLimpiar.Click += (s, e) => LimpiarCampos();
            btnGuardar.Click += (s, e) => GuardarProveedor();
        }

       

        /// <summary>
        /// Llena el ComboBox de estado con sus opciones fijas.
        /// </summary>
        private void CargarCombos()
        {
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.SelectedIndex = 0;
        }

        /// <summary>
        /// Crea el archivo TXT con filas de ejemplo si todavía no existe.
        /// </summary>
        private void AsegurarArchivoEjemplo()
        {
            if (File.Exists(ruta)) return;
            Directory.CreateDirectory(Path.GetDirectoryName(ruta));

            string s = Utilitario.SEPARADOR.ToString();
            string[] demo =
            {
                string.Join(s, "Papayas.sac",                   "2020202020",  "Papayon",        "9999999",   "papayita@papaya.com",    "1", "Activo"),
                string.Join(s, "Plastificados del Norte S.A.C.", "20501234567", "Jorge Mendoza",  "994123456", "ventas@plastnorte.pe",   "2", "Activo"),
                string.Join(s, "PolyPack Industrial E.I.R.L.",   "20609876543", "Carmen Quispe",  "981654321", "info@polypack.com.pe",   "2", "Activo"),
            };
            File.WriteAllLines(ruta, demo, Encoding.UTF8);
        }

        /// <summary>
        /// Aplica color verde a ESTADO Activo, gris para Inactivo.
        /// </summary>
        private void ColorearEstados()
        {
            var fontBold = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            foreach (DataGridViewRow fila in dgvProveedores.Rows)
            {
                var celda = fila.Cells["ESTADO"];
                string estado = celda.Value?.ToString() ?? "";
                celda.Style.ForeColor = estado == "Activo" ? Theme.Verde : Theme.TextoTenue;
                celda.Style.Font = fontBold;
            }
        }

        /// <summary>
        /// Actualiza el subtítulo con el conteo actual de proveedores.
        /// </summary>
        private void ActualizarContador()
        {
            lblSubtitulo.Text = $"{datos.Count} proveedor{(datos.Count != 1 ? "es" : "")}";
        }

        /// <summary>
        /// Valida, construye el registro, lo agrega a la lista, persiste y refresca.
        /// </summary>
        private void GuardarProveedor()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingresa el nombre del proveedor.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus(); return;
            }
            if (string.IsNullOrWhiteSpace(txtRuc.Text))
            {
                MessageBox.Show("Ingresa el RUC.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRuc.Focus(); return;
            }

            string[] nuevo =
            {
                txtNombre.Text.Trim(),
                txtRuc.Text.Trim(),
                txtContacto.Text.Trim(),
                txtTelefono.Text.Trim(),
                txtEmail.Text.Trim(),
                txtProductos.Text.Trim() == "" ? "0" : txtProductos.Text.Trim(),
                cmbEstado.SelectedItem.ToString()
            };

            datos.Add(nuevo);
            Utilitario.GuardarArchivoTXT(ruta, datos);
            Utilitario.CargarArchivoTXT(ruta, datos, dgvProveedores);
            ColorearEstados();
            ActualizarContador();
            LimpiarCampos();
            pnlNueva.Visible = false;
        }

        /// <summary>
        /// Restablece todos los campos del panel a su estado inicial.
        /// </summary>
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtRuc.Clear();
            txtContacto.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtProductos.Clear();
            cmbEstado.SelectedIndex = 0;
        }
    }
}