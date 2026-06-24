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
    public partial class RegistrarPago : Form
    {
        public decimal MontoPagado { get; private set; }  
        private string _serie;
        private string _cliente;
        private decimal _saldoActual;
        private string rutaCobranza;
        private string rutaPagos;
        public RegistrarPago(string cliente, string serie, decimal saldoActual)
        {
            InitializeComponent();

            btnAceptar.Click += btnAceptar_Click;
            btnCancelar.Click += btnCancelar_Click;

            _cliente = cliente;
            _serie = serie;
            _saldoActual = saldoActual;

            string dataPath = Path.Combine(Application.StartupPath, "Data2");
            rutaCobranza = Path.Combine(dataPath, "cobranza.txt");
            rutaPagos = Path.Combine(dataPath, "pagos.txt");

            lblCliente.Text = $"Cliente: {_cliente}";
            lblFactura.Text = $"Factura: {_serie}";
            lblSaldoActual.Text = $"Saldo actual: S/. {_saldoActual:N2}";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                MessageBox.Show("Ingrese un monto válido (número).");
                txtMonto.Focus();
                return;
            }

            if (monto <= 0)
            {
                MessageBox.Show("El monto debe ser mayor a cero.");
                txtMonto.Focus();
                return;
            }

            if (monto > _saldoActual)
            {
                MessageBox.Show($"El monto no puede superar el saldo actual (S/. {_saldoActual:N2}).");
                txtMonto.Focus();
                return;
            }

            bool actualizado = ActualizarSaldoEnCobranza(_serie, monto);
            if (!actualizado)
            {
                MessageBox.Show("No se pudo actualizar la factura. Verifique el archivo cobranza.txt.");
                return;
            }

            decimal nuevoSaldo = _saldoActual - monto;
            RegistrarPagoEnHistorial(_serie, monto, nuevoSaldo);

            // Mensaje de pago exitoso
            MessageBox.Show($"Pago de S/. {monto:N2} registrado correctamente.");

            MontoPagado = monto;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ActualizarSaldoEnCobranza(string serie, decimal montoPagado)
        {
            if (!File.Exists(rutaCobranza)) return false;

            string[] lineas = File.ReadAllLines(rutaCobranza, Encoding.UTF8);
            bool encontrado = false;

            for (int i = 0; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(';');

                // La serie está en el índice 2 (tercer campo)
                if (campos.Length >= 5 && campos[2] == serie)
                {
                    decimal saldoActual = Convert.ToDecimal(campos[4]);
                    decimal nuevoSaldo = saldoActual - montoPagado;
                    if (nuevoSaldo < 0) nuevoSaldo = 0;
                    campos[4] = nuevoSaldo.ToString("0.00");
                    lineas[i] = string.Join(";", campos);
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                File.WriteAllLines(rutaCobranza, lineas, Encoding.UTF8);
                return true;
            }
            return false;
        }

        private void RegistrarPagoEnHistorial(string serie, decimal montoPagado, decimal nuevoSaldo)
        {
            string linea = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss};{serie};{montoPagado:N2};{nuevoSaldo:N2}";
            File.AppendAllText(rutaPagos, linea + Environment.NewLine, Encoding.UTF8);
        }

        private void RegistrarPago_Load(object sender, EventArgs e)
        {

        }
    }
}
