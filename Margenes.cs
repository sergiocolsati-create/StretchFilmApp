using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace StretchFilmApp
{
    /// <summary>
    /// Formulario que muestra los márgenes de precio como tarjetas
    /// y permite registrar nuevos márgenes desde un panel inferior.
    /// </summary>
    public partial class Margenes : Form
    {
        string ruta = Path.Combine(Application.StartupPath, "Data2", "margenes.txt");

        public Margenes()
        {
            InitializeComponent();

            pnlNueva.Visible = false;
            btnNuevoMargen.Click += (s, e) => pnlNueva.Visible = !pnlNueva.Visible;
            btnLimpiar.Click += (s, e) => LimpiarCampos();
            btnGuardar.Click += (s, e) => GuardarMargen();

            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.SelectedIndex = 0;
        }

        private void Margenes_Load(object sender, EventArgs e)
        {
            AsegurarArchivoEjemplo();
            CargarMargenesDesdeTXT();
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
                string.Join(s, "Stretch Film 20µm x 500m",    "Plastificados del Norte S.A.C.",  "18%", "32%", "25%", "Activo",   "1/5/2026", "31/12/2026"),
                string.Join(s, "Stretch Film 25µm x 500m",    "Distribuidora Lima Norte S.A.C.", "15%", "28%", "21%", "Activo",   "1/5/2026", "31/10/2026"),
                string.Join(s, "Stretch Film Industrial 23µm", "PolyPack Industrial E.I.R.L.",    "20%", "35%", "27%", "Inactivo", "1/1/2026", "30/4/2026"),
            };
            File.WriteAllLines(ruta, demo, Encoding.UTF8);
        }

        /// <summary>
        /// Lee el TXT y crea una tarjeta por cada línea válida.
        /// </summary>
        private void CargarMargenesDesdeTXT()
        {
            flpMargenes.Controls.Clear();

            if (!File.Exists(ruta)) return;

            foreach (string linea in File.ReadAllLines(ruta, Encoding.UTF8))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                string[] c = linea.Split(Utilitario.SEPARADOR);
                if (c.Length < 8) continue;

                var tarjeta = new TARJETA_MARGEN();
                tarjeta.AsignarDatos(c[0], c[1], c[2], c[3], c[4], c[5], c[6], c[7]);
                flpMargenes.Controls.Add(tarjeta);
            }
        }

        /// <summary>
        /// Valida, construye el registro, lo guarda en el TXT
        /// y agrega la tarjeta al FlowLayoutPanel sin recargar todo.
        /// </summary>
        private void GuardarMargen()
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show("Ingresa el nombre del producto.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducto.Focus(); return;
            }
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Ingresa el nombre del cliente.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus(); return;
            }
            if (numMinimo.Value >= numMaximo.Value)
            {
                MessageBox.Show("El mínimo debe ser menor que el máximo.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string minimo = $"{numMinimo.Value}%";
            string maximo = $"{numMaximo.Value}%";
            string promedio = $"{numPromedio.Value}%";
            string estado = cmbEstado.SelectedItem.ToString();
            string inicio = dtpInicio.Value.ToString("d/M/yyyy");
            string fin = dtpFin.Value.ToString("d/M/yyyy");

            // Guardar en TXT
            string linea = string.Join(Utilitario.SEPARADOR.ToString(),
                txtProducto.Text.Trim(),
                txtCliente.Text.Trim(),
                minimo, maximo, promedio,
                estado, inicio, fin);

            File.AppendAllText(ruta, linea + Environment.NewLine, Encoding.UTF8);

            // Agregar tarjeta directamente sin recargar todo
            var tarjeta = new TARJETA_MARGEN();
            tarjeta.AsignarDatos(
                txtProducto.Text.Trim(), txtCliente.Text.Trim(),
                minimo, maximo, promedio, estado, inicio, fin);
            flpMargenes.Controls.Add(tarjeta);

            LimpiarCampos();
            pnlNueva.Visible = false;
        }

        /// <summary>
        /// Restablece todos los campos del panel a su estado inicial.
        /// </summary>
        private void LimpiarCampos()
        {
            txtProducto.Clear();
            txtCliente.Clear();
            numMinimo.Value = 0;
            numMaximo.Value = 0;
            numPromedio.Value = 0;
            cmbEstado.SelectedIndex = 0;
            dtpInicio.Value = DateTime.Today;
            dtpFin.Value = DateTime.Today;
        }
    }
}