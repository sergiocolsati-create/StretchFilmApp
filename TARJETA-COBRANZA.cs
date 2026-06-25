using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StretchFilmApp
{
    public partial class TARJETA_COBRANZA : UserControl
    {
        // Campos privados para almacenar datos de la factura
        private string _cliente;           // Nombre del cliente
        private string _ruc;               // RUC del cliente
        private string _serie;             // Número de serie/factura
        private double _total;             // Monto total de la factura
        private double _saldo;             // Saldo pendiente de pago
        private string _fechaVencimiento;  // Fecha de vencimiento

        // El evento se dispara cuando se registra un pago
        // Envía el nuevo saldo para que el formulario Cobranza actualice el archivo
        public event EventHandler<double> PagoRegistrado;

        public TARJETA_COBRANZA()
        {
            InitializeComponent();
        }

        private void TARJETA_COBRANZA_Load(object sender, EventArgs e)
        {

        }
        // Se llama al método desde Cobranza cuando se crea cada tarjeta
        public void AsignarDatos(string cliente, string ruc, string serie, string totalStr, string saldoStr, string fechaVencimiento)
        {
            // Guarda los datos en los campos privados
            _cliente = cliente;
            _ruc = ruc;
            _serie = serie;
            _total = Convert.ToDouble(totalStr);    // Convierte de texto a número
            _saldo = Convert.ToDouble(saldoStr);    // Convierte de texto a número
            _fechaVencimiento = fechaVencimiento;

            // Muestra los datos en los labels de la tarjeta
            lblCliente.Text = _cliente;
            lblRuc.Text = _ruc;
            lblSerie.Text = _serie;
            lblTotal.Text = $"S/. {_total:N2}";
            lblSaldo.Text = $"S/. {_saldo:N2}";
            lblVence.Text = _fechaVencimiento;

            // Actualiza el estado visual, el color y texto de estado
            ActualizarEstado();
        }

        // Cambia el texto y color según el saldo, total y la fecha de vencimiento
        private void ActualizarEstado()
        {
            string estadoTexto;     // Texto que se mostrará (PAGADA, PARCIAL, EMITIDA)
            Color colorEstado;      // Color del panel de estado

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
            else 
            {
                //Debe todo el total
                estadoTexto = "EMITIDA";
                colorEstado = Color.LightGoldenrodYellow;
            }

            // Solo si tiene saldo pendiente y la fecha de vencimiento ya pasó
            // Explicación de Parámetros de DateTime.TryParseExact()
            // _fechaVencimiento	   =>   El texto a convertir (ej: "31/5/2026")
            // "d/M/yyyy"              =>   El formato esperado (día/mes/año)
            // null                    =>   Sin información de cultura, usa la del sistema
            // DateTimeStyles.None     =>   Sin opciones especiales
            // out DateTime fechaVenc  =>   Aquí se guarda el resultado
            if (_saldo > 0 && DateTime.TryParseExact(_fechaVencimiento, "d/M/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaVenc))
            {
                if (fechaVenc.Date < DateTime.Now.Date)
                {
                    estadoTexto = "VENCIDA";
                    colorEstado = Color.LightCoral;
                }
            }

            // Aplica el texto y color al label y panel de estado
            lblEstado.Text = estadoTexto;
            pnlEstado.BackColor = colorEstado;
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            RegistrarPago dialogo = new RegistrarPago(_cliente, _serie, _saldo);
            dialogo.ShowDialog();

            if (dialogo.MontoPagado > 0)  // Si se pagó algo
            {
                _saldo -= dialogo.MontoPagado;
                lblSaldo.Text = $"S/. {_saldo:N2}";
                ActualizarEstado();

                if (PagoRegistrado != null)
                {
                    // this     =>  se refiere a esta tarjeta
                    // _saldo   =>  es la información que se envía
                    PagoRegistrado(this, _saldo);
                }
            }
            
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            HistorialPagos historial = new HistorialPagos(_serie);
            if (historial.ShowDialog() == DialogResult.OK)
            {
                // Recarga desde el archivo
                ActualizarSaldoDesdeArchivo();

                // Notifica a Cobranza
                if (PagoRegistrado != null)
                {
                    PagoRegistrado(this, _saldo);
                }
            }
        }
        private void ActualizarSaldoDesdeArchivo()
        {
            string ruta = Path.Combine(Application.StartupPath, "Data2", "facturacion.txt");
            List<string[]> listaFacturas = new List<string[]>();
            Utilitario.CargarArchivoTXT(ruta, listaFacturas);

            foreach (string[] factura in listaFacturas)
            {
                if (factura[0] == _serie)
                {
                    _saldo = double.Parse(factura[6]);
                    lblSaldo.Text = $"S/. {_saldo:N2}";
                    ActualizarEstado();
                    break;
                }
            }
        }

        private void pnlTarjetaPlantilla_Paint(object sender, PaintEventArgs e)
        {

        }
        public string ObtenerSerie()
        {
            return _serie;
        }
    }
}
