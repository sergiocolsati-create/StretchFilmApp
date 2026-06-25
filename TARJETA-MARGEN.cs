using System;
using System.Drawing;
using System.Windows.Forms;

namespace StretchFilmApp
{
    /// <summary>
    /// Control de usuario (tarjeta visual) que muestra el margen de precio
    /// pactado para un producto y cliente específicos: rango mínimo/máximo,
    /// promedio, estado (Activo/Inactivo) y período de vigencia.
    /// </summary>
    public partial class TARJETA_MARGEN : UserControl
    {
        /// <summary>
        /// Constructor: inicializa los controles visuales de la tarjeta.
        /// Los datos se asignan posteriormente con <see cref="AsignarDatos"/>.
        /// </summary>
        public TARJETA_MARGEN()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento Load del control. No requiere lógica adicional: los datos
        /// se inyectan explícitamente desde <see cref="Margenes.CargarMargenesDesdeTXT"/>
        /// a través de <see cref="AsignarDatos"/>.
        /// </summary>
        private void TARJETA_MARGEN_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Llena todos los controles visuales de la tarjeta con los datos
        /// de un margen leído desde el archivo TXT.
        /// </summary>
        /// <param name="producto">Nombre del producto al que aplica el margen.</param>
        /// <param name="cliente">Cliente para el cual se pactó el margen.</param>
        /// <param name="minimo">Margen mínimo permitido (ej. "18%").</param>
        /// <param name="maximo">Margen máximo permitido (ej. "32%").</param>
        /// <param name="promedio">Margen promedio histórico o sugerido (ej. "25%").</param>
        /// <param name="activo">
        /// Estado del margen tal como viene en el TXT: "Activo" o "Inactivo".
        /// Este campo se usa directamente para colorear <c>pnlEstado</c>;
        /// no se infiere a partir de la fecha de vigencia, para evitar
        /// inconsistencias si el campo y la fecha no coinciden.
        /// </param>
        /// <param name="vigenciaInicio">Fecha de inicio de vigencia del margen (texto, ej. "1/5/2026").</param>
        /// <param name="vigenciaFin">Fecha de fin de vigencia del margen (texto, ej. "31/12/2026").</param>
        public void AsignarDatos(string producto, string cliente, string minimo, string maximo,
                                  string promedio, string activo, string vigenciaInicio, string vigenciaFin)
        {
            lblProducto.Text = producto;
            lblCliente.Text = cliente;
            lblMinimo.Text = minimo;
            lblMaximo.Text = maximo;
            lblPromedio.Text = promedio;

            // El estado se toma directamente del campo "activo" del TXT
            // ("Activo"/"Inactivo"), igual que en Proveedores y Productos.
            // Se usa OrdinalIgnoreCase para tolerar variaciones de may/min.
            bool esActivo = activo.Equals("Activo", StringComparison.OrdinalIgnoreCase);

            if (esActivo)
            {
                lblEstado.Text = "ACTIVO";
                pnlEstado.BackColor = Color.LightGreen;
            }
            else
            {
                lblEstado.Text = "INACTIVO";
                pnlEstado.BackColor = Color.LightGray;
            }

            // El rango de vigencia se muestra como información adicional,
            // sin afectar el cálculo del estado.
            lblVigencia.Text = $"{vigenciaInicio} → {vigenciaFin}";
        }
    }
}