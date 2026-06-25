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
    public partial class HistorialPagos : Form
    {
        // Guarda la serie de la factura y la lista de pagos
        private string _serieFactura;
        private List<string[]> _pagos = new List<string[]>();
        public HistorialPagos(string serie)
        {
            InitializeComponent();
            _serieFactura = serie;
            CargarHistorial(serie);
        }
        private void CargarHistorial(string serie)
        {
            string rutaPagos = Path.Combine(Application.StartupPath, "Data2", "pagos.txt");

            // Limpia la lista de pagos
            _pagos.Clear();

            // Se cargan los datos con Utilitario en una lista
            List<string[]> listaPagos = new List<string[]>();
            Utilitario.CargarArchivoTXT(rutaPagos, listaPagos);

            dgvHistorial.Rows.Clear();

            // Configura las columnas
            dgvHistorial.ColumnCount = 3;
            dgvHistorial.Columns[0].Name = "FECHA Y HORA";
            dgvHistorial.Columns[1].Name = "MONTO PAGADO";
            dgvHistorial.Columns[2].Name = "SALDO RESTANTE";

            // Anchos fijos
            dgvHistorial.Columns[0].Width = 150;
            dgvHistorial.Columns[1].Width = 150;
            dgvHistorial.Columns[2].Width = 150;

            // Recorre la lista cargada por Utilitario
            foreach (string[] campos in listaPagos)
            {
                if (campos.Length >= 4 && campos[1] == serie)
                {
                    double monto = double.Parse(campos[2]);
                    double saldo = double.Parse(campos[3]);

                    dgvHistorial.Rows.Add(campos[0], $"S/. {monto:N2}", $"S/. {saldo:N2}");
                }
            }

            if (dgvHistorial.Rows.Count == 0)
            {
                MessageBox.Show("No hay pagos registrados para esta factura.");
            }
        }
        private void HistorialPagos_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            if (dgvHistorial.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un pago para eliminar.");
                return;
            }

            DataGridViewRow row = dgvHistorial.SelectedRows[0];

            // Obtiene los datos de la fila
            string fecha = row.Cells[0].Value.ToString();           // Columna 0: FECHA Y HORA
            string montoPagado = row.Cells[1].Value.ToString();     // Columna 1: MONTO PAGADO
            string saldoRestante = row.Cells[2].Value.ToString();   // Columna 2: SALDO RESTANTE

            // Limpia los valores para mostrar
            string montoMostrar = montoPagado.Replace("S/.", "").Trim();
            string saldoMostrar = saldoRestante.Replace("S/.", "").Trim();

            // Confirmación del usuario
                DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea eliminar este pago?\n\n" +
                $"Fecha: {fecha} \n" +
                $"Monto pagado: S/. {montoMostrar}\n" +
                $"Saldo restante: S/. {saldoMostrar}\n\n" +
                "Esta acción no se puede deshacer.",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                // Se elimina el pago de pagos.txt
                double montoEliminado = EliminarLineaDelArchivo(fecha, montoPagado);

                // Restaura el saldo en facturacion.txt
                if (montoEliminado > 0)
                {
                    RestaurarSaldoEnFactura(_serieFactura, montoEliminado);
                }

                // Busca y elimina por fecha y monto
                EliminarLineaDelArchivo(fecha, montoPagado);

                // Elimina la fila del grid
                dgvHistorial.Rows.RemoveAt(row.Index);

                MessageBox.Show("Pago eliminado correctamente.");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private double EliminarLineaDelArchivo(string fecha, string montoPagado)
        {
            string rutaPagos = Path.Combine(Application.StartupPath, "Data2", "pagos.txt");

            if (!File.Exists(rutaPagos)) return 0;

            List<string> lineas = new List<string>(File.ReadAllLines(rutaPagos));

            // Limpia el monto para comparar (se quita "S/. " y espacios)
            string montoBuscar = montoPagado.Replace("S/.", "").Trim();
            double montoEliminado = 0;

            for (int i = 0; i < lineas.Count; i++)
            {
                string[] campos = lineas[i].Split(',');

                // Verifica si la línea coincide con la fecha y el monto
                if (campos.Length >= 3 && campos[0] == fecha && campos[2] == montoBuscar)
                {
                    montoEliminado = double.Parse(campos[2]);
                    lineas.RemoveAt(i);
                    break;
                }
            }

            File.WriteAllLines(rutaPagos, lineas);
            return montoEliminado;
        }
        private void RestaurarSaldoEnFactura(string serie, double montoRestaurado)
        {
            string rutaFacturas = Path.Combine(Application.StartupPath, "Data2", "facturacion.txt");

            if (!File.Exists(rutaFacturas)) return;

            // Carga todas las facturas
            List<string[]> listaFacturas = new List<string[]>();
            Utilitario.CargarArchivoTXT(rutaFacturas, listaFacturas);

            // Busca la factura por su serie
            for (int i = 0; i < listaFacturas.Count; i++)
            {
                string[] campos = listaFacturas[i];
                if (campos[0] == serie)  // Serie en índice 0
                {
                    // Restaura el saldo: saldo actual + monto eliminado
                    double saldoActual = double.Parse(campos[6]);  // Saldo en índice 6
                    double nuevoSaldo = saldoActual + montoRestaurado;
                    campos[6] = nuevoSaldo.ToString("0.00");
                    listaFacturas[i] = campos;
                    break;
                }
            }

            // Guardar el archivo actualizado
            Utilitario.GuardarArchivoTXT(rutaFacturas, listaFacturas);
        }
    }
}
