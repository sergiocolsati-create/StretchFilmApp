namespace StretchFilmApp
{
    partial class Adquisicion
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
            this.btnNuevaOrden = new System.Windows.Forms.Button();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlFiltrosContenedor = new System.Windows.Forms.Panel();
            this.pnlFiltros = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLista = new System.Windows.Forms.Panel();
            this.pnlNueva = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNuevaTitulo = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlFiltrosContenedor.SuspendLayout();
            this.pnlNueva.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnNuevaOrden);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1084, 66);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnNuevaOrden
            // 
            this.btnNuevaOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnNuevaOrden.FlatAppearance.BorderSize = 0;
            this.btnNuevaOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaOrden.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevaOrden.ForeColor = System.Drawing.Color.White;
            this.btnNuevaOrden.Location = new System.Drawing.Point(924, 17);
            this.btnNuevaOrden.Name = "btnNuevaOrden";
            this.btnNuevaOrden.Size = new System.Drawing.Size(148, 32);
            this.btnNuevaOrden.TabIndex = 2;
            this.btnNuevaOrden.Text = "+ Nueva orden";
            this.btnNuevaOrden.UseVisualStyleBackColor = false;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 40);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(328, 15);
            this.lblSubtitulo.TabIndex = 0;
            this.lblSubtitulo.Text = "Órdenes de compra generadas desde cotizaciones aprobadas";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTitulo.Location = new System.Drawing.Point(16, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(123, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Adquisición";
            // 
            // pnlFiltrosContenedor
            // 
            this.pnlFiltrosContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.pnlFiltrosContenedor.Controls.Add(this.pnlFiltros);
            this.pnlFiltrosContenedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltrosContenedor.Location = new System.Drawing.Point(0, 66);
            this.pnlFiltrosContenedor.Name = "pnlFiltrosContenedor";
            this.pnlFiltrosContenedor.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnlFiltrosContenedor.Size = new System.Drawing.Size(1084, 50);
            this.pnlFiltrosContenedor.TabIndex = 1;
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.AutoSize = true;
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFiltros.Location = new System.Drawing.Point(16, 10);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(0, 30);
            this.pnlFiltros.TabIndex = 0;
            this.pnlFiltros.WrapContents = false;
            // 
            // pnlLista
            // 
            this.pnlLista.AutoScroll = true;
            this.pnlLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.pnlLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLista.Location = new System.Drawing.Point(0, 116);
            this.pnlLista.Name = "pnlLista";
            this.pnlLista.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnlLista.Size = new System.Drawing.Size(1084, 287);
            this.pnlLista.TabIndex = 2;
            // 
            // pnlNueva
            // 
            this.pnlNueva.BackColor = System.Drawing.Color.White;
            this.pnlNueva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNueva.Controls.Add(this.btnLimpiar);
            this.pnlNueva.Controls.Add(this.btnGuardar);
            this.pnlNueva.Controls.Add(this.cmbEstado);
            this.pnlNueva.Controls.Add(this.lblEstado);
            this.pnlNueva.Controls.Add(this.txtMonto);
            this.pnlNueva.Controls.Add(this.lblMonto);
            this.pnlNueva.Controls.Add(this.txtProveedor);
            this.pnlNueva.Controls.Add(this.lblProveedor);
            this.pnlNueva.Controls.Add(this.txtCliente);
            this.pnlNueva.Controls.Add(this.lblCliente);
            this.pnlNueva.Controls.Add(this.lblNuevaTitulo);
            this.pnlNueva.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNueva.Location = new System.Drawing.Point(0, 403);
            this.pnlNueva.Name = "pnlNueva";
            this.pnlNueva.Size = new System.Drawing.Size(1084, 175);
            this.pnlNueva.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(534, 118);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 28);
            this.btnLimpiar.TabIndex = 5;
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
            this.btnGuardar.Location = new System.Drawing.Point(377, 118);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 28);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Location = new System.Drawing.Point(770, 54);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(180, 23);
            this.cmbEstado.TabIndex = 4;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblEstado.Location = new System.Drawing.Point(767, 36);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(42, 15);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Estado";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(294, 54);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(120, 23);
            this.txtMonto.TabIndex = 3;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblMonto.Location = new System.Drawing.Point(291, 36);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(43, 15);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "Monto";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(450, 54);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(259, 23);
            this.txtProveedor.TabIndex = 2;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblProveedor.Location = new System.Drawing.Point(447, 36);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(61, 15);
            this.lblProveedor.TabIndex = 0;
            this.lblProveedor.Text = "Proveedor";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(14, 54);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(259, 23);
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
            this.lblNuevaTitulo.Size = new System.Drawing.Size(144, 17);
            this.lblNuevaTitulo.TabIndex = 0;
            this.lblNuevaTitulo.Text = "Registrar nueva orden";
            // 
            // Adquisicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1084, 578);
            this.Controls.Add(this.pnlLista);
            this.Controls.Add(this.pnlNueva);
            this.Controls.Add(this.pnlFiltrosContenedor);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 560);
            this.Name = "Adquisicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adquisición";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFiltrosContenedor.ResumeLayout(false);
            this.pnlFiltrosContenedor.PerformLayout();
            this.pnlNueva.ResumeLayout(false);
            this.pnlNueva.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnNuevaOrden;
        private System.Windows.Forms.Panel pnlFiltrosContenedor;
        private System.Windows.Forms.FlowLayoutPanel pnlFiltros;
        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.Panel pnlNueva;
        private System.Windows.Forms.Label lblNuevaTitulo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}