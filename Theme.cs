using System.Drawing;
using System.Windows.Forms;

namespace StretchFilmApp
{
    /// <summary>
    /// Colores, fuentes y estilos reutilizables para mantener todas las
    /// pantallas con el mismo aspecto. Cambia aquí y se actualiza en todo el sistema.
    /// </summary>
    public static class Theme
    {
        // ---- Colores ----
        public static readonly Color Verde         = Color.FromArgb(22, 163, 74);    // #16A34A  botón principal
        public static readonly Color VerdeFondo    = Color.FromArgb(220, 252, 231);  // fondo de badge "activo/aprobado"
        public static readonly Color Fondo         = Color.FromArgb(247, 247, 244);  // fondo de la página
        public static readonly Color PanelBlanco   = Color.White;
        public static readonly Color Borde         = Color.FromArgb(229, 231, 235);
        public static readonly Color TextoPrincipal= Color.FromArgb(31, 41, 55);     // gris oscuro
        public static readonly Color TextoTenue    = Color.FromArgb(107, 114, 128);  // gris medio
        public static readonly Color Ambar         = Color.FromArgb(180, 83, 9);     // estado "en proceso"
        public static readonly Color Azul          = Color.FromArgb(37, 99, 235);    // estado "pendiente"

        // ---- Fuentes ----
        public static readonly Font Titulo    = new Font("Segoe UI", 15F, FontStyle.Bold);
        public static readonly Font Subtitulo = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        public static readonly Font Texto     = new Font("Segoe UI", 9F, FontStyle.Regular);
        public static readonly Font Etiqueta  = new Font("Segoe UI", 8.25F, FontStyle.Regular);

        // ---- Botón verde (acciones principales: "+ Nuevo ...") ----
        public static void BotonPrimario(Button b)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.BackColor = Verde;
            b.ForeColor = Color.White;
            b.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b.Cursor = Cursors.Hand;
            b.UseVisualStyleBackColor = false;
        }

        // ---- Botón secundario (bordeado, fondo blanco) ----
        public static void BotonSecundario(Button b)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderColor = Borde;
            b.BackColor = Color.White;
            b.ForeColor = TextoPrincipal;
            b.Font = Texto;
            b.Cursor = Cursors.Hand;
            b.UseVisualStyleBackColor = false;
        }

        // ---- Estilo estándar para todas las tablas (DataGridView) ----
        public static void EstilizarGrid(DataGridView dgv)
        {
            dgv.ColumnHeadersVisible = true;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Borde;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.EnableHeadersVisualStyles = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowTemplate.Height = 38;
            dgv.Font = Texto;

            // Encabezados
            dgv.ColumnHeadersHeight = 34;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = TextoTenue;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);

            // Celdas
            dgv.DefaultCellStyle.ForeColor = TextoPrincipal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 249, 244);
            dgv.DefaultCellStyle.SelectionForeColor = TextoPrincipal;
            dgv.DefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
        }
    }
}
