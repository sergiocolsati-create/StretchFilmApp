using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace StretchFilmApp
{
    /// <summary>
    /// Formulario para gestionar solicitudes del pipeline de ventas.
    /// Permite registrar, visualizar, filtrar y persistir solicitudes en TXT.
    /// </summary>
    public partial class Solicitudes : Form
    {
        /// <summary>Lista en memoria con los registros cargados desde el archivo.</summary>
        private readonly List<string[]> datos = new List<string[]>();

        /// <summary>Ruta absoluta al archivo TXT de solicitudes.</summary>
        private readonly string ruta = Path.Combine(Application.StartupPath, "Data2", "solicitudes.txt");

        /// <summary>
        /// Constructor: inicializa controles, carga datos y vincula eventos.
        /// </summary>
        public Solicitudes()
        {
            InitializeComponent();

            Theme.EstilizarGrid(dgvSolicitudes);

            CargarCombos();
            AsegurarArchivoEjemplo();
            Utilitario.CargarArchivoTXT(ruta, datos, dgvSolicitudes);
            ColorearEstados();

            pnlNueva.Visible = false;
            pnlNueva.AgregarBotonCerrar(LimpiarCampos);

            btnNuevaSolicitud.Click += (s, e) => pnlNueva.Visible = !pnlNueva.Visible;
            btnLimpiar.Click += (s, e) => LimpiarCampos();
            btnGuardar.Click += (s, e) => GuardarSolicitud();
        }

        // ─── Inicialización ──────────────────────────────────────────────────────

        /// <summary>
        /// Llena los ComboBox de filtro, canal y estado con sus opciones fijas.
        /// </summary>
        private void CargarCombos()
        {
            cmbEstadoFiltro.Items.AddRange(new object[] { "Todos", "Pendiente", "En proceso" });
            cmbEstadoFiltro.SelectedIndex = 0;
            cmbCanal.Items.AddRange(new object[] { "EMAIL", "WHATSAPP", "TELEFONO", "WEB", "PRESENCIAL" });
            cmbEstado.Items.AddRange(new object[] { "PENDIENTE", "EN_PROCESO" });
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
                string.Join(s, "#5f0373", "Nueva Empresa S.A.C.",             "Stretch Film 25µm estándar",           "300", "EMAIL",     "EN_PROCESO", "18/5/2026"),
                string.Join(s, "#a15b48", "Exportaciones del Pacífico S.A.C.","Stretch Film Negro 30µm",              "80",  "WHATSAPP",  "PENDIENTE",  "18/5/2026"),
                string.Join(s, "#99cd1e", "Test S.A.C",                        "Stretch Film Industrial 23µm",         "150", "TELEFONO",  "PENDIENTE",  "18/5/2026"),
                string.Join(s, "#6e135b", "Exportaciones del Pacífico S.A.C.","Stretch Film 25µm x 500m",             "40",  "WEB",       "PENDIENTE",  "17/5/2026"),
                string.Join(s, "#b0efb8", "Corporación Almacenes S.A.",        "Stretch Film Industrial alta tracción","200", "EMAIL",     "PENDIENTE",  "17/5/2026"),
                string.Join(s, "#a4b573", "Empaques Perú E.I.R.L.",            "Stretch Film 20µm alta resistencia",  "60",  "PRESENCIAL","PENDIENTE",  "17/5/2026"),
                string.Join(s, "#162209", "Distribuidora Lima Norte S.A.C.",   "Stretch Film 25µm estándar",           "300", "EMAIL",     "EN_PROCESO", "17/5/2026"),
            };
            File.WriteAllLines(ruta, demo, Encoding.UTF8);
        }

        // ─── Grilla ──────────────────────────────────────────────────────────────

        /// <summary>
        /// Aplica color e ícono al campo Estado: amarillo para EN_PROCESO, azul para PENDIENTE.
        /// </summary>
        private void ColorearEstados()
        {
            var fontBold = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            foreach (DataGridViewRow fila in dgvSolicitudes.Rows)
            {
                var celda = fila.Cells["colEstado"];
                string estado = celda.Value?.ToString() ?? "";
                celda.Style.ForeColor = estado == "EN_PROCESO" ? Theme.Ambar : Theme.Azul;
                celda.Style.Font = fontBold;
            }
        }

        // ─── Panel "Nueva solicitud" ──────────────────────────────────────────────

        /// <summary>
        /// Valida, construye el registro, lo agrega a la lista y grilla,
        /// y persiste en disco usando Utilitario.
        /// </summary>
        private void GuardarSolicitud()
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
            if (cmbCanal.SelectedIndex < 0 || cmbEstado.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona Canal y Estado.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // -- Construir registro con valores limpios --
            string[] nuevo =
            {
                "#" + DateTime.Now.ToString("HHmmss"),
                txtCliente.Text.Trim(),
                txtProducto.Text.Trim(),
                numCajas.Value.ToString("0"),
                cmbCanal.SelectedItem.ToString(),
                cmbEstado.SelectedItem.ToString(),
                DateTime.Now.ToString("d/M/yyyy")
            };

            // -- Persistir: primero lista, luego disco --
            datos.Add(nuevo);
            Utilitario.GuardarArchivoTXT(ruta, datos);

            // -- Agregar fila a la grilla --
            int indice = dgvSolicitudes.Rows.Add();
            DataGridViewRow fila = dgvSolicitudes.Rows[indice];
            fila.Cells["colId"].Value = nuevo[0];
            fila.Cells["colCliente"].Value = nuevo[1];
            fila.Cells["colProducto"].Value = nuevo[2];
            fila.Cells["colCajas"].Value = nuevo[3];
            fila.Cells["colCanal"].Value = nuevo[4];
            fila.Cells["colEstado"].Value = nuevo[5];
            fila.Cells["colFecha"].Value = nuevo[6];

            ColorearEstados();
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
            cmbCanal.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            txtObservacion.Clear();
        }
    }
}