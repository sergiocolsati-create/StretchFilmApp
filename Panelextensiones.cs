using System;
using System.Drawing;
using System.Windows.Forms;

namespace StretchFilmApp
{
    /// <summary>
    /// Métodos de extensión para agregar un botón de "cerrar" (✕) a los paneles
    /// de tipo "Nuevo registro" en cualquier formulario, de forma consistente.
    /// </summary>
    public static class PanelExtensiones
    {
        /// <summary>
        /// Agrega un botón ✕ en la esquina superior derecha del panel, que al
        /// hacer clic lo oculta (Visible = false). Pensado para los paneles
        /// "Nueva solicitud", "Nuevo proveedor", "Nuevo producto", "Nueva orden", etc.
        /// </summary>
        /// <param name="panel">El panel al que se le agregará el botón de cerrar.</param>
        /// <param name="accionAlCerrar">
        /// Acción opcional a ejecutar además de ocultar el panel (por ejemplo,
        /// limpiar los campos del formulario). Si es null, solo se oculta el panel.
        /// </param>
        public static void AgregarBotonCerrar(this Panel panel, Action accionAlCerrar = null)
        {
            var btnCerrar = new Button
            {
                Text = "✕",
                Name = "btnCerrarPanelAuto",
                Size = new Size(28, 28),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = Color.FromArgb(107, 114, 128),
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Cursor = Cursors.Hand,
                TabStop = false
            };
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 244, 246);

            // Posición: esquina superior derecha, con un pequeño margen.
            btnCerrar.Location = new Point(panel.ClientSize.Width - btnCerrar.Width - 10, 8);

            btnCerrar.Click += (s, e) =>
            {
                panel.Visible = false;
                accionAlCerrar?.Invoke();
            };

            panel.Controls.Add(btnCerrar);
            btnCerrar.BringToFront();
        }
    }
}