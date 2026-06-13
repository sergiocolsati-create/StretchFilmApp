using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StretchFilmApp
{
    public static class Utilitario
    {
        public static void CargarArchivoTXT(string ruta, List<string[]> listaDatos, DataGridView grilla)
        {
            if (!File.Exists(ruta))
            {
                MessageBox.Show("El archivo No existe");
                return;
            }

            listaDatos.Clear();

            string[] lineas = File.ReadAllLines(ruta, Encoding.UTF8);

            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                string[] campos = linea.Split(',');

                listaDatos.Add(campos);
            }

            MessageBox.Show($"Se cargaron {listaDatos.Count} registros a la lista");

            grilla.Rows.Clear();
            foreach (string[] registro in listaDatos)
            {
                grilla.Rows.Add(registro);
            }
        }

        public static void GuardarArchivoTXT(string ruta, List<string[]> listaDatos)
        {
            try
            {
                using (StreamWriter escritor = new StreamWriter(ruta, false, Encoding.UTF8))
                {
                    foreach (string[] registro in listaDatos)
                    {
                        string linea = string.Join(",", registro);
                        escritor.WriteLine(linea);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar el archivo.");
            }
        }
    }
}
