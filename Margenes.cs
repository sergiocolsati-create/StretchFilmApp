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
    public partial class Margenes : Form
    {
        public Margenes()
        {
            InitializeComponent();
        }

        private void Margenes_Load(object sender, EventArgs e)
        {
            CargarMargenesDesdeTXT();
        }
        private void CargarMargenesDesdeTXT()
        {
            string ruta = Path.Combine(Application.StartupPath, "Data2", "margenes.txt");
            if (!File.Exists(ruta))
            {
                MessageBox.Show("No se encuentra el archivo: " + ruta);
                return;
            }

            flpMargenes.Controls.Clear();

            string[] lineas = File.ReadAllLines(ruta, Encoding.UTF8);
            
            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                string[] campos = linea.Split(';');
                if (campos.Length < 8) continue;

                string producto = campos[0];
                string cliente = campos[1];
                string minimo = campos[2];
                string maximo = campos[3];
                string promedio = campos[4];
                string activo = campos[5];
                string vigenciaInicio = campos[6];
                string vigenciaFin = campos[7];

                TARJETA_MARGEN tarjeta = new TARJETA_MARGEN();
                tarjeta.AsignarDatos(producto, cliente, minimo, maximo, promedio, activo, vigenciaInicio, vigenciaFin);
                flpMargenes.Controls.Add(tarjeta);
            }
        }
    }
}
