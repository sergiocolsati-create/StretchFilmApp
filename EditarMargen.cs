using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StretchFilmApp
{
    public partial class EditarMargen : Form
    {
        public string[] DatosMargen { get; private set; }
        public EditarMargen(string producto, string cliente, string minimo, string maximo, string vigenciaInicio, string vigenciaFin)
        {
            InitializeComponent();

            // Carga los datos en los controles
            txtProducto.Text = producto;
            txtCliente.Text = cliente;
            txtMinimo.Text = minimo;
            txtMaximo.Text = maximo;

            // Carga fecha de inicio
            DateTime fechaInicio;
            if (DateTime.TryParseExact(vigenciaInicio, "d/M/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaInicio))
            {
                dtpVigenciaInicio.Value = fechaInicio;
            }

            // Cargar fecha fin
            if (vigenciaFin == "activo")
            {
                chkSinFechaFin.Checked = true;
                dtpVigenciaFin.Enabled = false;
            }
            else
            {
                chkSinFechaFin.Checked = false;
                DateTime fechaFin;
                if (DateTime.TryParseExact(vigenciaFin, "d/M/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaFin))
                {
                    dtpVigenciaFin.Value = fechaFin;
                }
            }
        }

        private void EditarMargen_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Valida campos
        if (string.IsNullOrWhiteSpace(txtProducto.Text) || string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Complete Producto y Cliente.");
                return;
            }

            // Valida números
            if (!double.TryParse(txtMinimo.Text, out double minimo))
            {
                MessageBox.Show("Ingrese un valor válido para Mínimo (número).");
                return;
            }
            if (!double.TryParse(txtMaximo.Text, out double maximo))
            {
                MessageBox.Show("Ingrese un valor válido para Máximo (número).");
                return;
            }

            if (minimo > maximo)
            {
                MessageBox.Show("El Mínimo no puede ser mayor que el Máximo.");
                return;
            }

           
            // Calcula el nuevo promedio
            double promedio = (minimo + maximo) / 2;

            // Fecha fin
            string vigenciaFin;
            if (chkSinFechaFin.Checked)
                vigenciaFin = "activo";
            else
                vigenciaFin = dtpVigenciaFin.Value.ToString("d/M/yyyy");

            // Crear array de 7 campos
            DatosMargen = new string[]
            {
            txtProducto.Text,
            txtCliente.Text,
            txtMinimo.Text,
            txtMaximo.Text,
            promedio.ToString("0.0"),
            dtpVigenciaInicio.Value.ToString("d/M/yyyy"),
            vigenciaFin
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chkSinFechaFin_CheckedChanged(object sender, EventArgs e)
        {
            dtpVigenciaFin.Enabled = !chkSinFechaFin.Checked;
        }
    }
}
