using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StretchFilmApp
{
    public partial class TARJETA_MARGEN : UserControl
    {
        // Campos privados para guardar los datos
        private string _producto;
        private string _cliente;
        private string _minimo;
        private string _maximo;
        private string _promedio;
        private string _vigenciaInicio;
        private string _vigenciaFin;

        // Evento para notificar a Margenes que se editó un margen
        public event EventHandler<string[]> MargenEditado;
        public TARJETA_MARGEN()
        {
            InitializeComponent();
        }

        private void TARJETA_MARGEN_Load(object sender, EventArgs e)
        {

        }
        public void AsignarDatos(string producto, string cliente, string minimo, string maximo, string promedio, string vigenciaInicio, string vigenciaFin)
        {
            // Guarda en campos privados
            _producto = producto;
            _cliente = cliente;
            _minimo = minimo;
            _maximo = maximo;
            _promedio = promedio;
            _vigenciaInicio = vigenciaInicio;
            _vigenciaFin = vigenciaFin;

            // Muestra datos
            lblProducto.Text = producto;
            lblCliente.Text = cliente;
            lblMinimo.Text = minimo;
            lblMaximo.Text = maximo;
            lblPromedio.Text = promedio;

            // Calcula ESTADO según vigenciaFin
            bool esActivo = false;

            if (vigenciaFin == "activo")
            {
                esActivo = true;
            }
            else
            {
                DateTime fechaFin;
                if (DateTime.TryParseExact(vigenciaFin, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaFin))
                {
                    DateTime hoy = DateTime.Today;
                    if (fechaFin >= hoy)
                    {
                        esActivo = true;
                    }
                    else
                    {
                        esActivo = false;
                    }
                }
            }

            // Muestra estado y da color
            if (esActivo)
            {
                lblEstado.Text = "ACTIVO";
                pnlEstado.BackColor = Color.LightGreen;
            }
            else
            {
                lblEstado.Text = "INACTIVO";
                pnlEstado.BackColor = Color.LightGray;
            }

            // Muestra rango de vigencia
            lblVigencia.Text = $"{vigenciaInicio} → {vigenciaFin}";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditarMargen_Click(object sender, EventArgs e)
        {
            // Abre el formulario para editar con los datos actuales
            EditarMargen editar = new EditarMargen(_producto, _cliente, _minimo, _maximo, _vigenciaInicio, _vigenciaFin);

            if (editar.ShowDialog() == DialogResult.OK)
            {
                string[] nuevosDatos = editar.DatosMargen;

                // Actualiza la tarjeta con los nuevos datos
                AsignarDatos(nuevosDatos[0], nuevosDatos[1], nuevosDatos[2], nuevosDatos[3],
                            nuevosDatos[4], nuevosDatos[5], nuevosDatos[6]);

                // Notifica a Margenes para guardar en el archivo
                if (MargenEditado != null)
                {
                    MargenEditado(this, nuevosDatos);
                }
            }
        }
    }
}
