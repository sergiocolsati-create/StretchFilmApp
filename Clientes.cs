using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StretchFilmApp
{
    /// <summary>
    /// Formulario para gestionar clientes registrados.
    /// Muestra primero los clientes pendientes de aprobación (destacados),
    /// y luego la tabla completa con filtro por estado.
    /// </summary>
    public partial class Clientes : Form
    {
        /// <summary>Lista en memoria con los registros cargados desde el archivo.</summary>
        private readonly List<string[]> datos = new List<string[]>();

        /// <summary>Ruta absoluta al archivo TXT de clientes.</summary>
        private readonly string ruta = Path.Combine(Application.StartupPath, "Data2", "clientes.txt");

        /// <summary>Filtro de estado actualmente seleccionado en el ComboBox superior.</summary>
        private string filtroActual = "Todos";

        /// <summary>
        /// Constructor: inicializa controles, carga datos y vincula eventos.
        /// </summary>
        public Clientes()
        {
            InitializeComponent();

            Theme.EstilizarGrid(dgvClientes);

            CargarCombos();
            AsegurarArchivoEjemplo();
            CargarTodo();

            pnlNuevo.Visible = false;
            pnlNuevo.AgregarBotonCerrar(LimpiarCampos);

            btnNuevoCliente.Click += (s, e) => pnlNuevo.Visible = !pnlNuevo.Visible;
            btnLimpiar.Click += (s, e) => LimpiarCampos();
            btnGuardar.Click += (s, e) => GuardarCliente();
            btnRefrescar.Click += (s, e) => CargarTodo();
            cmbFiltroEstado.SelectedIndexChanged += (s, e) =>
            {
                filtroActual = cmbFiltroEstado.SelectedItem.ToString();
                ConstruirTabla();
            };
        }

        // ─── Inicialización ──────────────────────────────────────────────────────

        /// <summary>
        /// Llena el ComboBox de filtro (superior) y el ComboBox de Tipo y Estado
        /// del panel de registro.
        /// </summary>
        private void CargarCombos()
        {
            cmbFiltroEstado.Items.AddRange(new object[] { "Todos", "Activo", "Inactivo", "Pendiente" });
            cmbFiltroEstado.SelectedIndex = 0;

            cmbTipo.Items.AddRange(new object[] { "Contado", "Crédito" });
            cmbTipo.SelectedIndex = 0;

            cmbEstadoNuevo.Items.AddRange(new object[] { "Activo", "Inactivo", "Pendiente" });
            cmbEstadoNuevo.SelectedIndex = 2; // Pendiente por defecto, como en la imagen
        }

        /// <summary>
        /// Crea el archivo TXT con filas de ejemplo si todavía no existe.
        /// Formato: empresa, ruc, tipo, estado, solicitudes, contacto
        /// </summary>
        private void AsegurarArchivoEjemplo()
        {
            if (File.Exists(ruta)) return;
            Directory.CreateDirectory(Path.GetDirectoryName(ruta));

            string s = Utilitario.SEPARADOR.ToString();
            string[] demo =
            {
                string.Join(s, "RucosSAc",                          "20202020202", "Contado", "Pendiente", "1", "999999999"),
                string.Join(s, "Agro Export Inca S.A.C.",            "20311234505", "Crédito", "Activo",   "0", "995678901"),
                string.Join(s, "Logística Express S.R.L.",          "20311234504", "Contado", "Pendiente", "0", "994567890"),
                string.Join(s, "Corporación Almacenes S.A.",         "20311234503", "Crédito", "Activo",   "1", "993456789"),
                string.Join(s, "Empaques Perú E.I.R.L.",             "20311234502", "Contado", "Activo",   "2", "992345678"),
                string.Join(s, "Distribuidora Lima Norte S.A.C.",    "20311234501", "Crédito", "Activo",   "2", "991234567"),
                string.Join(s, "Nueva Empresa S.A.C.",               "20777888999", "Contado", "Activo",   "2", ""),
                string.Join(s, "Test Corp S.A.C.",                   "20111222333", "Contado", "Inactivo", "1", "999888777"),
                string.Join(s, "Industrias Textiles Andinas S.R.L.", "20456789012", "Crédito", "Pendiente", "1", "978901234"),
                string.Join(s, "Almacenes Generales Perú E.I.R.L.",  "20987654321", "Contado", "Inactivo", "1", "965432109"),
                string.Join(s, "Exportaciones del Pacífico S.A.C.",  "20123456789", "Crédito", "Activo",   "6", "992345678"),
                string.Join(s, "Test S.A.C",                         "20512345678", "Contado", "Activo",   "4", ""),
            };
            File.WriteAllLines(ruta, demo, Encoding.UTF8);
        }

        // ─── Carga y construcción ───────────────────────────────────────────────────

        /// <summary>
        /// Recarga los datos desde disco y reconstruye tanto la sección de
        /// "requieren aprobación" como la tabla completa.
        /// </summary>
        private void CargarTodo()
        {
            datos.Clear();
            if (File.Exists(ruta))
            {
                foreach (string linea in File.ReadAllLines(ruta, Encoding.UTF8))
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;
                    datos.Add(linea.Split(Utilitario.SEPARADOR));
                }
            }

            ConstruirPendientes();
            ConstruirTabla();
            ActualizarSubtitulo();
        }

        /// <summary>
        /// Construye las tarjetas amarillas de clientes en estado "Pendiente"
        /// que requieren aprobación.
        /// </summary>
        private void ConstruirPendientes()
        {
            pnlPendientes.Controls.Clear();

            var pendientes = datos.Where(c => c.Length >= 4 && c[3] == "Pendiente").ToList();

            lblPendientesTitulo.Visible = pendientes.Count > 0;

            int y = 0;
            foreach (string[] c in pendientes)
            {
                Panel tarjeta = CrearTarjetaPendiente(c[0], c[1], c[2]);
                tarjeta.Location = new Point(0, y);
                pnlPendientes.Controls.Add(tarjeta);
                y += tarjeta.Height + 6;
            }
            pnlPendientes.Height = Math.Max(y, 1);
        }

        /// <summary>
        /// Crea la tarjeta amarilla de un cliente pendiente con botones Aprobar/Rechazar.
        /// </summary>
        private Panel CrearTarjetaPendiente(string empresa, string ruc, string tipo)
        {
            var tarjeta = new Panel
            {
                Width = pnlPendientes.ClientSize.Width,
                Height = 50,
                BackColor = Color.FromArgb(254, 252, 232),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            var lblEmpresa = new Label { Text = empresa, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold), ForeColor = Color.FromArgb(31, 41, 55), Location = new Point(14, 8), AutoSize = true };
            tarjeta.Controls.Add(lblEmpresa);

            var lblDetalle = new Label { Text = $"RUC {ruc} · {tipo.ToUpper()}", Font = new Font("Segoe UI", 8F), ForeColor = Color.FromArgb(180, 150, 60), Location = new Point(14, 28), AutoSize = true };
            tarjeta.Controls.Add(lblDetalle);

            var btnAprobar = new Button
            {
                Text = "✓ Aprobar",
                Size = new Size(90, 28),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                BackColor = Color.FromArgb(220, 252, 231),
                ForeColor = Color.FromArgb(22, 163, 74),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold)
            };
            btnAprobar.FlatAppearance.BorderSize = 0;
            btnAprobar.Location = new Point(tarjeta.Width - 200, 11);
            btnAprobar.Click += (s, e) => CambiarEstadoCliente(empresa, "Activo");
            tarjeta.Controls.Add(btnAprobar);

            var btnRechazar = new Button
            {
                Text = "✕ Rechazar",
                Size = new Size(95, 28),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                BackColor = Color.FromArgb(254, 226, 226),
                ForeColor = Color.FromArgb(220, 38, 38),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold)
            };
            btnRechazar.FlatAppearance.BorderSize = 0;
            btnRechazar.Location = new Point(tarjeta.Width - 100, 11);
            btnRechazar.Click += (s, e) => CambiarEstadoCliente(empresa, "Inactivo");
            tarjeta.Controls.Add(btnRechazar);

            return tarjeta;
        }

        /// <summary>
        /// Reconstruye la grilla principal aplicando el filtro de estado seleccionado.
        /// Se llama tanto al cargar el form como cada vez que el usuario cambia el ComboBox.
        /// </summary>
        private void ConstruirTabla()
        {
            // Limpia todas las filas visuales actuales para redibujar desde cero
            dgvClientes.Rows.Clear();

            // Decide qué registros mostrar según el filtro activo:
            // - "Todos"  → usa la lista completa sin ningún criterio
            // - cualquier otro valor → filtra con LINQ comparando c[3] (columna Estado)
            var filtrados = filtroActual == "Todos"
                ? datos
                : datos.Where(c => c.Length >= 4 && c[3] == filtroActual).ToList();
            //                     ↑ evita crash si una línea del TXT tiene menos de 4 columnas

            // Recorre solo los registros que pasaron el filtro
            foreach (string[] c in filtrados)
            {
                // Seguridad: ignora líneas incompletas del archivo (necesita mínimo 6 columnas)
                if (c.Length < 6) continue;

                // Agrega una fila vacía y obtiene su índice para luego rellenarla
                int indice = dgvClientes.Rows.Add();
                DataGridViewRow fila = dgvClientes.Rows[indice];

                // Mapea cada posición del array a su columna correspondiente en la grilla
                fila.Cells["colEmpresa"].Value = c[0]; // nombre de la empresa
                fila.Cells["colRuc"].Value = c[1]; // RUC
                fila.Cells["colTipo"].Value = c[2]; // Contado / Crédito
                fila.Cells["colEstadoTabla"].Value = c[3]; // Activo / Inactivo / Pendiente
                fila.Cells["colSolicitudes"].Value = c[4]; // número de pedidos
                                                           // Si el contacto está vacío, muestra "—" en lugar de una celda en blanco
                fila.Cells["colContacto"].Value = string.IsNullOrWhiteSpace(c[5]) ? "—" : c[5];
            }

            // Tras poblar la grilla, aplica colores según el estado y tipo de cada fila
            ColorearEstadosTabla();
        }

        /// <summary>
        /// Aplica color al texto de la columna Estado y Tipo según su valor.
        /// </summary>
        private void ColorearEstadosTabla()
        {
            var fontBold = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            foreach (DataGridViewRow fila in dgvClientes.Rows)
            {
                string estado = fila.Cells["colEstadoTabla"].Value?.ToString() ?? "";
                fila.Cells["colEstadoTabla"].Style.Font = fontBold;
                Color colorEstado;
                if (estado == "Activo") colorEstado = Theme.Verde;
                else if (estado == "Pendiente") colorEstado = Color.FromArgb(180, 130, 20);
                else colorEstado = Theme.TextoTenue;
                fila.Cells["colEstadoTabla"].Style.ForeColor = colorEstado;

                string tipo = fila.Cells["colTipo"].Value?.ToString() ?? "";
                fila.Cells["colTipo"].Style.Font = fontBold;
                fila.Cells["colTipo"].Style.ForeColor = tipo == "Crédito"
                    ? Color.FromArgb(37, 99, 235)
                    : Color.FromArgb(180, 130, 20);
            }
        }

        /// <summary>
        /// Actualiza el subtítulo con el total de clientes registrados.
        /// </summary>
        private void ActualizarSubtitulo()
        {
            lblSubtitulo.Text = $"{datos.Count} cliente{(datos.Count != 1 ? "s" : "")}";
        }

        /// <summary>
        /// Cambia el estado de un cliente (por nombre de empresa) y persiste el cambio.
        /// Usado tanto por Aprobar/Rechazar como podría usarse desde otros botones futuros.
        /// </summary>
        private void CambiarEstadoCliente(string empresa, string nuevoEstado)
        {
            var fila = datos.FirstOrDefault(c => c.Length > 0 && c[0] == empresa);
            if (fila != null && fila.Length >= 4) fila[3] = nuevoEstado;
            Utilitario.GuardarArchivoTXT(ruta, datos);
            CargarTodo();
        }

        // ─── Panel "Nuevo cliente" ───────────────────────────────────────────────

        /// <summary>
        /// Valida, construye el registro, lo agrega a la lista y persiste en disco.
        /// </summary>
        private void GuardarCliente()
        {
            if (string.IsNullOrWhiteSpace(txtEmpresa.Text))
            {
                MessageBox.Show("Ingresa el nombre de la empresa.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmpresa.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtRuc.Text))
            {
                MessageBox.Show("Ingresa el RUC.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRuc.Focus();
                return;
            }

            string[] nuevo =
            {
                txtEmpresa.Text.Trim(),
                txtRuc.Text.Trim(),
                cmbTipo.SelectedItem.ToString(),
                cmbEstadoNuevo.SelectedItem.ToString(),
                "0",
                txtContacto.Text.Trim()
            };

            datos.Add(nuevo);
            Utilitario.GuardarArchivoTXT(ruta, datos);

            CargarTodo();
            LimpiarCampos();
            pnlNuevo.Visible = false;
        }

        /// <summary>
        /// Restablece todos los campos del panel a su estado inicial.
        /// </summary>
        private void LimpiarCampos()
        {
            txtEmpresa.Clear();
            txtRuc.Clear();
            txtContacto.Clear();
            cmbTipo.SelectedIndex = 0;
            cmbEstadoNuevo.SelectedIndex = 2;
        }
    }
}