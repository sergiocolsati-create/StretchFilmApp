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
    public partial class NuevoMargen : Form
    {
        // Propiedad que devuelve el margen en formato de array (8 campos)
        public string[] DatosMargen { get; private set; }
        public NuevoMargen()
        {
            InitializeComponent();

            // Fecha de inicio por defecto
            dtpVigenciaInicio.Value = DateTime.Today;
        }

        private void NuevoMargen_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Valida campos obligatorios
            if (txtProducto.Text == "" || txtCliente.Text == "")
            {
                MessageBox.Show("Complete Producto y Cliente.");
                return;
            }

            // Valida que mínimo y máximo sean números
            double minimo, maximo;

            if (!double.TryParse(txtMinimo.Text, out minimo))
            {
                MessageBox.Show("Ingrese un valor válido para Mínimo.");
                return;
            }
            if (!double.TryParse(txtMaximo.Text, out maximo))
            {
                MessageBox.Show("Ingrese un valor válido para Máximo.");
                return;
            }

            // Valida que mínimo no sea mayor que máximo
            if (minimo > maximo)
            {
                MessageBox.Show("El Mínimo no puede ser mayor que el Máximo.");
                return;
            }

            // Calcula promedio al guardar
            double promedio = (minimo + maximo) / 2;
            string promedioTexto = promedio.ToString("0.0");        // Guarda solo con un decimal

            // Obtiene fecha fin
            string vigenciaFin;
            if (chkSinFechaFin.Checked)
            {
                vigenciaFin = "activo";
            }
            else
            {
                vigenciaFin = dtpVigenciaFin.Value.ToString("dd/MM/yyyy");
            }

            // Crea array de 7 campos
            DatosMargen = new string[]
            {
                txtProducto.Text,                                    // [0] Producto
                txtCliente.Text,                                     // [1] Cliente
                txtMinimo.Text,                                      // [2] Mínimo
                txtMaximo.Text,                                      // [3] Máximo
                promedioTexto,                                       // [4] Promedio
                dtpVigenciaInicio.Value.ToString("dd/MM/yyyy"),      // [5] Vigencia Inicio
                vigenciaFin                                          // [6] Vigencia Fin
            };

            this.DialogResult = DialogResult.OK;   // Indica que el usuario guardó los datos
            this.Close();                          // Cierra el formulario
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;   // Indica que el usuario canceló
            this.Close();
        }

        private void chkSinFechaFin_CheckedChanged(object sender, EventArgs e)
        {
            dtpVigenciaFin.Enabled = !chkSinFechaFin.Checked;   // Si está marcado, deshabilita la fecha fin
        }
    }
}
