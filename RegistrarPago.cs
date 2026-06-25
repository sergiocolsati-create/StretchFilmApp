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
    public partial class RegistrarPago : Form
    {
        public double MontoPagado { get; private set; }  // Monto que se pagó se envía a la tarjeta
        private string _serie;                           // Número de serie de la factura
        private string _cliente;                         // Nombre del cliente
        private double _saldoActual;                     // Saldo pendiente antes del pago
        private string rutaFacturas;                     // Ruta del archivo facturacion.txt
        private string rutaPagos;                        // Ruta del archivo pagos.txt
        public RegistrarPago(string cliente, string serie, double saldoActual)
        {
            InitializeComponent();

            // Suscripción de Eventos
            btnAceptar.Click += btnAceptar_Click;
            btnCancelar.Click += btnCancelar_Click;

            // Guarda los datos recibidos en variables privadas
            _cliente = cliente;
            _serie = serie;
            _saldoActual = saldoActual;

            string dataPath = Path.Combine(Application.StartupPath, "Data2");
            rutaFacturas = Path.Combine(dataPath, "facturacion.txt");
            rutaPagos = Path.Combine(dataPath, "pagos.txt");

            // Muestra la información en los labels
            lblCliente.Text = $"Cliente: {_cliente}";
            lblFactura.Text = $"Factura: {_serie}";
            lblSaldoActual.Text = $"Saldo actual: S/. {_saldoActual:N2}";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Se convierte el texto del monto a número
            // NumberStyles.Any permite cualquier formato numérico
            // CultureInfo.InvariantCulture usa punto como separador decimal
            if (!double.TryParse(txtMonto.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double monto))
            {
                MessageBox.Show("Ingrese un monto válido (número).");
                return;
            }

            if (monto <= 0)
            {
                MessageBox.Show("El monto debe ser mayor a cero.");
                return;
            }

            if (monto > _saldoActual)
            {
                MessageBox.Show($"El monto no puede superar el saldo actual (S/. {_saldoActual:N2}).");
                return;
            }

            // Actualiza el saldo en facturacion.txt, se reduce el saldo de la factura
            bool actualizado = ActualizarSaldoEnFacturas(_serie, monto);

            if (!actualizado)
            {
                MessageBox.Show("No se pudo actualizar la factura. Verifique el archivo facturacion.txt.");
                return;
            }

            // Calcula el nuevo saldo -> Saldo actual - Monto pagado
            double nuevoSaldo = _saldoActual - monto;

            // Registrar el pago en el historial (pagos.txt)
            RegistrarPagoEnHistorial(_serie, monto, nuevoSaldo);

            MessageBox.Show($"Pago de S/. {monto:N2} registrado correctamente.");

            // Se guarda el monto pagado en la variable pública
            MontoPagado = monto;

            // DialogResult = OK le indica al formulario que abrió esta ventana (TARJETA_COBRANZA)
            // El usuario presionó "Aceptar" y el pago se registró correctamente.
            // Con esto la tarjeta actualiza el saldo en pantalla.
            DialogResult = DialogResult.OK;
            Close();        //Cierra formulario
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // DialogResult.Cancel le indica al formulario que el usuario canceló la operación
            // No se hizo ningún pago
            // La tarjeta no debe actualizar el saldo
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ActualizarSaldoEnFacturas(string serie, double montoPagado)
        {
            // Verifica si el archivo existe
            if (!File.Exists(rutaFacturas)) return false;

            // Lee todas las líneas del archivo
            string[] lineas = File.ReadAllLines(rutaFacturas);

            // Recorre todas las líneas buscando la factura
            for (int i = 0; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(',');
                if (campos.Length >= 7 && campos[0] == serie)
                {
                    // Obtiene el saldo actual
                    double saldoActual = double.Parse(campos[6]);

                    // Calcula el nuevo saldo
                    double nuevoSaldo = saldoActual - montoPagado;
                    if (nuevoSaldo < 0) nuevoSaldo = 0;

                    // Actualizar el saldo en columna 6
                    campos[6] = nuevoSaldo.ToString("0.00");

                    // Rehace la línea uniendo los campos con comas
                    lineas[i] = string.Join(",", campos);

                    // Guarda todo el archivo con la línea modificada
                    File.WriteAllLines(rutaFacturas, lineas);

                    return true;    // Indica que se encontró y actualizó
                }
            }
            return false;           // No se encontró la factura
        }

        private void RegistrarPagoEnHistorial(string serie, double montoPagado, double nuevoSaldo)
        {
            MessageBox.Show($"Guardando historial - Nuevo saldo: {nuevoSaldo}");

            // Lista para guardar todo el historial, todas las líneas
            List<string[]> historial = new List<string[]>();

            // Si el archivo ya existe, leer todas las líneas existentes
            if (File.Exists(rutaPagos))
            {
                string[] lineas = File.ReadAllLines(rutaPagos);
                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                        historial.Add(linea.Split(','));    // Agrega línea existente
                }
            }

            // Crea la nueva línea con los datos del pago
            // Formato: fecha, serie, montoPagado, nuevoSaldo
            // ToString("0.00") para dar formato con 2 decimales
            string nuevaLinea = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss},{serie},{montoPagado.ToString("0.00")},{nuevoSaldo.ToString("0.00")}";

            // Agregar la nueva línea a la lista
            historial.Add(nuevaLinea.Split(','));

            // Reescribir todo el archivo con las líneas existentes más la nueva
            using (StreamWriter escritor = new StreamWriter(rutaPagos))
            {
                foreach (string[] registro in historial)
                {
                    escritor.WriteLine(string.Join(",", registro));
                }
            }
        }

        private void RegistrarPago_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
          
        }
    }
}
