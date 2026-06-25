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
    /// Formulario para gestionar órdenes de adquisición (compra) generadas
    /// desde cotizaciones aprobadas. Permite registrar, visualizar, filtrar
    /// por estado y persistir las órdenes en TXT.
    /// </summary>
    public partial class Adquisicion : Form
    {
        /// <summary>Lista en memoria con los registros cargados desde el archivo.</summary>
        private readonly List<string[]> datos = new List<string[]>();

        /// <summary>Ruta absoluta al archivo TXT de órdenes de adquisición.</summary>
        private readonly string ruta = Path.Combine(Application.StartupPath, "Data2", "adquisicion.txt");

        /// <summary>Estados disponibles para las órdenes, en el orden en que se muestran los filtros.</summary>
        private readonly string[] estados = { "CREADA", "CONFIRMADA", "RECIBIDA", "TERMINADA", "CANCELADA" };

        /// <summary>Filtro de estado actualmente seleccionado ("Todos" o uno de los estados).</summary>
        private string filtroActual = "Todos";

        /// <summary>Botones de filtro tipo "pill", para poder resaltar el seleccionado.</summary>
        private readonly List<Button> botonesFiltro = new List<Button>();

        /// <summary>
        /// Constructor: inicializa controles, carga datos y vincula eventos.
        /// </summary>
        public Adquisicion()
        {
            InitializeComponent();

            CrearFiltrosPill();
            CargarCombos();
            AsegurarArchivoEjemplo();
            CargarLista();

            pnlNueva.Visible = false;
            pnlNueva.AgregarBotonCerrar(LimpiarCampos);
            btnNuevaOrden.Click += (s, e) => pnlNueva.Visible = !pnlNueva.Visible;
            btnLimpiar.Click += (s, e) => LimpiarCampos();
            btnGuardar.Click += (s, e) => GuardarOrden();
        }

        // ─── Inicialización ──────────────────────────────────────────────────────

        /// <summary>
        /// Llena el ComboBox de Estado del panel de registro con los estados fijos.
        /// </summary>
        private void CargarCombos()
        {
            cmbEstado.Items.AddRange(estados);
            cmbEstado.SelectedIndex = 0;
        }

        /// <summary>
        /// Crea dinámicamente los botones de filtro tipo "pill" (Todos + cada estado)
        /// dentro de pnlFiltros, replicando el estilo de tabs redondeados.
        /// </summary>
        private void CrearFiltrosPill()
        {
            var opciones = new List<string> { "Todos" };
            opciones.AddRange(estados);

            int x = 0;
            foreach (string opcion in opciones)
            {
                var boton = new Button
                {
                    Text = opcion,
                    Tag = opcion,
                    Height = 30,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                    Location = new Point(x, 4),
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    Padding = new Padding(14, 0, 14, 0)
                };
                boton.FlatAppearance.BorderSize = 1;
                boton.Click += (s, e) =>
                {
                    filtroActual = (string)boton.Tag;
                    ActualizarEstiloFiltros();
                    CargarLista();
                };

                pnlFiltros.Controls.Add(boton);
                botonesFiltro.Add(boton);
                x += boton.Width + 8;
            }

            ActualizarEstiloFiltros();
        }

        /// <summary>
        /// Resalta en verde el botón de filtro activo y deja los demás en blanco/gris.
        /// </summary>
        private void ActualizarEstiloFiltros()
        {
            foreach (Button boton in botonesFiltro)
            {
                bool activo = (string)boton.Tag == filtroActual;
                boton.BackColor = activo ? Theme.Verde : Color.White;
                boton.ForeColor = activo ? Color.White : Color.FromArgb(55, 65, 81);
                boton.FlatAppearance.BorderColor = activo ? Theme.Verde : Color.FromArgb(229, 231, 235);
            }
            // Reacomoda posiciones por si AutoSize cambió anchos.
            int x = 0;
            foreach (Button boton in botonesFiltro)
            {
                boton.Location = new Point(x, 4);
                x += boton.Width + 8;
            }
        }

        /// <summary>
        /// Crea el archivo TXT con filas de ejemplo si todavía no existe.
        /// Formato: cliente, proveedor, monto, estado, fecha
        /// </summary>
        private void AsegurarArchivoEjemplo()
        {
            if (File.Exists(ruta)) return;
            Directory.CreateDirectory(Path.GetDirectoryName(ruta));

            string s = Utilitario.SEPARADOR.ToString();
            string[] demo =
            {
                string.Join(s, "RucosSAc",                         "Plastificados del Norte S.A.C.", "40.00",   "CREADA",     "20/5/2026"),
                string.Join(s, "Distribuidora Lima Norte S.A.C.",   "Papayas.sac",                    "375.00",  "CREADA",     "20/5/2026"),
                string.Join(s, "Test S.A.C",                        "Plastificados del Norte S.A.C.", "4275.00", "TERMINADA",  "19/5/2026"),
                string.Join(s, "Empaques Perú E.I.R.L.",            "Plastificados del Norte S.A.C.", "7125.00", "CREADA",     "19/5/2026"),
                string.Join(s, "Exportaciones del Pacífico S.A.C.", "Plastificados del Norte S.A.C.", "4000.00", "CONFIRMADA", "18/5/2026"),
                string.Join(s, "Exportaciones del Pacífico S.A.C.", "Papayas.sac",                    "250.00",  "CREADA",     "18/5/2026"),
                string.Join(s, "Test S.A.C",                        "Papayas.sac",                    "62.50",   "TERMINADA",  "17/5/2026"),
                string.Join(s, "Industrias Textiles Andinas S.R.L.","Plastificados del Norte S.A.C.", "1068.75", "RECIBIDA",   "17/5/2026"),
            };
            File.WriteAllLines(ruta, demo, Encoding.UTF8);
        }

        // ─── Lista ───────────────────────────────────────────────────────────────

        /// <summary>
        /// Recarga los datos desde disco y reconstruye la lista visual aplicando
        /// el filtro de estado actualmente seleccionado.
        /// </summary>
        private void CargarLista()
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

            pnlLista.Controls.Clear();
            pnlLista.SuspendLayout();

            var filtrados = filtroActual == "Todos"
                ? datos
                : datos.Where(o => o.Length >= 4 && o[3] == filtroActual).ToList();

            int y = 0;
            foreach (string[] orden in filtrados)
            {
                if (orden.Length < 5) continue;

                Panel fila = CrearFilaOrden(orden[0], orden[1], orden[2], orden[3], orden[4]);
                fila.Location = new Point(0, y);
                pnlLista.Controls.Add(fila);
                y += fila.Height + fila.Margin.Bottom;
            }

            pnlLista.ResumeLayout();
            ActualizarSubtitulo();
        }

        /// <summary>
        /// Construye una fila visual (cliente, proveedor, monto, estado) imitando
        /// el diseño de lista con tarjeta blanca por fila.
        /// </summary>
        private Panel CrearFilaOrden(string cliente, string proveedor, string monto, string estado, string fecha)
        {
            var fila = new Panel
            {
                Width = pnlLista.ClientSize.Width - 20,
                Height = 56,
                Margin = new Padding(0, 0, 0, 6),
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            var lblFlecha = new Label
            {
                Text = "˅",
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(156, 163, 175),
                Location = new Point(14, 18),
                AutoSize = true
            };
            fila.Controls.Add(lblFlecha);

            var lblCliente = new Label
            {
                Text = cliente,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 41, 55),
                Location = new Point(36, 9),
                AutoSize = true
            };
            fila.Controls.Add(lblCliente);

            var lblProveedor = new Label
            {
                Text = proveedor,
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(156, 163, 175),
                Location = new Point(36, 30),
                AutoSize = true
            };
            fila.Controls.Add(lblProveedor);

            decimal montoNum = decimal.TryParse(monto, out decimal m) ? m : 0;
            var lblMonto = new Label
            {
                Text = "S/." + montoNum.ToString("N2"),
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = Color.FromArgb(31, 41, 55),
                AutoSize = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            lblMonto.Location = new Point(fila.Width - 230, 18);
            fila.Controls.Add(lblMonto);

            var lblEstado = new Label
            {
                Text = estado,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                AutoSize = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                BackColor = ColorFondoEstado(estado),
                ForeColor = ColorTextoEstado(estado),
                Padding = new Padding(10, 4, 10, 4)
            };
            lblEstado.Location = new Point(fila.Width - 110, 14);
            fila.Controls.Add(lblEstado);

            return fila;
        }

        /// <summary>Color de fondo de la etiqueta de estado, según el valor.</summary>
        private Color ColorFondoEstado(string estado)
        {
            switch (estado)
            {
                case "CREADA": return Color.FromArgb(219, 234, 254);
                case "CONFIRMADA": return Color.FromArgb(254, 243, 199);
                case "RECIBIDA": return Color.FromArgb(237, 233, 254);
                case "TERMINADA": return Color.FromArgb(220, 252, 231);
                case "CANCELADA": return Color.FromArgb(254, 226, 226);
                default: return Color.FromArgb(243, 244, 246);
            }
        }

        /// <summary>Color de texto de la etiqueta de estado, según el valor.</summary>
        private Color ColorTextoEstado(string estado)
        {
            switch (estado)
            {
                case "CREADA": return Color.FromArgb(37, 99, 235);
                case "CONFIRMADA": return Color.FromArgb(180, 83, 9);
                case "RECIBIDA": return Color.FromArgb(124, 58, 237);
                case "TERMINADA": return Color.FromArgb(22, 163, 74);
                case "CANCELADA": return Color.FromArgb(220, 38, 38);
                default: return Color.FromArgb(107, 114, 128);
            }
        }

        /// <summary>
        /// Actualiza el subtítulo con el conteo de órdenes visibles según el filtro.
        /// </summary>
        private void ActualizarSubtitulo()
        {
            int total = filtroActual == "Todos"
                ? datos.Count
                : datos.Count(o => o.Length >= 4 && o[3] == filtroActual);

            lblSubtitulo.Text = "Órdenes de compra generadas desde cotizaciones aprobadas";
        }

        // ─── Panel "Nueva orden" ─────────────────────────────────────────────────

        /// <summary>
        /// Valida, construye el registro, lo agrega a la lista y persiste en disco.
        /// </summary>
        private void GuardarOrden()
        {
            // -- Validaciones --
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Ingresa el nombre del cliente.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtProveedor.Text))
            {
                MessageBox.Show("Ingresa el proveedor.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProveedor.Focus();
                return;
            }
            if (!decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                MessageBox.Show("Ingresa un monto válido.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
                return;
            }
            if (cmbEstado.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona el estado de la orden.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // -- Construir registro con valores limpios --
            string[] nuevo =
            {
                txtCliente.Text.Trim(),
                txtProveedor.Text.Trim(),
                monto.ToString("0.00"),
                cmbEstado.SelectedItem.ToString(),
                DateTime.Now.ToString("d/M/yyyy")
            };

            // -- Persistir: primero lista, luego disco --
            datos.Add(nuevo);
            Utilitario.GuardarArchivoTXT(ruta, datos);

            CargarLista();
            LimpiarCampos();
            pnlNueva.Visible = false;
        }

        /// <summary>
        /// Restablece todos los campos del panel a su estado inicial.
        /// </summary>
        private void LimpiarCampos()
        {
            txtCliente.Clear();
            txtProveedor.Clear();
            txtMonto.Clear();
            cmbEstado.SelectedIndex = 0;
        }
    }
}