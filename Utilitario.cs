using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace StretchFilmApp
{
    public static class Utilitario
    {
        // Separador de campos.
        public const char SEPARADOR = ',';

        /// <summary>
        /// Lee el TXT a la lista y vuelca los datos en la grilla.
        /// Se adapta a CUALQUIER número de columnas: coloca cada campo solo en las
        /// columnas de datos (texto) y respeta las columnas-botón al final.
        /// </summary>
        public static void CargarArchivoTXT(string ruta, List<string[]> listaDatos,
                                            DataGridView grilla, bool mostrarMensajes = false)
        {
            if (!File.Exists(ruta))
            {
                if (mostrarMensajes) MessageBox.Show("El archivo no existe.");
                return;
            }

            listaDatos.Clear();
            foreach (string linea in File.ReadAllLines(ruta, Encoding.UTF8))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                listaDatos.Add(linea.Split(SEPARADOR));
            }

            grilla.Rows.Clear();
            foreach (string[] registro in listaDatos)
            {
                int indice = grilla.Rows.Add();
                LlenarFila(grilla.Rows[indice], registro);
            }

            if (mostrarMensajes)
                MessageBox.Show($"Se cargaron {listaDatos.Count} registros.");
        }

        /// <summary>
        /// Guarda la lista en el TXT usando el separador configurado.
        /// </summary>
        public static void GuardarArchivoTXT(string ruta, List<string[]> listaDatos)
        {
            try
            {
                string carpeta = Path.GetDirectoryName(ruta);
                if (!string.IsNullOrEmpty(carpeta) && !Directory.Exists(carpeta))
                    Directory.CreateDirectory(carpeta);

                using (StreamWriter escritor = new StreamWriter(ruta, false, Encoding.UTF8))
                {
                    foreach (string[] registro in listaDatos)
                        escritor.WriteLine(string.Join(SEPARADOR.ToString(), registro));
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
