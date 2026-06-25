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
        // Lista para almacenar los márgenes
        List<string[]> margenes = new List<string[]>();
        string ruta = Path.Combine(Application.StartupPath, "Data2", "margenes.txt");

        public Margenes()
        {
            InitializeComponent();
        }

        private void Margenes_Load(object sender, EventArgs e)
        {
            margenes.Clear();

            // Carga datos usando Utilitario
            Utilitario.CargarArchivoTXT(ruta, margenes);

            RefrescarTarjetas();
        }
        private void RefrescarTarjetas()
        {
            // Limpia el panel
            flpMargenes.Controls.Clear();

            // Recorre cada margen en la lista
            foreach (string[] campos in margenes)
            {
                if (campos.Length < 7) continue;

                string producto = campos[0];
                string cliente = campos[1];
                string minimo = campos[2];
                string maximo = campos[3];
                string promedio = campos[4];
                string vigenciaInicio = campos[5];
                string vigenciaFin = campos[6];

                // Crear la tarjeta y asignar datos
                TARJETA_MARGEN tarjeta = new TARJETA_MARGEN();
                tarjeta.AsignarDatos(producto, cliente, minimo, maximo, promedio, vigenciaInicio, vigenciaFin);
                tarjeta.MargenEditado += Tarjeta_MargenEditado;
                flpMargenes.Controls.Add(tarjeta);
            }
        }
        private void Tarjeta_MargenEditado(object sender, string[] nuevosDatos)
        {
            for (int i = 0; i < margenes.Count; i++)
            {
                if (margenes[i][0] == nuevosDatos[0] && margenes[i][1] == nuevosDatos[1])
                {
                    margenes[i] = nuevosDatos;
                    break;
                }
            }

            Utilitario.GuardarArchivoTXT(ruta, margenes);
            RefrescarTarjetas();
        }
        private void btnNuevoMargen_Click(object sender, EventArgs e)
        {

            NuevoMargen nuevo = new NuevoMargen();
            if (nuevo.ShowDialog() == DialogResult.OK)
            {
                margenes.Add(nuevo.DatosMargen);
                Utilitario.GuardarArchivoTXT(ruta, margenes);
                RefrescarTarjetas();
            }
        }
    }
}
