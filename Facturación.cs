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
            dgvFacturas.ColumnCount = 9;
            dgvFacturas.Columns[0].Name = "SERIE";
            dgvFacturas.Columns[1].Name = "CLIENTE";
            dgvFacturas.Columns[2].Name = "VENDEDORA";
            dgvFacturas.Columns[3].Name = "TIPO";
            dgvFacturas.Columns[4].Name = "TOTAL";
            dgvFacturas.Columns[5].Name = "SALDO";
            dgvFacturas.Columns[6].Name = "MARGEN";
            dgvFacturas.Columns[7].Name = "ESTADO";
            dgvFacturas.Columns[8].Name = "VENCE";

            // Configurar ancho de cada columna de dgvFacturas
            dgvFacturas.Columns[0].Width = 100;
            dgvFacturas.Columns[1].Width = 200;
            dgvFacturas.Columns[2].Width = 100;
            dgvFacturas.Columns[3].Width = 80;
            dgvFacturas.Columns[4].Width = 100;
            dgvFacturas.Columns[5].Width = 100;
            dgvFacturas.Columns[6].Width = 80;
            dgvFacturas.Columns[7].Width = 100;
            dgvFacturas.Columns[8].Width = 120;
        }
        private void Facturación_Load(object sender, EventArgs e)
        {
            Utilitario.CargarArchivoTXT(ruta, facturas, dgvFacturas);
            ActualizarResumenes();
        }
        private void ActualizarResumenes()
        {
            int totalFacturas = facturas.Count;
            double totalFacturado = 0;
            double porCobrar = 0;
            double vencido = 0;

            foreach (string[] factura in facturas)
            {
                // Usar CultureInfo.InvariantCulture para que el punto en montos sea decimal
                double total = double.Parse(factura[4], CultureInfo.InvariantCulture);
                double saldo = double.Parse(factura[5], CultureInfo.InvariantCulture);
                string estado = factura[7];

                totalFacturado += total;
                porCobrar += saldo;
                if (estado == "Vencida")
                    vencido += saldo;
            }

            lblTotalFacturas.Text = $"{totalFacturas} facturas registradas";
            lblTotalFacturado.Text = $"S/. {totalFacturado:N2}";
            lblPorCobrar.Text = $"S/. {porCobrar:N2}";
            lblVencido.Text = $"S/. {vencido:N2}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NuevaFactura frm = new NuevaFactura(facturas))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    facturas.Add(frm.DatosFactura);
                    Utilitario.GuardarArchivoTXT(ruta, facturas);
                    Utilitario.CargarArchivoTXT(ruta, facturas, dgvFacturas);
                    ActualizarResumenes();
                }
            }
        }
    }
}
