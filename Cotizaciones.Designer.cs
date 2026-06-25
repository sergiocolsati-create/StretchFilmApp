namespace StretchFilmApp
{
    partial class Cotizaciones
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
            this.btnNuevaCotizacion = new System.Windows.Forms.Button();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.lblBanner = new System.Windows.Forms.Label();
            this.dgvCotizaciones = new System.Windows.Forms.DataGridView();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCajas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMargen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGanancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlNueva = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpVence = new System.Windows.Forms.DateTimePicker();
            this.lblVence = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstadoNuevo = new System.Windows.Forms.Label();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.numCajas = new System.Windows.Forms.NumericUpDown();
            this.lblCajas = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.numMargen = new System.Windows.Forms.NumericUpDown();
            this.lblMargen = new System.Windows.Forms.Label();
            this.lblGananciaPrevia = new System.Windows.Forms.Label();
            this.lblNuevaTitulo = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizaciones)).BeginInit();
            this.pnlNueva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCajas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMargen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnNuevaCotizacion);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 38);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1084, 61);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnNuevaCotizacion
            // 
            this.btnNuevaCotizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaCotizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnNuevaCotizacion.FlatAppearance.BorderSize = 0;
            this.btnNuevaCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCotizacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevaCotizacion.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCotizacion.Location = new System.Drawing.Point(912, 17);
            this.btnNuevaCotizacion.Name = "btnNuevaCotizacion";
            this.btnNuevaCotizacion.Size = new System.Drawing.Size(160, 32);
            this.btnNuevaCotizacion.TabIndex = 1;
            this.btnNuevaCotizacion.Text = "+ Nueva cotización";
            this.btnNuevaCotizacion.UseVisualStyleBackColor = false;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 40);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(227, 15);
            this.lblSubtitulo.TabIndex = 0;
            this.lblSubtitulo.Text = "MS-02 · Validación de margen automática";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTitulo.Location = new System.Drawing.Point(16, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(131, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cotizaciones";
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(231)))));
            this.pnlBanner.Controls.Add(this.lblBanner);
            this.pnlBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.pnlBanner.Size = new System.Drawing.Size(1084, 38);
            this.pnlBanner.TabIndex = 1;
            // 
            // lblBanner
            // 
            this.lblBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBanner.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblBanner.Location = new System.Drawing.Point(12, 0);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(1060, 38);
            this.lblBanner.TabIndex = 0;
            this.lblBanner.Text = "🛡  Protección de margen activa: los precios por debajo del mínimo configurado se" +
    " bloquean automáticamente.";
            this.lblBanner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvCotizaciones
            // 
            this.dgvCotizaciones.AllowUserToAddRows = false;
            this.dgvCotizaciones.AllowUserToDeleteRows = false;
            this.dgvCotizaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvCotizaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNum,
            this.colCliente,
            this.colProducto,
            this.colCajas,
            this.colPrecio,
            this.colMargen,
            this.colGanancia,
            this.colEstado,
            this.colVence,
            this.colVer,
            this.colEliminar});
            this.dgvCotizaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCotizaciones.Location = new System.Drawing.Point(0, 0);
            this.dgvCotizaciones.Name = "dgvCotizaciones";
            this.dgvCotizaciones.Size = new System.Drawing.Size(1084, 661);
            this.dgvCotizaciones.TabIndex = 2;
            // 
            // colNum
            // 
            this.colNum.HeaderText = "#";
            this.colNum.Name = "colNum";
            this.colNum.Width = 70;
            // 
            // colCliente
            // 
            this.colCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCliente.FillWeight = 130F;
            this.colCliente.HeaderText = "CLIENTE";
            this.colCliente.Name = "colCliente";
            // 
            // colProducto
            // 
            this.colProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProducto.FillWeight = 160F;
            this.colProducto.HeaderText = "PRODUCTO";
            this.colProducto.Name = "colProducto";
            // 
            // colCajas
            // 
            this.colCajas.HeaderText = "CAJAS";
            this.colCajas.Name = "colCajas";
            this.colCajas.Width = 60;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "PRECIO/CAJA";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Width = 95;
            // 
            // colMargen
            // 
            this.colMargen.HeaderText = "MARGEN";
            this.colMargen.Name = "colMargen";
            this.colMargen.Width = 75;
            // 
            // colGanancia
            // 
            this.colGanancia.HeaderText = "GANANCIA EST.";
            this.colGanancia.Name = "colGanancia";
            this.colGanancia.Width = 105;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "ESTADO";
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 95;
            // 
            // colVence
            // 
            this.colVence.HeaderText = "VENCE";
            this.colVence.Name = "colVence";
            this.colVence.Width = 90;
            // 
            // colVer
            // 
            this.colVer.HeaderText = "";
            this.colVer.Name = "colVer";
            this.colVer.Text = "Ver";
            this.colVer.UseColumnTextForButtonValue = true;
            this.colVer.Width = 60;
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Text = "X";
            this.colEliminar.UseColumnTextForButtonValue = true;
            this.colEliminar.Width = 40;
            // 
            // pnlNueva
            // 
            this.pnlNueva.BackColor = System.Drawing.Color.White;
            this.pnlNueva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNueva.Controls.Add(this.btnLimpiar);
            this.pnlNueva.Controls.Add(this.btnGuardar);
            this.pnlNueva.Controls.Add(this.dtpVence);
            this.pnlNueva.Controls.Add(this.lblVence);
            this.pnlNueva.Controls.Add(this.cmbEstado);
            this.pnlNueva.Controls.Add(this.lblEstadoNuevo);
            this.pnlNueva.Controls.Add(this.numPrecio);
            this.pnlNueva.Controls.Add(this.lblPrecio);
            this.pnlNueva.Controls.Add(this.numCajas);
            this.pnlNueva.Controls.Add(this.lblCajas);
            this.pnlNueva.Controls.Add(this.txtProducto);
            this.pnlNueva.Controls.Add(this.lblProducto);
            this.pnlNueva.Controls.Add(this.txtCliente);
            this.pnlNueva.Controls.Add(this.lblCliente);
            this.pnlNueva.Controls.Add(this.numMargen);
            this.pnlNueva.Controls.Add(this.lblMargen);
            this.pnlNueva.Controls.Add(this.lblGananciaPrevia);
            this.pnlNueva.Controls.Add(this.lblNuevaTitulo);
            this.pnlNueva.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNueva.Location = new System.Drawing.Point(0, 407);
            this.pnlNueva.Name = "pnlNueva";
            this.pnlNueva.Size = new System.Drawing.Size(1084, 254);
            this.pnlNueva.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(944, 79);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 28);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(824, 79);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 28);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // dtpVence
            // 
            this.dtpVence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVence.Location = new System.Drawing.Point(100, 81);
            this.dtpVence.Name = "dtpVence";
            this.dtpVence.Size = new System.Drawing.Size(160, 23);
            this.dtpVence.TabIndex = 6;
            // 
            // lblVence
            // 
            this.lblVence.AutoSize = true;
            this.lblVence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblVence.Location = new System.Drawing.Point(14, 84);
            this.lblVence.Name = "lblVence";
            this.lblVence.Size = new System.Drawing.Size(38, 15);
            this.lblVence.TabIndex = 0;
            this.lblVence.Text = "Vence";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Location = new System.Drawing.Point(784, 53);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(150, 23);
            this.cmbEstado.TabIndex = 5;
            // 
            // lblEstadoNuevo
            // 
            this.lblEstadoNuevo.AutoSize = true;
            this.lblEstadoNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblEstadoNuevo.Location = new System.Drawing.Point(790, 35);
            this.lblEstadoNuevo.Name = "lblEstadoNuevo";
            this.lblEstadoNuevo.Size = new System.Drawing.Size(42, 15);
            this.lblEstadoNuevo.TabIndex = 0;
            this.lblEstadoNuevo.Text = "Estado";
            // 
            // numPrecio
            // 
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Location = new System.Drawing.Point(562, 54);
            this.numPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(110, 23);
            this.numPrecio.TabIndex = 4;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblPrecio.Location = new System.Drawing.Point(562, 36);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(68, 15);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio/Caja";
            // 
            // numCajas
            // 
            this.numCajas.Location = new System.Drawing.Point(466, 54);
            this.numCajas.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCajas.Name = "numCajas";
            this.numCajas.Size = new System.Drawing.Size(80, 23);
            this.numCajas.TabIndex = 3;
            // 
            // lblCajas
            // 
            this.lblCajas.AutoSize = true;
            this.lblCajas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCajas.Location = new System.Drawing.Point(466, 36);
            this.lblCajas.Name = "lblCajas";
            this.lblCajas.Size = new System.Drawing.Size(35, 15);
            this.lblCajas.TabIndex = 0;
            this.lblCajas.Text = "Cajas";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(220, 54);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(230, 23);
            this.txtProducto.TabIndex = 2;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblProducto.Location = new System.Drawing.Point(220, 36);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(56, 15);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(14, 54);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(190, 23);
            this.txtCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCliente.Location = new System.Drawing.Point(14, 36);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 15);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // numMargen
            // 
            this.numMargen.DecimalPlaces = 1;
            this.numMargen.Location = new System.Drawing.Point(688, 54);
            this.numMargen.Name = "numMargen";
            this.numMargen.Size = new System.Drawing.Size(80, 23);
            this.numMargen.TabIndex = 5;
            // 
            // lblMargen
            // 
            this.lblMargen.AutoSize = true;
            this.lblMargen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblMargen.Location = new System.Drawing.Point(688, 36);
            this.lblMargen.Name = "lblMargen";
            this.lblMargen.Size = new System.Drawing.Size(61, 15);
            this.lblMargen.TabIndex = 0;
            this.lblMargen.Text = "Margen %";
            // 
            // lblGananciaPrevia
            // 
            this.lblGananciaPrevia.AutoSize = true;
            this.lblGananciaPrevia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGananciaPrevia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblGananciaPrevia.Location = new System.Drawing.Point(290, 86);
            this.lblGananciaPrevia.Name = "lblGananciaPrevia";
            this.lblGananciaPrevia.Size = new System.Drawing.Size(125, 15);
            this.lblGananciaPrevia.TabIndex = 9;
            this.lblGananciaPrevia.Text = "Ganancia est.: S/.0.00";
            // 
            // lblNuevaTitulo
            // 
            this.lblNuevaTitulo.AutoSize = true;
            this.lblNuevaTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNuevaTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblNuevaTitulo.Location = new System.Drawing.Point(14, 8);
            this.lblNuevaTitulo.Name = "lblNuevaTitulo";
            this.lblNuevaTitulo.Size = new System.Drawing.Size(170, 17);
            this.lblNuevaTitulo.TabIndex = 0;
            this.lblNuevaTitulo.Text = "Registrar nueva cotización";
            // 
            // Cotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.dgvCotizaciones);
            this.Controls.Add(this.pnlNueva);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBanner);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 560);
            this.Name = "Cotizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizaciones";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizaciones)).EndInit();
            this.pnlNueva.ResumeLayout(false);
            this.pnlNueva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCajas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMargen)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnNuevaCotizacion;
        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.DataGridView dgvCotizaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCajas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMargen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGanancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVence;
        private System.Windows.Forms.DataGridViewButtonColumn colVer;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
        private System.Windows.Forms.Panel pnlNueva;
        private System.Windows.Forms.Label lblNuevaTitulo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.NumericUpDown numMargen;
        private System.Windows.Forms.Label lblGananciaPrevia;
        private System.Windows.Forms.Label lblMargen;
        private System.Windows.Forms.Label lblCajas;
        private System.Windows.Forms.NumericUpDown numCajas;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Label lblEstadoNuevo;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblVence;
        private System.Windows.Forms.DateTimePicker dtpVence;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}
