using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StretchFilmApp
{
    public partial class Cobranza : Form
    {
        public Cobranza()
        {
            InitializeComponent();
        }

        private void Cobranza_Load(object sender, EventArgs e)
        {
            CargarFacturasDesdeTXT();
        }
        private void CargarFacturasDesdeTXT()
        {
            string ruta = Path.Combine(Application.StartupPath, "Data2", "cobranza.txt");
            if (!File.Exists(ruta))
            {
                MessageBox.Show("No se encuentra: " + ruta);
                return;
            }

            flpCobranza.Controls.Clear();


            int enCobranza = 0, vencidas = 0;
            decimal totalPorCobrar = 0;

            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                string[] campos = linea.Split(';');
                if (campos.Length < 6) continue;

                string cliente = campos[0];
                string ruc = campos[1];
                string serie = campos[2];
                string totalStr = campos[3];
                string saldoStr = campos[4];
                string vence = campos[5];

                decimal saldo = Convert.ToDecimal(saldoStr);
                if (saldo > 0)
                {
                    totalPorCobrar += saldo;
                    // Calcular si está vencida para el contador
                    if (DateTime.TryParseExact(vence, "d/M/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaVenc))
                    {
                        if (fechaVenc.Date < DateTime.Now.Date)
                            vencidas++;
                        else
                            enCobranza++;
                    }
                    else
                        enCobranza++;
                }

                TARJETA_COBRANZA tarjeta = new TARJETA_COBRANZA();
                tarjeta.AsignarDatos(cliente, ruc, serie, totalStr, saldoStr, vence);
                flpCobranza.Controls.Add(tarjeta);
            }

            // Actualizar resúmenes
            if (lblEnCobranza != null) lblEnCobranza.Text = enCobranza.ToString();
            if (lblVencidas != null) lblVencidas.Text = vencidas.ToString();
            if (lblTotalCobrar != null) lblTotalCobrar.Text = $"S/. {totalPorCobrar:N2}";
        }
        private void lblFacturasCobranza_Click(object sender, EventArgs e)
        {

        }
    }
}
