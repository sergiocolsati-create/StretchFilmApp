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
    }
}
