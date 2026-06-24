using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StretchFilmApp
{
    public partial class NuevaFactura : Form
    {
        // Propiedad para devolver la nueva factura (array de 9 strings)
        public string[] DatosFactura { get; private set; }

        // Recibimos la lista de facturas actual para calcular la nueva serie
        private List<string[]> facturasExistentes;

        public NuevaFactura(List<string[]> facturas)
        {
            InitializeComponent();
            facturasExistentes = facturas;
            cboTipo.Items.AddRange(new[] { "CONTADO", "CREDITO" });
            cboTipo.SelectedIndex = 0;
            dtpVencimiento.Visible = false;
            cboTipo.SelectedIndexChanged += (s, e) => dtpVencimiento.Visible = (cboTipo.Text == "CREDITO");

            // Autogenerar la serie
            lblSerie.Text = GenerarNuevaSerie();
        }

        private string GenerarNuevaSerie()
        {
            int maxNumero = 0;
            foreach (var factura in facturasExistentes) // ← usa facturasExistentes
            {
                string serie = factura[0];
                if (serie.StartsWith("FACT-") && int.TryParse(serie.Substring(5), out int num))
                {
                    if (num > maxNumero) maxNumero = num;
                }
                else
                {
                    if (int.TryParse(serie, out int num2) && num2 > maxNumero)
                        maxNumero = num2;
                }
            }
            return $"FACT-{(maxNumero + 1):000}";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private string CalcularEstado(double saldo, double total, string fechaVencStr)
        {
            if (saldo == 0) return "Pagada";
            if (saldo < total) return "Parcial";
            if (!string.IsNullOrEmpty(fechaVencStr) && DateTime.TryParseExact(fechaVencStr, "d/M/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaVenc))
            {
                if (fechaVenc.Date < DateTime.Now.Date) return "Vencida";
            }
            return "Emitida";
        }

        private string CalcularVenceTexto(double saldo, string fechaVencStr)
        {
            if (saldo == 0) return "—";
            if (!string.IsNullOrEmpty(fechaVencStr) && DateTime.TryParseExact(fechaVencStr, "d/M/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaVenc))
            {
                int dias = (fechaVenc - DateTime.Now.Date).Days;
                if (dias < 0) return $"Vencida hace {-dias}d";
                return $"{fechaVenc:dd/MM/yyyy} ({dias}d)";
            }
            return "—";
        }

        private void NuevaFactura_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtCliente.Text) || string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                MessageBox.Show("Complete Cliente y Total.");
                return;
            }

            double total = double.Parse(txtTotal.Text, CultureInfo.InvariantCulture);
            double saldo = 0;
            string fechaVenc = "";

            if (cboTipo.Text == "CREDITO")
            {
                saldo = total;
                fechaVenc = dtpVencimiento.Value.ToString("d/M/yyyy");
            }

            string margen = "25.0";
            // Calcular estado y venceTexto usando la misma lógica que en Facturación
            string estado = CalcularEstado(saldo, total, fechaVenc);
            string venceTexto = CalcularVenceTexto(saldo, fechaVenc);

            // Crear array de 9 campos
            DatosFactura = new string[]
            {
                lblSerie.Text,
                txtCliente.Text,
                txtVendedora.Text,
                cboTipo.Text,
                total.ToString("0.00", CultureInfo.InvariantCulture),
                saldo.ToString("0.00", CultureInfo.InvariantCulture),
                margen,
                estado,
                venceTexto
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
