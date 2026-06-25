namespace StretchFilmApp
{
    partial class Clientes
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
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.cmbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlPendientesContenedor = new System.Windows.Forms.Panel();
            this.lblPendientesTitulo = new System.Windows.Forms.Label();
            this.pnlPendientes = new System.Windows.Forms.Panel();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSolicitudes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlNuevo = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbEstadoNuevo = new System.Windows.Forms.ComboBox();
            this.lblEstadoNuevo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.lblRuc = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblNuevoTitulo = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlPendientesContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pnlNuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnNuevoCliente);
            this.pnlHeader.Controls.Add(this.btnRefrescar);
            this.pnlHeader.Controls.Add(this.cmbFiltroEstado);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1190, 66);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnNuevoCliente.FlatAppearance.BorderSize = 0;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCliente.Location = new System.Drawing.Point(1024, 17);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(150, 32);
            this.btnNuevoCliente.TabIndex = 4;
            this.btnNuevoCliente.Text = "+ Nuevo cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrescar.BackColor = System.Drawing.Color.White;
            this.btnRefrescar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefrescar.Location = new System.Drawing.Point(980, 17);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(36, 32);
            this.btnRefrescar.TabIndex = 3;
            this.btnRefrescar.Text = "⟳";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            // 
            // cmbFiltroEstado
            // 
            this.cmbFiltroEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroEstado.Location = new System.Drawing.Point(870, 18);
            this.cmbFiltroEstado.Name = "cmbFiltroEstado";
            this.cmbFiltroEstado.Size = new System.Drawing.Size(100, 23);
            this.cmbFiltroEstado.TabIndex = 2;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 40);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(62, 15);
            this.lblSubtitulo.TabIndex = 0;
            this.lblSubtitulo.Text = "12 clientes";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTitulo.Location = new System.Drawing.Point(16, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(199, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Clientes registrados";
            // 
            // pnlPendientesContenedor
            // 
            this.pnlPendientesContenedor.AutoScroll = true;
            this.pnlPendientesContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.pnlPendientesContenedor.Controls.Add(this.lblPendientesTitulo);
            this.pnlPendientesContenedor.Controls.Add(this.pnlPendientes);
            this.pnlPendientesContenedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPendientesContenedor.Location = new System.Drawing.Point(0, 66);
            this.pnlPendientesContenedor.Name = "pnlPendientesContenedor";
            this.pnlPendientesContenedor.Padding = new System.Windows.Forms.Padding(16, 12, 16, 4);
            this.pnlPendientesContenedor.Size = new System.Drawing.Size(1190, 160);
            this.pnlPendientesContenedor.TabIndex = 1;
            // 
            // lblPendientesTitulo
            // 
            this.lblPendientesTitulo.AutoSize = true;
            this.lblPendientesTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPendientesTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.lblPendientesTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblPendientesTitulo.Name = "lblPendientesTitulo";
            this.lblPendientesTitulo.Size = new System.Drawing.Size(142, 13);
            this.lblPendientesTitulo.TabIndex = 0;
            this.lblPendientesTitulo.Text = "REQUIEREN APROBACIÓN";
            // 
            // pnlPendientes
            // 
            this.pnlPendientes.Location = new System.Drawing.Point(16, 32);
            this.pnlPendientes.Name = "pnlPendientes";
            this.pnlPendientes.Size = new System.Drawing.Size(1150, 120);
            this.pnlPendientes.TabIndex = 1;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmpresa,
            this.colRuc,
            this.colTipo,
            this.colEstadoTabla,
            this.colSolicitudes,
            this.colContacto});
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(0, 226);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(1190, 233);
            this.dgvClientes.TabIndex = 2;
            // 
            // colEmpresa
            // 
            this.colEmpresa.HeaderText = "EMPRESA";
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.Width = 260;
            // 
            // colRuc
            // 
            this.colRuc.HeaderText = "RUC";
            this.colRuc.Name = "colRuc";
            this.colRuc.Width = 130;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "TIPO";
            this.colTipo.Name = "colTipo";
            this.colTipo.Width = 90;
            // 
            // colEstadoTabla
            // 
            this.colEstadoTabla.HeaderText = "ESTADO";
            this.colEstadoTabla.Name = "colEstadoTabla";
            this.colEstadoTabla.Width = 90;
            // 
            // colSolicitudes
            // 
            this.colSolicitudes.HeaderText = "SOLICITUDES";
            this.colSolicitudes.Name = "colSolicitudes";
            this.colSolicitudes.Width = 90;
            // 
            // colContacto
            // 
            this.colContacto.HeaderText = "CONTACTO";
            this.colContacto.Name = "colContacto";
            this.colContacto.Width = 130;
            // 
            // pnlNuevo
            // 
            this.pnlNuevo.BackColor = System.Drawing.Color.White;
            this.pnlNuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNuevo.Controls.Add(this.btnLimpiar);
            this.pnlNuevo.Controls.Add(this.btnGuardar);
            this.pnlNuevo.Controls.Add(this.cmbEstadoNuevo);
            this.pnlNuevo.Controls.Add(this.lblEstadoNuevo);
            this.pnlNuevo.Controls.Add(this.cmbTipo);
            this.pnlNuevo.Controls.Add(this.lblTipo);
            this.pnlNuevo.Controls.Add(this.txtContacto);
            this.pnlNuevo.Controls.Add(this.lblContacto);
            this.pnlNuevo.Controls.Add(this.txtRuc);
            this.pnlNuevo.Controls.Add(this.lblRuc);
            this.pnlNuevo.Controls.Add(this.txtEmpresa);
            this.pnlNuevo.Controls.Add(this.lblEmpresa);
            this.pnlNuevo.Controls.Add(this.lblNuevoTitulo);
            this.pnlNuevo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNuevo.Location = new System.Drawing.Point(0, 459);
            this.pnlNuevo.Name = "pnlNuevo";
            this.pnlNuevo.Size = new System.Drawing.Size(1190, 197);
            this.pnlNuevo.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(614, 145);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 28);
            this.btnLimpiar.TabIndex = 6;
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
            this.btnGuardar.Location = new System.Drawing.Point(462, 145);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 28);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // cmbEstadoNuevo
            // 
            this.cmbEstadoNuevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoNuevo.Location = new System.Drawing.Point(462, 107);
            this.cmbEstadoNuevo.Name = "cmbEstadoNuevo";
            this.cmbEstadoNuevo.Size = new System.Drawing.Size(150, 23);
            this.cmbEstadoNuevo.TabIndex = 4;
            // 
            // lblEstadoNuevo
            // 
            this.lblEstadoNuevo.AutoSize = true;
            this.lblEstadoNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblEstadoNuevo.Location = new System.Drawing.Point(459, 89);
            this.lblEstadoNuevo.Name = "lblEstadoNuevo";
            this.lblEstadoNuevo.Size = new System.Drawing.Size(42, 15);
            this.lblEstadoNuevo.TabIndex = 0;
            this.lblEstadoNuevo.Text = "Estado";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Location = new System.Drawing.Point(294, 107);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(120, 23);
            this.cmbTipo.TabIndex = 3;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTipo.Location = new System.Drawing.Point(291, 89);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(61, 15);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo pago";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(17, 107);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(256, 23);
            this.txtContacto.TabIndex = 2;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblContacto.Location = new System.Drawing.Point(14, 89);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(111, 15);
            this.lblContacto.TabIndex = 0;
            this.lblContacto.Text = "Contacto (teléfono)";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(294, 54);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(180, 23);
            this.txtRuc.TabIndex = 1;
            // 
            // lblRuc
            // 
            this.lblRuc.AutoSize = true;
            this.lblRuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblRuc.Location = new System.Drawing.Point(291, 36);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Size = new System.Drawing.Size(30, 15);
            this.lblRuc.TabIndex = 0;
            this.lblRuc.Text = "RUC";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(14, 54);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(259, 23);
            this.txtEmpresa.TabIndex = 0;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblEmpresa.Location = new System.Drawing.Point(14, 36);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(52, 15);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Empresa";
            // 
            // lblNuevoTitulo
            // 
            this.lblNuevoTitulo.AutoSize = true;
            this.lblNuevoTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNuevoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblNuevoTitulo.Location = new System.Drawing.Point(14, 8);
            this.lblNuevoTitulo.Name = "lblNuevoTitulo";
            this.lblNuevoTitulo.Size = new System.Drawing.Size(150, 17);
            this.lblNuevoTitulo.TabIndex = 0;
            this.lblNuevoTitulo.Text = "Registrar nuevo cliente";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1190, 656);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.pnlNuevo);
            this.Controls.Add(this.pnlPendientesContenedor);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 560);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes registrados";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlPendientesContenedor.ResumeLayout(false);
            this.pnlPendientesContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.pnlNuevo.ResumeLayout(false);
            this.pnlNuevo.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.ComboBox cmbFiltroEstado;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Panel pnlPendientesContenedor;
        private System.Windows.Forms.Label lblPendientesTitulo;
        private System.Windows.Forms.Panel pnlPendientes;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolicitudes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContacto;
        private System.Windows.Forms.Panel pnlNuevo;
        private System.Windows.Forms.Label lblNuevoTitulo;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label lblRuc;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblEstadoNuevo;
        private System.Windows.Forms.ComboBox cmbEstadoNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}