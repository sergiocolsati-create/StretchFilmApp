using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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

        /// <summary>
        /// Guarda la lista en el TXT usando el separador configurado.
        /// </summary>
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

        /// <summary>
        /// Extrae los datos visibles de la grilla (ignorando botones) a una lista
        /// lista para pasar a GuardarArchivoTXT.
        /// </summary>
        public static List<string[]> LeerGrilla(DataGridView grilla)
        {
            var lista = new List<string[]>();
            foreach (DataGridViewRow fila in grilla.Rows)
            {
                if (fila.IsNewRow) continue;

                var campos = new List<string>();
                foreach (DataGridViewColumn col in grilla.Columns)
                {
                    if (!EsColumnaDeDatos(col)) continue;
                    campos.Add(fila.Cells[col.Index].Value?.ToString() ?? "");
                }
                lista.Add(campos.ToArray());
            }
            return lista;
        }

        // ---- Privados ----

        private static void LlenarFila(DataGridViewRow fila, string[] datos)
        {
            int campo = 0;
            foreach (DataGridViewColumn col in fila.DataGridView.Columns)
            {
                if (campo >= datos.Length) break;
                if (!EsColumnaDeDatos(col)) continue;
                fila.Cells[col.Index].Value = datos[campo];
                campo++;
            }
        }

        private static bool EsColumnaDeDatos(DataGridViewColumn col)
        {
            return !(col is DataGridViewButtonColumn
                  || col is DataGridViewCheckBoxColumn
                  || col is DataGridViewImageColumn);
        }
    }
}
