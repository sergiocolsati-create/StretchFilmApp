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
    public partial class Facturación : Form
    {
        // Lista donde se guardarán las facturas
        List<string[]> facturas = new List<string[]>();

        // Ruta del archivo
        string ruta = Path.Combine(Application.StartupPath, "Data2", "facturacion.txt");

        public Facturación()
        {
            InitializeComponent();

            // Configurar grilla dgvFacturas
            dgvFacturas.ColumnCount = 10;
            dgvFacturas.Columns[0].Name = "SERIE";
            dgvFacturas.Columns[1].Name = "CLIENTE";
            dgvFacturas.Columns[2].Name = "RUC";
            dgvFacturas.Columns[3].Name = "VENDEDORA";
            dgvFacturas.Columns[4].Name = "TIPO";
            dgvFacturas.Columns[5].Name = "TOTAL";
            dgvFacturas.Columns[6].Name = "SALDO";
            dgvFacturas.Columns[7].Name = "MARGEN";
            dgvFacturas.Columns[8].Name = "ESTADO";
            dgvFacturas.Columns[9].Name = "VENCE";


            // Configurar ancho de cada columna de dgvFacturas
            dgvFacturas.Columns[0].Width = 100;
            dgvFacturas.Columns[1].Width = 200;
            dgvFacturas.Columns[2].Width = 110;
            dgvFacturas.Columns[3].Width = 100;
            dgvFacturas.Columns[4].Width = 80;
            dgvFacturas.Columns[5].Width = 100;
            dgvFacturas.Columns[6].Width = 100;
            dgvFacturas.Columns[7].Width = 80;
            dgvFacturas.Columns[8].Width = 100;
            dgvFacturas.Columns[9].Width = 120;
        }
        private void Facturación_Load(object sender, EventArgs e)
        {
            // Carga datos usando Utilitario
            Utilitario.CargarArchivoTXT(ruta, facturas);

            //Muestra datos en el grid
            RefrescarGrid();

            // Actualiza los totales en los resúmenes
            ActualizarResumenes();
        }
        private void RefrescarGrid()
        {
            // Limpia el grid antes de cargar nuevos datos
            dgvFacturas.Rows.Clear();

            // Recorre cada factura en la lista
            foreach (string[] campos in facturas)
            {
                if (campos.Length < 9) continue;

                string serie = campos[0];
                string cliente = campos[1];
                string ruc = campos[2];
                string vendedora = campos[3];
                string tipo = campos[4];
                string totalStr = campos[5];
                string saldoStr = campos[6];
                string margen = campos[7];
                string vence = campos[8];

                // Calcula la columna ESTADO
                double total = double.Parse(totalStr);
                double saldo = double.Parse(saldoStr);
                string estado = CalcularEstado(saldo, total, vence);

                // Agrega la fila para ESTADO al grid
                dgvFacturas.Rows.Add(serie, cliente, ruc, vendedora, tipo, totalStr, saldoStr, margen, estado, vence);
            }
        }
        private void ActualizarResumenes()
        {
            int totalFacturas = facturas.Count;
            double totalFacturado = 0;
            double porCobrar = 0;
            double vencido = 0;

            // Recorre todas las factura para sumar los totales
            foreach (string[] factura in facturas)
            {
                if (factura.Length < 9) continue;

                double total = double.Parse(factura[5]);
                double saldo = double.Parse(factura[6]);
                string vence = factura[8];
                string estado = CalcularEstado(saldo, total, vence);

                // Acumula los totales
                totalFacturado += total;
                porCobrar += saldo;
                if (estado == "Vencida")
                    vencido += saldo;
            }

            // Muestra los totales en los resúmenes
            lblTotalFacturas.Text = $"{totalFacturas} facturas registradas";
            lblTotalFacturado.Text = $"S/. {totalFacturado:N2}";
            lblPorCobrar.Text = $"S/. {porCobrar:N2}";
            lblVencido.Text = $"S/. {vencido:N2}";
        }
        public string CalcularEstado(double saldo, double total, string fechaVencStr)
        {
            // Si no debe nada -> Pagada
            if (saldo == 0) return "Pagada";
            // Si debe menos del total -> PARCIAL
            if (saldo < total) return "Parcial";
            // Si tiene fecha de vencimiento y ya pasó -> Vencida
            if (!string.IsNullOrEmpty(fechaVencStr) && fechaVencStr != "—" && DateTime.TryParseExact(fechaVencStr, "d/M/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaVenc))
            {
                if (fechaVenc < DateTime.Now) return "Vencida";
            }
            return "Emitida";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (NuevaFactura frm = new NuevaFactura(facturas))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Se agrega la nueva factura a la lista
                    facturas.Add(frm.DatosFactura);

                    // Guarda en el archivo
                    Utilitario.GuardarArchivoTXT(ruta, facturas);
 
                    RefrescarGrid();
                    ActualizarResumenes();
                }
            }
        }
        private void btnModificarFactura_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModificarFactura_Click_1(object sender, EventArgs e)
        {
            // Verifica que se haya seleccionado una columna
            if (dgvFacturas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una factura para modificar.");
                return;
            }

            // Obtiene la fila seleccionada
            DataGridViewRow row = dgvFacturas.SelectedRows[0];

            // Extrae los 9 campos de la factura
            string[] datosFactura = new string[9];
            for (int i = 0; i < 9; i++)
            {
                if (row.Cells[i].Value != null)
                    datosFactura[i] = row.Cells[i].Value.ToString();
                else
                    datosFactura[i] = "";
            }

            // Abre el formulario Modificar Factura
            ModificarFactura modificar = new ModificarFactura(datosFactura);
            if (modificar.ShowDialog() == DialogResult.OK)
            {
                // Busca la factura en la lista y la actualiza
                for (int i = 0; i < facturas.Count; i++)
                {
                    // facturas[i][0] -> El primer campo de esa factura (la serie)
                    if (facturas[i][0] == modificar.DatosFactura[0])
                    {
                        facturas[i] = modificar.DatosFactura;
                        break;
                    }
                }

                Utilitario.GuardarArchivoTXT(ruta, facturas);
                RefrescarGrid();
                ActualizarResumenes();
            }
        }

        private void btnEliminarFactura_Click(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada
            if (dgvFacturas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una factura para eliminar.");
                return;
            }

            // Obtiene la fila seleccionada
            DataGridViewRow row = dgvFacturas.SelectedRows[0];

            // Obtiene los datos de la factura
            string serie = row.Cells[0].Value.ToString();
            string cliente = row.Cells[1].Value.ToString();

            // Si la serie está vacía, se asigna un valor por defecto
            if (string.IsNullOrEmpty(serie))
                serie = "Sin serie";

            // Muestra un mensaje de confirmación
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea eliminar la factura?\n\n" +
                $"Serie: {serie}\n" +
                $"Cliente: {cliente}\n\n" +
                "Esta acción no se puede deshacer.",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo
            );

            // Si el usuario confirma
            if (respuesta == DialogResult.Yes)
            {
                // Busca y elimina la factura de la lista
                for (int i = 0; i < facturas.Count; i++)
                {
                    if (facturas[i][0] == serie)
                    {
                        facturas.RemoveAt(i);
                        break;
                    }
                }

                // Se guarda en el archivo
                Utilitario.GuardarArchivoTXT(ruta, facturas);

                // Refresca el grid y los resúmenes
                RefrescarGrid();
                ActualizarResumenes();

                MessageBox.Show($"Factura {serie} eliminada correctamente.");
            }
        }
    }
}
