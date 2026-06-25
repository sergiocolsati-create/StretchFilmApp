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
    public partial class ModificarFactura : Form
    {
        // Propiedad para devolver la factura modificada (9 campos)
        public string[] DatosFactura { get; private set; }

        // Guardar la serie original. No es modificable
        private string _serieOriginal;
        public ModificarFactura(string[] datosFactura)
        {
            InitializeComponent();

            // Guarda la serie original
            _serieOriginal = datosFactura[0];

            // Carga datos en los controles
            lblSerie.Text = datosFactura[0];
            txtCliente.Text = datosFactura[1];
            txtRUC.Text = datosFactura[2];
            txtVendedora.Text = datosFactura[3];
            cboTipo.SelectedItem = datosFactura[4];
            txtTotal.Text = datosFactura[5];
            txtMargen.Text = datosFactura[7];

            // Carga fecha de vencimiento
            string vence = datosFactura[8];
            if (!string.IsNullOrEmpty(vence) && vence != "—" && vence != "-")
            {
                DateTime fechaVenc;
                if (DateTime.TryParseExact(vence, "d/M/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaVenc))
                {
                    dtpVencimiento.Value = fechaVenc;
                }
            }

            // Carga opciones del ComboBox
            cboTipo.Items.Clear();
            cboTipo.Items.AddRange(new[] { "CONTADO", "CREDITO" });

            // Carga el tipo que está en la factura original
            string tipoFactura = datosFactura[4].Trim();
            if (tipoFactura == "CREDITO")
                cboTipo.SelectedIndex = 1;
            else
                cboTipo.SelectedIndex = 0;  // Carga CONTADO por defecto


            // Muestra u ocultar fecha de vencimiento según tipo
            if (cboTipo.Text == "CREDITO")
                dtpVencimiento.Visible = true;
            else
                dtpVencimiento.Visible = false;

            // Suscribe eventos
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            txtTotal.TextChanged += txtTotal_TextChanged;

            // Calcula el saldo inicial según tipo
            ActualizarSaldo();

        }
        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipo.Text == "CREDITO")
                dtpVencimiento.Visible = true;
            else
                dtpVencimiento.Visible = false;

            ActualizarSaldo();
        }
        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            ActualizarSaldo();
        }

        private void ActualizarSaldo()
        {
            if (double.TryParse(txtTotal.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double total))
            {
                if (cboTipo.Text == "CREDITO")
                    txtSaldo.Text = total.ToString("0.00");
                else
                    txtSaldo.Text = "0.00";
            }
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

            DateTime fechaVenc;
            if (DateTime.TryParseExact(fechaVencStr, "d/M/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaVenc))
            {
                if (fechaVenc.Date < DateTime.Now.Date)
                    return "Vencida";
            }
            return "Emitida";
        }
        private string CalcularVenceTexto(double saldo, string fechaVencStr)
        {
            if (saldo == 0) return "—";

            DateTime fechaVenc;
            if (DateTime.TryParseExact(fechaVencStr, "d/M/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaVenc))
            {
                return fechaVenc.ToString("dd/MM/yyyy");
            }
            return "—";
        }

        private void ModificarFactura_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            // Valida campos obligatorios
            if (string.IsNullOrWhiteSpace(txtCliente.Text) || string.IsNullOrWhiteSpace(txtRUC.Text) || string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                MessageBox.Show("Complete Cliente, RUC y Total.");
                return;
            }

            if (!double.TryParse(txtTotal.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double total))
            {
                MessageBox.Show("Ingrese un Total válido.");
                return;
            }

            double saldo;
            string fechaVenc = "";

            if (cboTipo.Text == "CREDITO")
            {
                saldo = total;
                fechaVenc = dtpVencimiento.Value.ToString("d/M/yyyy");
            }
            else
            {
                saldo = 0;
            }

            if (!double.TryParse(txtMargen.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double margen))
            {
                margen = 25.0;
            }

            string estado = CalcularEstado(saldo, total, fechaVenc);
            string venceTexto = CalcularVenceTexto(saldo, fechaVenc);

            DatosFactura = new string[]
            {
                _serieOriginal,
                txtCliente.Text,
                txtRUC.Text,
                txtVendedora.Text,
                cboTipo.Text,
                total.ToString("0.00"),
                saldo.ToString("0.00"),
                margen.ToString("0") + "%",
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
