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
    public partial class Dashboard : Form
    {
        public Dashboard() 
        {
            InitializeComponent();
        }

        private void bttnSol_Click(object sender, EventArgs e)
        {
            Solicitudes frmSolicitudes = new Solicitudes();
            frmSolicitudes.ShowDialog();
            
        }

        private void bttnCotiz_Click(object sender, EventArgs e)
        {
            Cotizaciones frmCotizaciones = new Cotizaciones();
            frmCotizaciones.ShowDialog();
        }

        private void bttnProv_Click(object sender, EventArgs e)
        {
            Proveedores frmProveedores =new Proveedores();
            frmProveedores.ShowDialog();
        }

        private void bttnProd_Click(object sender, EventArgs e)
        {
            Productos frmProductos = new Productos();
            frmProductos.ShowDialog();
        }

        private void bttnAdqui_Click(object sender, EventArgs e)
        {
            Adquisicion frmAdquisición = new Adquisicion();
            frmAdquisición.ShowDialog();
        }

        private void bttnFac_Click(object sender, EventArgs e)
        {
            Facturación frmFacturación = new Facturación();
            frmFacturación.ShowDialog();
        }

        private void bttnCobra_Click(object sender, EventArgs e)
        {
            Cobranza frmCobranza = new Cobranza();
            frmCobranza.ShowDialog();
        }

        private void bttnMarg_Click(object sender, EventArgs e)
        {
            Margenes frmMargenes = new Margenes();
            frmMargenes.ShowDialog();
        }

        private void bttnUser_Click(object sender, EventArgs e)
        {
            Usuarios frmUsuarios = new Usuarios();
            frmUsuarios.ShowDialog();
        }

        private void bttnClien_Click(object sender, EventArgs e)
        {
            Clientes frmClientes = new Clientes();
            frmClientes.ShowDialog();
        }
    }
}
