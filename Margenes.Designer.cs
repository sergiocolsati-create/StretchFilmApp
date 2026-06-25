namespace StretchFilmApp
{
    partial class Margenes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnNuevoMargen = new System.Windows.Forms.Button();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.flpMargenes = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlNueva = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.lblFin = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblInicio = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.numPromedio = new System.Windows.Forms.NumericUpDown();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.numMaximo = new System.Windows.Forms.NumericUpDown();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.numMinimo = new System.Windows.Forms.NumericUpDown();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblNuevaTitulo = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlNueva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPromedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimo)).BeginInit();
            this.SuspendLayout();
            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnNuevoMargen);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1084, 66);
            this.pnlHeader.TabIndex = 0;
            // btnNuevoMargen
            this.btnNuevoMargen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoMargen.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnNuevoMargen.FlatAppearance.BorderSize = 0;
            this.btnNuevoMargen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoMargen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevoMargen.ForeColor = System.Drawing.Color.White;
            this.btnNuevoMargen.Location = new System.Drawing.Point(924, 17);
            this.btnNuevoMargen.Name = "btnNuevoMargen";
            this.btnNuevoMargen.Size = new System.Drawing.Size(148, 32);
            this.btnNuevoMargen.TabIndex = 2;
            this.btnNuevoMargen.Text = "+ Nuevo margen";
            this.btnNuevoMargen.UseVisualStyleBackColor = false;
            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 40);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 0;
            this.lblSubtitulo.Text = "Protección de precios";
            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblTitulo.Location = new System.Drawing.Point(16, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Márgenes";
            // flpMargenes
            this.flpMargenes.AutoScroll = true;
            this.flpMargenes.BackColor = System.Drawing.Color.FromArgb(247, 247, 244);
            this.flpMargenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMargenes.Name = "flpMargenes";
            this.flpMargenes.Padding = new System.Windows.Forms.Padding(12);
            this.flpMargenes.TabIndex = 1;
            // pnlNueva
            this.pnlNueva.BackColor = System.Drawing.Color.White;
            this.pnlNueva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNueva.Controls.Add(this.btnLimpiar);
            this.pnlNueva.Controls.Add(this.btnGuardar);
            this.pnlNueva.Controls.Add(this.dtpFin);
            this.pnlNueva.Controls.Add(this.lblFin);
            this.pnlNueva.Controls.Add(this.dtpInicio);
            this.pnlNueva.Controls.Add(this.lblInicio);
            this.pnlNueva.Controls.Add(this.cmbEstado);
            this.pnlNueva.Controls.Add(this.lblEstado);
            this.pnlNueva.Controls.Add(this.numPromedio);
            this.pnlNueva.Controls.Add(this.lblPromedio);
            this.pnlNueva.Controls.Add(this.numMaximo);
            this.pnlNueva.Controls.Add(this.lblMaximo);
            this.pnlNueva.Controls.Add(this.numMinimo);
            this.pnlNueva.Controls.Add(this.lblMinimo);
            this.pnlNueva.Controls.Add(this.txtCliente);
            this.pnlNueva.Controls.Add(this.lblCliente);
            this.pnlNueva.Controls.Add(this.txtProducto);
            this.pnlNueva.Controls.Add(this.lblProducto);
            this.pnlNueva.Controls.Add(this.lblNuevaTitulo);
            this.pnlNueva.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNueva.Name = "pnlNueva";
            this.pnlNueva.Size = new System.Drawing.Size(1084, 126);
            this.pnlNueva.TabIndex = 2;
            // lblNuevaTitulo
            this.lblNuevaTitulo.AutoSize = true;
            this.lblNuevaTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNuevaTitulo.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblNuevaTitulo.Location = new System.Drawing.Point(14, 8);
            this.lblNuevaTitulo.Name = "lblNuevaTitulo";
            this.lblNuevaTitulo.TabIndex = 0;
            this.lblNuevaTitulo.Text = "Registrar nuevo margen";
            // lblProducto
            this.lblProducto.AutoSize = true;
            this.lblProducto.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblProducto.Location = new System.Drawing.Point(14, 36);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto";
            // txtProducto
            this.txtProducto.Location = new System.Drawing.Point(14, 54);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(200, 23);
            this.txtProducto.TabIndex = 1;
            // lblCliente
            this.lblCliente.AutoSize = true;
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblCliente.Location = new System.Drawing.Point(230, 36);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // txtCliente
            this.txtCliente.Location = new System.Drawing.Point(230, 54);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(180, 23);
            this.txtCliente.TabIndex = 2;
            // lblMinimo
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblMinimo.Location = new System.Drawing.Point(426, 36);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.TabIndex = 0;
            this.lblMinimo.Text = "Mínimo %";
            // numMinimo
            this.numMinimo.Location = new System.Drawing.Point(426, 54);
            this.numMinimo.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numMinimo.Name = "numMinimo";
            this.numMinimo.Size = new System.Drawing.Size(70, 23);
            this.numMinimo.TabIndex = 3;
            // lblMaximo
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblMaximo.Location = new System.Drawing.Point(512, 36);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.TabIndex = 0;
            this.lblMaximo.Text = "Máximo %";
            // numMaximo
            this.numMaximo.Location = new System.Drawing.Point(512, 54);
            this.numMaximo.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numMaximo.Name = "numMaximo";
            this.numMaximo.Size = new System.Drawing.Size(70, 23);
            this.numMaximo.TabIndex = 4;
            // lblPromedio
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblPromedio.Location = new System.Drawing.Point(598, 36);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.TabIndex = 0;
            this.lblPromedio.Text = "Promedio %";
            // numPromedio
            this.numPromedio.Location = new System.Drawing.Point(598, 54);
            this.numPromedio.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numPromedio.Name = "numPromedio";
            this.numPromedio.Size = new System.Drawing.Size(70, 23);
            this.numPromedio.TabIndex = 5;
            // lblEstado
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblEstado.Location = new System.Drawing.Point(684, 36);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Estado";
            // cmbEstado
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Location = new System.Drawing.Point(684, 54);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(110, 23);
            this.cmbEstado.TabIndex = 6;
            // lblInicio
            this.lblInicio.AutoSize = true;
            this.lblInicio.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblInicio.Location = new System.Drawing.Point(14, 84);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Vigencia inicio";
            // dtpInicio
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(100, 81);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(130, 23);
            this.dtpInicio.TabIndex = 7;
            // lblFin
            this.lblFin.AutoSize = true;
            this.lblFin.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblFin.Location = new System.Drawing.Point(246, 84);
            this.lblFin.Name = "lblFin";
            this.lblFin.TabIndex = 0;
            this.lblFin.Text = "Vigencia fin";
            // dtpFin
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(326, 81);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(130, 23);
            this.dtpFin.TabIndex = 8;
            // btnGuardar
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(824, 79);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 28);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // btnLimpiar
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(944, 79);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 28);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // Margenes
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(247, 247, 244);
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.flpMargenes);
            this.Controls.Add(this.pnlNueva);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 560);
            this.Name = "Margenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Márgenes";
            this.Load += new System.EventHandler(this.Margenes_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlNueva.ResumeLayout(false);
            this.pnlNueva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPromedio)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnNuevoMargen;
        private System.Windows.Forms.FlowLayoutPanel flpMargenes;
        private System.Windows.Forms.Panel pnlNueva;
        private System.Windows.Forms.Label lblNuevaTitulo;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.NumericUpDown numMinimo;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.NumericUpDown numMaximo;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.NumericUpDown numPromedio;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}