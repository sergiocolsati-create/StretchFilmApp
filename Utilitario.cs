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
        public static void CargarArchivoTXT(string ruta, List<string[]> listaDatos)
        {
            // Verifica si el archivo existe
            if (!File.Exists(ruta)) 
            { 
                MessageBox.Show("El archivo no existe"); 
                return; 
            }

            // Limpia la lista
            listaDatos.Clear();

            // Lee todas las líneas del archivo
            string[] lineas = File.ReadAllLines(ruta);

            // Recorrer cada línea
            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                // Separar la línea por comas
                string[] campos = linea.Split(',');

                // Agregar los campos a la lista
                listaDatos.Add(campos);
            }

            MessageBox.Show($"Se cargaron {listaDatos.Count} registros a la lista.");
        }

        public static void GuardarArchivoTXT(string ruta, List<string[]> listaDatos)
        {
            try
            {
                // Crea un escritor
                using (StreamWriter escritor = new StreamWriter(ruta, false, Encoding.UTF8))
                {
                    // Recorrer cada registro de la lista
                    foreach (string[] registro in listaDatos)
                    {
                        // Une los campos con comas y escribir en el archivo
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
