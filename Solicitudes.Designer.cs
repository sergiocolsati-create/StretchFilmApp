namespace StretchFilmApp
{
    partial class Solicitudes
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
            this.btnNuevaSolicitud = new System.Windows.Forms.Button();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.cmbEstadoFiltro = new System.Windows.Forms.ComboBox();
            this.lblEstadoFiltro = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCajas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCanal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCotizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlNueva = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstadoNuevo = new System.Windows.Forms.Label();
            this.cmbCanal = new System.Windows.Forms.ComboBox();
            this.lblCanal = new System.Windows.Forms.Label();
            this.numCajas = new System.Windows.Forms.NumericUpDown();
            this.lblCajas = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNuevaTitulo = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.pnlNueva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCajas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnNuevaSolicitud);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 48);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1084, 66);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnNuevaSolicitud
            // 
            this.btnNuevaSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnNuevaSolicitud.FlatAppearance.BorderSize = 0;
            this.btnNuevaSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaSolicitud.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevaSolicitud.ForeColor = System.Drawing.Color.White;
            this.btnNuevaSolicitud.Location = new System.Drawing.Point(924, 17);
            this.btnNuevaSolicitud.Name = "btnNuevaSolicitud";
            this.btnNuevaSolicitud.Size = new System.Drawing.Size(148, 32);
            this.btnNuevaSolicitud.TabIndex = 2;
            this.btnNuevaSolicitud.Text = "+ Nueva solicitud";
            this.btnNuevaSolicitud.UseVisualStyleBackColor = false;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 40);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(145, 15);
            this.lblSubtitulo.TabIndex = 0;
            this.lblSubtitulo.Text = "MS-01 · Pipeline de ventas";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTitulo.Location = new System.Drawing.Point(16, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(115, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Solicitudes";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.pnlFiltros.Controls.Add(this.cmbEstadoFiltro);
            this.pnlFiltros.Controls.Add(this.lblEstadoFiltro);
            this.pnlFiltros.Controls.Add(this.txtBuscar);
            this.pnlFiltros.Controls.Add(this.lblBuscar);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1084, 48);
            this.pnlFiltros.TabIndex = 1;
            // 
            // cmbEstadoFiltro
            // 
            this.cmbEstadoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoFiltro.Location = new System.Drawing.Point(366, 12);
            this.cmbEstadoFiltro.Name = "cmbEstadoFiltro";
            this.cmbEstadoFiltro.Size = new System.Drawing.Size(160, 23);
            this.cmbEstadoFiltro.TabIndex = 3;
            // 
            // lblEstadoFiltro
            // 
            this.lblEstadoFiltro.AutoSize = true;
            this.lblEstadoFiltro.Location = new System.Drawing.Point(308, 15);
            this.lblEstadoFiltro.Name = "lblEstadoFiltro";
            this.lblEstadoFiltro.Size = new System.Drawing.Size(45, 15);
            this.lblEstadoFiltro.TabIndex = 2;
            this.lblEstadoFiltro.Text = "Estado:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(72, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(220, 23);
            this.txtBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(18, 15);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(45, 15);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToDeleteRows = false;
            this.dgvSolicitudes.BackgroundColor = System.Drawing.Color.White;
            this.dgvSolicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCliente,
            this.colProducto,
            this.colCajas,
            this.colCanal,
            this.colEstado,
            this.colFecha,
            this.colCotizar,
            this.colEliminar});
            this.dgvSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSolicitudes.Location = new System.Drawing.Point(0, 0);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.Size = new System.Drawing.Size(1084, 661);
            this.dgvSolicitudes.TabIndex = 2;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.Width = 80;
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
            this.colProducto.FillWeight = 170F;
            this.colProducto.HeaderText = "PRODUCTO";
            this.colProducto.Name = "colProducto";
            // 
            // colCajas
            // 
            this.colCajas.HeaderText = "CAJAS";
            this.colCajas.Name = "colCajas";
            this.colCajas.Width = 60;
            // 
            // colCanal
            // 
            this.colCanal.HeaderText = "CANAL";
            this.colCanal.Name = "colCanal";
            this.colCanal.Width = 90;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "ESTADO";
            this.colEstado.Name = "colEstado";
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "FECHA";
            this.colFecha.Name = "colFecha";
            this.colFecha.Width = 90;
            // 
            // colCotizar
            // 
            this.colCotizar.HeaderText = "ACCIÓN";
            this.colCotizar.Name = "colCotizar";
            this.colCotizar.Text = "Cotizar";
            this.colCotizar.UseColumnTextForButtonValue = true;
            this.colCotizar.Width = 80;
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
            this.pnlNueva.Controls.Add(this.txtObservacion);
            this.pnlNueva.Controls.Add(this.lblObservacion);
            this.pnlNueva.Controls.Add(this.cmbEstado);
            this.pnlNueva.Controls.Add(this.lblEstadoNuevo);
            this.pnlNueva.Controls.Add(this.cmbCanal);
            this.pnlNueva.Controls.Add(this.lblCanal);
            this.pnlNueva.Controls.Add(this.numCajas);
            this.pnlNueva.Controls.Add(this.lblCajas);
            this.pnlNueva.Controls.Add(this.txtProducto);
            this.pnlNueva.Controls.Add(this.lblProducto);
            this.pnlNueva.Controls.Add(this.txtCliente);
            this.pnlNueva.Controls.Add(this.lblCliente);
            this.pnlNueva.Controls.Add(this.lblNuevaTitulo);
            this.pnlNueva.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNueva.Location = new System.Drawing.Point(0, 395);
            this.pnlNueva.Name = "pnlNueva";
            this.pnlNueva.Size = new System.Drawing.Size(1084, 266);
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
            // txtObservacion
            // 
            this.txtObservacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacion.Location = new System.Drawing.Point(100, 81);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(708, 23);
            this.txtObservacion.TabIndex = 6;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblObservacion.Location = new System.Drawing.Point(14, 84);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(73, 15);
            this.lblObservacion.TabIndex = 0;
            this.lblObservacion.Text = "Observación";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Location = new System.Drawing.Point(728, 54);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(150, 23);
            this.cmbEstado.TabIndex = 5;
            // 
            // lblEstadoNuevo
            // 
            this.lblEstadoNuevo.AutoSize = true;
            this.lblEstadoNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblEstadoNuevo.Location = new System.Drawing.Point(728, 36);
            this.lblEstadoNuevo.Name = "lblEstadoNuevo";
            this.lblEstadoNuevo.Size = new System.Drawing.Size(42, 15);
            this.lblEstadoNuevo.TabIndex = 0;
            this.lblEstadoNuevo.Text = "Estado";
            // 
            // cmbCanal
            // 
            this.cmbCanal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCanal.Location = new System.Drawing.Point(562, 54);
            this.cmbCanal.Name = "cmbCanal";
            this.cmbCanal.Size = new System.Drawing.Size(150, 23);
            this.cmbCanal.TabIndex = 4;
            // 
            // lblCanal
            // 
            this.lblCanal.AutoSize = true;
            this.lblCanal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCanal.Location = new System.Drawing.Point(562, 36);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(37, 15);
            this.lblCanal.TabIndex = 0;
            this.lblCanal.Text = "Canal";
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
            // lblNuevaTitulo
            // 
            this.lblNuevaTitulo.AutoSize = true;
            this.lblNuevaTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNuevaTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblNuevaTitulo.Location = new System.Drawing.Point(14, 8);
            this.lblNuevaTitulo.Name = "lblNuevaTitulo";
            this.lblNuevaTitulo.Size = new System.Drawing.Size(161, 17);
            this.lblNuevaTitulo.TabIndex = 0;
            this.lblNuevaTitulo.Text = "Registrar nueva solicitud";
            // 
            // Solicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.dgvSolicitudes);
            this.Controls.Add(this.pnlNueva);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 560);
            this.Name = "Solicitudes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitudes";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.pnlNueva.ResumeLayout(false);
            this.pnlNueva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCajas)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnNuevaSolicitud;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblEstadoFiltro;
        private System.Windows.Forms.ComboBox cmbEstadoFiltro;
        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCajas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCanal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewButtonColumn colCotizar;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
        private System.Windows.Forms.Panel pnlNueva;
        private System.Windows.Forms.Label lblNuevaTitulo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblCajas;
        private System.Windows.Forms.NumericUpDown numCajas;
        private System.Windows.Forms.Label lblCanal;
        private System.Windows.Forms.ComboBox cmbCanal;
        private System.Windows.Forms.Label lblEstadoNuevo;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}