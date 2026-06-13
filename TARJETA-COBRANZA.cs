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
    public partial class TARJETA_COBRANZA : UserControl
    {
        // Campos privados para almacenar datos de la factura
        private string _cliente;
        private string _ruc;
        private string _serie;
        private decimal _total;
        private decimal _saldo;
        private string _fechaVencimiento;

        public event EventHandler<decimal> PagoRegistrado; // Notifica nuevo saldo

        public TARJETA_COBRANZA()
        {
            InitializeComponent();
        }

        private void TARJETA_COBRANZA_Load(object sender, EventArgs e)
        {

        }
        public void AsignarDatos(string cliente, string ruc, string serie, string totalStr, string saldoStr, string fechaVencimiento)
        {
            _cliente = cliente;
            _ruc = ruc;
            _serie = serie;
            _total = Convert.ToDecimal(totalStr);
            _saldo = Convert.ToDecimal(saldoStr);
            _fechaVencimiento = fechaVencimiento;

            lblCliente.Text = _cliente;
            lblRuc.Text = _ruc;
            lblSerie.Text = _serie;
            lblTotal.Text = $"S/. {_total:N2}";
            lblSaldo.Text = $"S/. {_saldo:N2}";
            lblVence.Text = _fechaVencimiento;

            ActualizarEstado();
        }
        private void ActualizarEstado()
        {
            string estadoTexto;
            Color colorEstado;

            if (_saldo == 0)
            {
                estadoTexto = "PAGADA";
                colorEstado = Color.LightGreen;
            }
            else if (_saldo < _total)
            {
                estadoTexto = "PARCIAL";
                colorEstado = Color.LightBlue;
            }
            else // saldo = total
            {
                estadoTexto = "EMITIDA";
                colorEstado = Color.LightGoldenrodYellow;
            }

            // Verificar vencimiento
            if (_saldo > 0 && DateTime.TryParseExact(_fechaVencimiento, "d/M/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaVenc))
            {
                if (fechaVenc.Date < DateTime.Now.Date)
                {
                    estadoTexto = "VENCIDA";
                    colorEstado = Color.LightCoral;
                }
            }

            lblEstado.Text = estadoTexto;
            pnlEstado.BackColor = colorEstado;
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            using (var dialogo = new RegistrarPago(_cliente, _serie, _saldo))
            {
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    _saldo -= dialogo.MontoPagado;
                    if (_saldo < 0) _saldo = 0;
                    lblSaldo.Text = $"S/. {_saldo:N2}";
                    ActualizarEstado();
                    // Notificar al formulario Cobranza para que actualice el archivo y los resúmenes
                    PagoRegistrado?.Invoke(this, _saldo);
                }
            }
        }
    }
}
