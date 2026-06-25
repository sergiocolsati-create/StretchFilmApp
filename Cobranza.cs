using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StretchFilmApp
{
    public partial class Cobranza : Form
    {
        // Lista que guarda todas las facturas leídas del archivo
        List<string[]> facturas = new List<string[]>();

        // Ruta del archivo facturacion.txt
        string ruta = Path.Combine(Application.StartupPath, "Data2", "facturacion.txt");

        public Cobranza()
        {
            InitializeComponent();
        }
        private void Cobranza_Load(object sender, EventArgs e)
        {
            // Carga los datos del archivo a la lista "facturas"
            Utilitario.CargarArchivoTXT(ruta, facturas);
            if (facturas.Count == 0) return;

            // Crea las tarjetas y muestra los resúmenes
            RefrescarInterfaz();
        }

        private void RefrescarInterfaz()
        {
            // Limpia todas las tarjetas actuales
            flpCobranza.Controls.Clear();

            // Variables para los resúmenes
            int enCobranza = 0, vencidas = 0;
            double totalPorCobrar = 0;

            // Recorre todas las factura en la lista
            foreach (string[] campos in facturas)
            {
                if (campos.Length < 9) continue;

                string cliente = campos[1];
                string ruc = campos[2];
                string serie = campos[0];
                double total = double.Parse(campos[5]);
                double saldo = double.Parse(campos[6]);
                string vence = campos[8];

                if (saldo > 0)
                {
                    totalPorCobrar += saldo;

                    // Verifica si está vencida
                    // Parámetros de DateTime.TryParseExact()
                    // vence            	   =>   Fecha de Vencimiento
                    // "d/M/yyyy"              =>   El formato esperado (día/mes/año)
                    // DateTimeStyles.None     =>   Sin opciones especiales
                    // out DateTime fechaVenc  =>   Aquí se guarda el resultado
                    if (DateTime.TryParseExact(vence, "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaVenc))
                    {
                        if (fechaVenc.Date < DateTime.Now.Date)
                            vencidas++;
                        else
                            enCobranza++;
                    }
                    else
                        enCobranza++;
                }

                // Se crea la tarjeta
                TARJETA_COBRANZA tarjeta = new TARJETA_COBRANZA();

                // Asigna los datos a la tarjeta
                tarjeta.AsignarDatos(cliente, ruc, serie, total.ToString(), saldo.ToString(), vence);

                // Cuando la tarjeta registre un pago, actualiza el archivo
                tarjeta.PagoRegistrado += ActualizarSaldoFactura;

                flpCobranza.Controls.Add(tarjeta);
            }

            // Actualiza resúmenes
            lblEnCobranza.Text = enCobranza.ToString();
            lblVencidas.Text = vencidas.ToString();
            lblTotalCobrar.Text = $"S/. {totalPorCobrar:N2}";
        }

        private void ActualizarSaldoFactura(object sender, double nuevoSaldo)
        {
            TARJETA_COBRANZA tarjeta = (TARJETA_COBRANZA)sender;
            string serie = tarjeta.ObtenerSerie();

            // Recorre todas las facturas de la lista "facturas"
            foreach (string[] fact in facturas)
                // Si la serie coincide con la que se está buscando
                if (fact[0] == serie)
                {
                    // Actualiza el saldo
                    // ToString("0.00") = Convierte el número a texto con 2 decimales
                    fact[6] = nuevoSaldo.ToString("0.00");
                    break;
                }
            // Guarda la lista completa en el archivo
            Utilitario.GuardarArchivoTXT(ruta, facturas);

            // La tarjeta afectada muestra el nuevo saldo y estado
            RefrescarInterfaz();
        }
        private void lblFacturasCobranza_Click(object sender, EventArgs e)
        {

        }
    }
}
