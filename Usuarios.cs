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
    /// Formulario para gestionar usuarios del sistema: vendedoras y administradores.
    /// Permite registrar, activar/desactivar, eliminar y persistir en TXT,
    /// con la contraseña oculta por defecto (toggle de visibilidad por fila).
    /// </summary>
    public partial class Usuarios : Form
    {
        /// <summary>Lista en memoria de vendedoras cargadas desde el archivo.</summary>
        private readonly List<string[]> datosVendedoras = new List<string[]>();

        /// <summary>Lista en memoria de administradores cargados desde el archivo.</summary>
        private readonly List<string[]> datosAdmins = new List<string[]>();

        /// <summary>Ruta absoluta al archivo TXT de vendedoras.</summary>
        private readonly string rutaVendedoras = Path.Combine(Application.StartupPath, "Data2", "vendedoras.txt");

        /// <summary>Ruta absoluta al archivo TXT de administradores.</summary>
        private readonly string rutaAdmins = Path.Combine(Application.StartupPath, "Data2", "administradores.txt");

        /// <summary>
        /// Constructor: inicializa controles, carga datos y vincula eventos.
        /// </summary>
        public Usuarios()
        {
            InitializeComponent();

            CargarCombos();
            AsegurarArchivosEjemplo();
            CargarTodo();

            pnlNueva.Visible = false;
            pnlNueva.AgregarBotonCerrar(LimpiarCampos);

            btnNuevaVendedora.Click += (s, e) =>
            {
                cmbTipoUsuario.SelectedIndex = 0; // Vendedora por defecto
                pnlNueva.Visible = !pnlNueva.Visible;
            };
            btnNuevoAdmin.Click += (s, e) =>
            {
                cmbTipoUsuario.SelectedIndex = 1; // Admin por defecto
                pnlNueva.Visible = !pnlNueva.Visible;
            };
            btnRefrescar.Click += (s, e) => CargarTodo();
            btnLimpiar.Click += (s, e) => LimpiarCampos();
            btnGuardar.Click += (s, e) => GuardarUsuario();
        }

        // ─── Inicialización ──────────────────────────────────────────────────────

        /// <summary>
        /// Llena los ComboBox de Tipo de usuario y Estado con sus opciones fijas.
        /// </summary>
        private void CargarCombos()
        {
            cmbTipoUsuario.Items.AddRange(new object[] { "Vendedora", "Administrador" });
            cmbTipoUsuario.SelectedIndex = 0;

            cmbEstadoNuevo.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstadoNuevo.SelectedIndex = 0;
        }

        /// <summary>
        /// Crea los archivos TXT con filas de ejemplo si todavía no existen.
        /// Vendedoras: nombre, email, estado, solicitudes, ultimoAcceso, contrasena
        /// Administradores: nombre, email, estado, contrasena
        /// </summary>
        private void AsegurarArchivosEjemplo()
        {
            string s = Utilitario.SEPARADOR.ToString();

            if (!File.Exists(rutaVendedoras))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(rutaVendedoras));
                string[] demoVend =
                {
                    string.Join(s, "Ana García",   "ana.garcia@stretchfilm.pe",   "Activo",   "6", "16/5/2026 11:22 p. m.", "stretch2024"),
                    string.Join(s, "Lucía Torres", "lucia.torres@stretchfilm.pe", "Inactivo", "5", "",                      "lucia2024"),
                    string.Join(s, "Sofía Quispe", "sofia.quispe@stretchfilm.pe", "Activo",   "4", "",                      "sofia2024"),
                };
                File.WriteAllLines(rutaVendedoras, demoVend, Encoding.UTF8);
            }

            if (!File.Exists(rutaAdmins))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(rutaAdmins));
                string[] demoAdmin =
                {
                    string.Join(s, "json", "json@correo.com", "Activo", "admin2024"),
                };
                File.WriteAllLines(rutaAdmins, demoAdmin, Encoding.UTF8);
            }
        }

        // ─── Carga y construcción de filas ─────────────────────────────────────────

        /// <summary>
        /// Recarga ambas listas desde disco y reconstruye las dos secciones visuales.
        /// </summary>
        private void CargarTodo()
        {
            datosVendedoras.Clear();
            if (File.Exists(rutaVendedoras))
            {
                foreach (string linea in File.ReadAllLines(rutaVendedoras, Encoding.UTF8))
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;
                    datosVendedoras.Add(linea.Split(Utilitario.SEPARADOR));
                }
            }

            datosAdmins.Clear();
            if (File.Exists(rutaAdmins))
            {
                foreach (string linea in File.ReadAllLines(rutaAdmins, Encoding.UTF8))
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;
                    datosAdmins.Add(linea.Split(Utilitario.SEPARADOR));
                }
            }

            ConstruirFilasVendedoras();
            ConstruirFilasAdmins();
            ActualizarSubtitulo();
        }

        /// <summary>
        /// Construye dinámicamente cada fila de la sección Vendedoras dentro de pnlVendedoras.
        /// </summary>
        private void ConstruirFilasVendedoras()
        {
            pnlVendedoras.Controls.Clear();
            int y = 0;
            foreach (string[] v in datosVendedoras)
            {
                if (v.Length < 6) continue;
                Panel fila = CrearFilaVendedora(v[0], v[1], v[2], v[3], v[4], v[5]);
                fila.Location = new Point(0, y);
                pnlVendedoras.Controls.Add(fila);
                y += fila.Height;
            }
            pnlVendedoras.Height = Math.Max(y, 1);
        }

        /// <summary>
        /// Construye dinámicamente cada fila de la sección Administradores dentro de pnlAdmins.
        /// </summary>
        private void ConstruirFilasAdmins()
        {
            pnlAdmins.Controls.Clear();
            int y = 0;
            foreach (string[] a in datosAdmins)
            {
                if (a.Length < 4) continue;
                Panel fila = CrearFilaAdmin(a[0], a[1], a[2], a[3]);
                fila.Location = new Point(0, y);
                pnlAdmins.Controls.Add(fila);
                y += fila.Height;
            }
            pnlAdmins.Height = Math.Max(y, 1);
        }

        /// <summary>
        /// Crea la fila visual de una vendedora: nombre, email, estado, solicitudes,
        /// último acceso, contraseña oculta con toggle, y botones de acción.
        /// </summary>
        private Panel CrearFilaVendedora(string nombre, string email, string estado,
                                          string solicitudes, string ultimoAcceso, string contrasena)
        {
            var fila = new Panel
            {
                Width = pnlVendedoras.ClientSize.Width,
                Height = 44,
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            var lblNombre = new Label { Text = nombre, Font = new Font("Segoe UI", 9F, FontStyle.Bold), ForeColor = Color.FromArgb(31, 41, 55), Location = new Point(8, 14), AutoSize = true };
            fila.Controls.Add(lblNombre);

            var lblEmail = new Label { Text = email, Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(107, 114, 128), Location = new Point(180, 14), AutoSize = true };
            fila.Controls.Add(lblEmail);

            var lblEstado = new Label
            {
                Text = estado,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = estado == "Activo" ? Theme.Verde : Theme.TextoTenue,
                BackColor = estado == "Activo" ? Color.FromArgb(220, 252, 231) : Color.FromArgb(243, 244, 246),
                Location = new Point(440, 11),
                AutoSize = true,
                Padding = new Padding(8, 3, 8, 3)
            };
            fila.Controls.Add(lblEstado);

            var lblSolicitudes = new Label { Text = solicitudes, Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(31, 41, 55), Location = new Point(580, 14), AutoSize = true };
            fila.Controls.Add(lblSolicitudes);

            var lblUltimoAcceso = new Label { Text = string.IsNullOrWhiteSpace(ultimoAcceso) ? "—" : ultimoAcceso, Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(107, 114, 128), Location = new Point(660, 14), AutoSize = true };
            fila.Controls.Add(lblUltimoAcceso);

            var lblContrasena = new Label
            {
                Text = new string('•', Math.Max(contrasena.Length, 8)),
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(840, 14),
                AutoSize = true
            };
            fila.Controls.Add(lblContrasena);

            var btnOjo = new Button
            {
                Text = "👁",
                Size = new Size(24, 22),
                Location = new Point(950, 11),
                FlatStyle = FlatStyle.Flat
            };
            btnOjo.FlatAppearance.BorderSize = 0;
            bool visible = false;
            btnOjo.Click += (s, e) =>
            {
                visible = !visible;
                lblContrasena.Text = visible ? contrasena : new string('•', Math.Max(contrasena.Length, 8));
            };
            fila.Controls.Add(btnOjo);

            var btnEditar = new Button { Text = "✏", Size = new Size(28, 24), Location = new Point(990, 10), FlatStyle = FlatStyle.Flat };
            btnEditar.FlatAppearance.BorderSize = 0;
            fila.Controls.Add(btnEditar);

            bool activa = estado == "Activo";
            var btnToggle = new Button
            {
                Text = activa ? "🚫 Desactivar" : "👤 Activar",
                Size = new Size(95, 24),
                Location = new Point(1025, 10),
                FlatStyle = FlatStyle.Flat,
                BackColor = activa ? Color.FromArgb(254, 226, 226) : Color.FromArgb(220, 252, 231),
                ForeColor = activa ? Color.FromArgb(220, 38, 38) : Color.FromArgb(22, 163, 74),
                Font = new Font("Segoe UI", 8F)
            };
            btnToggle.FlatAppearance.BorderSize = 0;
            btnToggle.Click += (s, e) => CambiarEstadoVendedora(nombre, activa ? "Inactivo" : "Activo");
            fila.Controls.Add(btnToggle);

            var btnEliminar = new Button { Text = "🗑", Size = new Size(28, 24), Location = new Point(1125, 10), FlatStyle = FlatStyle.Flat, ForeColor = Color.FromArgb(220, 38, 38) };
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.Click += (s, e) => EliminarVendedora(nombre);
            fila.Controls.Add(btnEliminar);

            return fila;
        }

        /// <summary>
        /// Crea la fila visual de un administrador: nombre, email, estado,
        /// contraseña oculta con toggle, y botones de acción.
        /// </summary>
        private Panel CrearFilaAdmin(string nombre, string email, string estado, string contrasena)
        {
            var fila = new Panel
            {
                Width = pnlAdmins.ClientSize.Width,
                Height = 44,
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            var lblNombre = new Label { Text = nombre, Font = new Font("Segoe UI", 9F, FontStyle.Bold), ForeColor = Color.FromArgb(31, 41, 55), Location = new Point(8, 14), AutoSize = true };
            fila.Controls.Add(lblNombre);

            var lblEmail = new Label { Text = email, Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(107, 114, 128), Location = new Point(180, 14), AutoSize = true };
            fila.Controls.Add(lblEmail);

            var lblEstado = new Label
            {
                Text = estado.ToUpper(),
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = estado == "Activo" ? Theme.Verde : Theme.TextoTenue,
                BackColor = estado == "Activo" ? Color.FromArgb(220, 252, 231) : Color.FromArgb(243, 244, 246),
                Location = new Point(440, 11),
                AutoSize = true,
                Padding = new Padding(8, 3, 8, 3)
            };
            fila.Controls.Add(lblEstado);

            var lblContrasena = new Label
            {
                Text = new string('•', Math.Max(contrasena.Length, 8)),
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(610, 14),
                AutoSize = true
            };
            fila.Controls.Add(lblContrasena);

            var btnOjo = new Button { Text = "👁", Size = new Size(24, 22), Location = new Point(720, 11), FlatStyle = FlatStyle.Flat };
            btnOjo.FlatAppearance.BorderSize = 0;
            bool visible = false;
            btnOjo.Click += (s, e) =>
            {
                visible = !visible;
                lblContrasena.Text = visible ? contrasena : new string('•', Math.Max(contrasena.Length, 8));
            };
            fila.Controls.Add(btnOjo);

            var btnEditar = new Button { Text = "✏", Size = new Size(28, 24), Location = new Point(990, 10), FlatStyle = FlatStyle.Flat };
            btnEditar.FlatAppearance.BorderSize = 0;
            fila.Controls.Add(btnEditar);

            bool activo = estado == "Activo";
            var btnToggle = new Button
            {
                Text = activo ? "🚫 Desactivar" : "👤 Activar",
                Size = new Size(95, 24),
                Location = new Point(1025, 10),
                FlatStyle = FlatStyle.Flat,
                BackColor = activo ? Color.FromArgb(254, 226, 226) : Color.FromArgb(220, 252, 231),
                ForeColor = activo ? Color.FromArgb(220, 38, 38) : Color.FromArgb(22, 163, 74),
                Font = new Font("Segoe UI", 8F)
            };
            btnToggle.FlatAppearance.BorderSize = 0;
            btnToggle.Click += (s, e) => CambiarEstadoAdmin(nombre, activo ? "Inactivo" : "Activo");
            fila.Controls.Add(btnToggle);

            var btnEliminar = new Button { Text = "🗑", Size = new Size(28, 24), Location = new Point(1125, 10), FlatStyle = FlatStyle.Flat, ForeColor = Color.FromArgb(220, 38, 38) };
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.Click += (s, e) => EliminarAdmin(nombre);
            fila.Controls.Add(btnEliminar);

            return fila;
        }

        /// <summary>
        /// Actualiza el subtítulo con el conteo de vendedoras y administradores.
        /// </summary>
        private void ActualizarSubtitulo()
        {
            lblSubtitulo.Text = $"{datosVendedoras.Count} vendedora{(datosVendedoras.Count != 1 ? "s" : "")} · {datosAdmins.Count} admin{(datosAdmins.Count != 1 ? "s" : "")}";
        }

        // ─── Acciones sobre filas existentes ───────────────────────────────────────

        /// <summary>Cambia el estado de una vendedora (por nombre) y persiste el cambio.</summary>
        private void CambiarEstadoVendedora(string nombre, string nuevoEstado)
        {
            var fila = datosVendedoras.FirstOrDefault(v => v.Length > 0 && v[0] == nombre);
            if (fila != null && fila.Length >= 3) fila[2] = nuevoEstado;
            Utilitario.GuardarArchivoTXT(rutaVendedoras, datosVendedoras);
            CargarTodo();
        }

        /// <summary>Cambia el estado de un administrador (por nombre) y persiste el cambio.</summary>
        private void CambiarEstadoAdmin(string nombre, string nuevoEstado)
        {
            var fila = datosAdmins.FirstOrDefault(a => a.Length > 0 && a[0] == nombre);
            if (fila != null && fila.Length >= 3) fila[2] = nuevoEstado;
            Utilitario.GuardarArchivoTXT(rutaAdmins, datosAdmins);
            CargarTodo();
        }

        /// <summary>Elimina una vendedora (por nombre), con confirmación previa.</summary>
        private void EliminarVendedora(string nombre)
        {
            if (MessageBox.Show($"¿Eliminar a la vendedora {nombre}?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            datosVendedoras.RemoveAll(v => v.Length > 0 && v[0] == nombre);
            Utilitario.GuardarArchivoTXT(rutaVendedoras, datosVendedoras);
            CargarTodo();
        }

        /// <summary>Elimina un administrador (por nombre), con confirmación previa.</summary>
        private void EliminarAdmin(string nombre)
        {
            if (MessageBox.Show($"¿Eliminar al administrador {nombre}?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            datosAdmins.RemoveAll(a => a.Length > 0 && a[0] == nombre);
            Utilitario.GuardarArchivoTXT(rutaAdmins, datosAdmins);
            CargarTodo();
        }

        // ─── Panel "Nuevo usuario" ───────────────────────────────────────────────

        /// <summary>
        /// Valida, construye el registro, lo agrega a la lista correspondiente
        /// (vendedora o admin según el tipo elegido) y persiste en disco.
        /// </summary>
        private void GuardarUsuario()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingresa el nombre.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Ingresa el email.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Ingresa una contraseña.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Focus();
                return;
            }

            bool esAdmin = cmbTipoUsuario.SelectedItem.ToString() == "Administrador";

            if (esAdmin)
            {
                string[] nuevo = { txtNombre.Text.Trim(), txtEmail.Text.Trim(), cmbEstadoNuevo.SelectedItem.ToString(), txtContrasena.Text };
                datosAdmins.Add(nuevo);
                Utilitario.GuardarArchivoTXT(rutaAdmins, datosAdmins);
            }
            else
            {
                string[] nuevo = { txtNombre.Text.Trim(), txtEmail.Text.Trim(), cmbEstadoNuevo.SelectedItem.ToString(), "0", "", txtContrasena.Text };
                datosVendedoras.Add(nuevo);
                Utilitario.GuardarArchivoTXT(rutaVendedoras, datosVendedoras);
            }

            CargarTodo();
            LimpiarCampos();
            pnlNueva.Visible = false;
        }

        /// <summary>
        /// Restablece todos los campos del panel a su estado inicial.
        /// </summary>
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtEmail.Clear();
            txtContrasena.Clear();
            cmbEstadoNuevo.SelectedIndex = 0;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}