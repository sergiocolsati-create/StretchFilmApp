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
    public partial class TARJETA_MARGEN : UserControl
    {
        public TARJETA_MARGEN()
        {
            InitializeComponent();
        }

        private void TARJETA_MARGEN_Load(object sender, EventArgs e)
        {

        }
        public void AsignarDatos(string producto, string cliente, string minimo, string maximo, string promedio, string activo, string vigenciaInicio, string vigenciaFin)
        {
            lblProducto.Text = producto;
            lblCliente.Text = cliente;
            lblMinimo.Text = minimo;
            lblMaximo.Text = maximo;
            lblPromedio.Text = promedio;
            // 'activo' (el parámetro) es el margen activo, ej "40% máx", no lo usamos para el estado.
            // En lugar de eso, calculamos estado basado en vigenciaFin.

            bool esActivo = false;
            if (vigenciaFin.Equals("activo", StringComparison.OrdinalIgnoreCase))
                esActivo = true;
            else
            {
                // Intentar parsear la fecha fin (formato dd/MM/yyyy)
                if (DateTime.TryParseExact(vigenciaFin, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaFin))
                {
                    // Si la fecha fin es mayor o igual a hoy, está activo; si ya pasó, inactivo.
                    esActivo = fechaFin.Date >= DateTime.Now.Date;
                }
                else
                {
                    // Si no se pudo parsear, asumimos inactivo o manejas error
                    esActivo = false;
                }
            }

            // Asignar texto y color del panel
            if (esActivo)
            {
                lblEstado.Text = "ACTIVO";
                pnlEstado.BackColor = Color.LightGreen;   // Verde claro
            }
            else
            {
                lblEstado.Text = "INACTIVO";
                pnlEstado.BackColor = Color.LightGray;    // Gris
            }

            // Mostrar rango de vigencia
            lblVigencia.Text = $"{vigenciaInicio} → {vigenciaFin}";
        }
    }
}
