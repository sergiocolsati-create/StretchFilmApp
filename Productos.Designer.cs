namespace StretchFilmApp
{
    partial class Productos
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
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.pnlCardStock = new System.Windows.Forms.Panel();
            this.lblStockTotal = new System.Windows.Forms.Label();
            this.lblCardStock = new System.Windows.Forms.Label();
            this.pnlCardActivos = new System.Windows.Forms.Panel();
            this.lblActivos = new System.Windows.Forms.Label();
            this.lblCardActivos = new System.Windows.Forms.Label();
            this.pnlCardTotal = new System.Windows.Forms.Panel();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.lblCardTotal = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlNuevo = new System.Windows.Forms.Panel();
            this.lblNombreImagen = new System.Windows.Forms.Label();
            this.btnSeleccionarImagen = new System.Windows.Forms.Button();
            this.lblImagen = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNuevoTitulo = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlResumen.SuspendLayout();
            this.pnlCardStock.SuspendLayout();
            this.pnlCardActivos.SuspendLayout();
            this.pnlCardTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnlNuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnNuevoProducto);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1084, 66);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnNuevoProducto.FlatAppearance.BorderSize = 0;
            this.btnNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevoProducto.ForeColor = System.Drawing.Color.White;
            this.btnNuevoProducto.Location = new System.Drawing.Point(924, 17);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(148, 32);
            this.btnNuevoProducto.TabIndex = 2;
            this.btnNuevoProducto.Text = "+ Nuevo producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = false;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 40);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(125, 15);
            this.lblSubtitulo.TabIndex = 0;
            this.lblSubtitulo.Text = "4 productos · 4 activos";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTitulo.Location = new System.Drawing.Point(16, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(107, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Productos";
            // 
            // pnlResumen
            // 
            this.pnlResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.pnlResumen.Controls.Add(this.pnlCardStock);
            this.pnlResumen.Controls.Add(this.pnlCardActivos);
            this.pnlResumen.Controls.Add(this.pnlCardTotal);
            this.pnlResumen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlResumen.Location = new System.Drawing.Point(0, 66);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.pnlResumen.Size = new System.Drawing.Size(1084, 92);
            this.pnlResumen.TabIndex = 1;
            // 
            // pnlCardStock
            // 
            this.pnlCardStock.BackColor = System.Drawing.Color.White;
            this.pnlCardStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardStock.Controls.Add(this.lblStockTotal);
            this.pnlCardStock.Controls.Add(this.lblCardStock);
            this.pnlCardStock.Location = new System.Drawing.Point(706, 12);
            this.pnlCardStock.Name = "pnlCardStock";
            this.pnlCardStock.Size = new System.Drawing.Size(346, 68);
            this.pnlCardStock.TabIndex = 2;
            // 
            // lblStockTotal
            // 
            this.lblStockTotal.AutoSize = true;
            this.lblStockTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblStockTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblStockTotal.Location = new System.Drawing.Point(16, 32);
            this.lblStockTotal.Name = "lblStockTotal";
            this.lblStockTotal.Size = new System.Drawing.Size(23, 25);
            this.lblStockTotal.TabIndex = 0;
            this.lblStockTotal.Text = "0";
            // 
            // lblCardStock
            // 
            this.lblCardStock.AutoSize = true;
            this.lblCardStock.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.lblCardStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCardStock.Location = new System.Drawing.Point(16, 12);
            this.lblCardStock.Name = "lblCardStock";
            this.lblCardStock.Size = new System.Drawing.Size(112, 13);
            this.lblCardStock.TabIndex = 0;
            this.lblCardStock.Text = "STOCK TOTAL (CAJAS)";
            // 
            // pnlCardActivos
            // 
            this.pnlCardActivos.BackColor = System.Drawing.Color.White;
            this.pnlCardActivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardActivos.Controls.Add(this.lblActivos);
            this.pnlCardActivos.Controls.Add(this.lblCardActivos);
            this.pnlCardActivos.Location = new System.Drawing.Point(363, 12);
            this.pnlCardActivos.Name = "pnlCardActivos";
            this.pnlCardActivos.Size = new System.Drawing.Size(330, 68);
            this.pnlCardActivos.TabIndex = 1;
            // 
            // lblActivos
            // 
            this.lblActivos.AutoSize = true;
            this.lblActivos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblActivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblActivos.Location = new System.Drawing.Point(16, 32);
            this.lblActivos.Name = "lblActivos";
            this.lblActivos.Size = new System.Drawing.Size(23, 25);
            this.lblActivos.TabIndex = 0;
            this.lblActivos.Text = "0";
            // 
            // lblCardActivos
            // 
            this.lblCardActivos.AutoSize = true;
            this.lblCardActivos.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.lblCardActivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCardActivos.Location = new System.Drawing.Point(16, 12);
            this.lblCardActivos.Name = "lblCardActivos";
            this.lblCardActivos.Size = new System.Drawing.Size(51, 13);
            this.lblCardActivos.TabIndex = 0;
            this.lblCardActivos.Text = "ACTIVOS";
            // 
            // pnlCardTotal
            // 
            this.pnlCardTotal.BackColor = System.Drawing.Color.White;
            this.pnlCardTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardTotal.Controls.Add(this.lblTotalProductos);
            this.pnlCardTotal.Controls.Add(this.lblCardTotal);
            this.pnlCardTotal.Location = new System.Drawing.Point(20, 12);
            this.pnlCardTotal.Name = "pnlCardTotal";
            this.pnlCardTotal.Size = new System.Drawing.Size(330, 68);
            this.pnlCardTotal.TabIndex = 0;
            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.AutoSize = true;
            this.lblTotalProductos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTotalProductos.Location = new System.Drawing.Point(16, 32);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(23, 25);
            this.lblTotalProductos.TabIndex = 0;
            this.lblTotalProductos.Text = "0";
            // 
            // lblCardTotal
            // 
            this.lblCardTotal.AutoSize = true;
            this.lblCardTotal.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.lblCardTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCardTotal.Location = new System.Drawing.Point(16, 12);
            this.lblCardTotal.Name = "lblCardTotal";
            this.lblCardTotal.Size = new System.Drawing.Size(103, 13);
            this.lblCardTotal.TabIndex = 0;
            this.lblCardTotal.Text = "TOTAL PRODUCTOS";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colDescripcion,
            this.colProveedor,
            this.colPrecio,
            this.colStock,
            this.colEstado,
            this.colImagen});
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(0, 158);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(1084, 249);
            this.dgvProductos.TabIndex = 2;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "CÓDIGO";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 90;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "PRODUCTO";
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 220;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "DESCRIPCIÓN";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Width = 180;
            // 
            // colProveedor
            // 
            this.colProveedor.HeaderText = "PROVEEDOR";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.Width = 200;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "PRECIO";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Width = 80;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "STOCK";
            this.colStock.Name = "colStock";
            this.colStock.Width = 70;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "ESTADO";
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 90;
            // 
            // colImagen
            // 
            this.colImagen.HeaderText = "IMAGEN (doble clic)";
            this.colImagen.Name = "colImagen";
            this.colImagen.Width = 140;
            // 
            // pnlNuevo
            // 
            this.pnlNuevo.BackColor = System.Drawing.Color.White;
            this.pnlNuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNuevo.Controls.Add(this.lblNombreImagen);
            this.pnlNuevo.Controls.Add(this.btnSeleccionarImagen);
            this.pnlNuevo.Controls.Add(this.lblImagen);
            this.pnlNuevo.Controls.Add(this.btnLimpiar);
            this.pnlNuevo.Controls.Add(this.btnGuardar);
            this.pnlNuevo.Controls.Add(this.txtStock);
            this.pnlNuevo.Controls.Add(this.lblStock);
            this.pnlNuevo.Controls.Add(this.txtPrecio);
            this.pnlNuevo.Controls.Add(this.lblPrecio);
            this.pnlNuevo.Controls.Add(this.cmbEstado);
            this.pnlNuevo.Controls.Add(this.lblEstado);
            this.pnlNuevo.Controls.Add(this.txtProveedor);
            this.pnlNuevo.Controls.Add(this.lblProveedor);
            this.pnlNuevo.Controls.Add(this.txtDescripcion);
            this.pnlNuevo.Controls.Add(this.lblDescripcion);
            this.pnlNuevo.Controls.Add(this.txtNombre);
            this.pnlNuevo.Controls.Add(this.lblNombre);
            this.pnlNuevo.Controls.Add(this.txtCodigo);
            this.pnlNuevo.Controls.Add(this.lblCodigo);
            this.pnlNuevo.Controls.Add(this.lblNuevoTitulo);
            this.pnlNuevo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNuevo.Location = new System.Drawing.Point(0, 407);
            this.pnlNuevo.Name = "pnlNuevo";
            this.pnlNuevo.Size = new System.Drawing.Size(1084, 254);
            this.pnlNuevo.TabIndex = 3;
            // 
            // lblNombreImagen
            // 
            this.lblNombreImagen.AutoSize = true;
            this.lblNombreImagen.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNombreImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblNombreImagen.Location = new System.Drawing.Point(700, 92);
            this.lblNombreImagen.Name = "lblNombreImagen";
            this.lblNombreImagen.Size = new System.Drawing.Size(133, 13);
            this.lblNombreImagen.TabIndex = 0;
            this.lblNombreImagen.Text = "Sin imagen seleccionada";
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.BackColor = System.Drawing.Color.White;
            this.btnSeleccionarImagen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnSeleccionarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(700, 54);
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(160, 28);
            this.btnSeleccionarImagen.TabIndex = 7;
            this.btnSeleccionarImagen.Text = "📷 Seleccionar imagen";
            this.btnSeleccionarImagen.UseVisualStyleBackColor = false;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblImagen.Location = new System.Drawing.Point(697, 36);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(47, 15);
            this.lblImagen.TabIndex = 0;
            this.lblImagen.Text = "Imagen";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(532, 198);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 28);
            this.btnLimpiar.TabIndex = 9;
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
            this.btnGuardar.Location = new System.Drawing.Point(382, 198);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 28);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(462, 107);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(180, 23);
            this.txtStock.TabIndex = 6;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblStock.Location = new System.Drawing.Point(459, 89);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(73, 15);
            this.lblStock.TabIndex = 0;
            this.lblStock.Text = "Stock (cajas)";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(294, 107);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(120, 23);
            this.txtPrecio.TabIndex = 5;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblPrecio.Location = new System.Drawing.Point(291, 89);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Location = new System.Drawing.Point(17, 150);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(150, 23);
            this.cmbEstado.TabIndex = 7;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblEstado.Location = new System.Drawing.Point(14, 132);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(42, 15);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Estado";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(17, 107);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(256, 23);
            this.txtProveedor.TabIndex = 4;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblProveedor.Location = new System.Drawing.Point(14, 89);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(61, 15);
            this.lblProveedor.TabIndex = 0;
            this.lblProveedor.Text = "Proveedor";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(462, 54);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(180, 23);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblDescripcion.Location = new System.Drawing.Point(459, 36);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 15);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(294, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblNombre.Location = new System.Drawing.Point(291, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(103, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre producto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(17, 54);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(259, 23);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCodigo.Location = new System.Drawing.Point(14, 36);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblNuevoTitulo
            // 
            this.lblNuevoTitulo.AutoSize = true;
            this.lblNuevoTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNuevoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblNuevoTitulo.Location = new System.Drawing.Point(14, 8);
            this.lblNuevoTitulo.Name = "lblNuevoTitulo";
            this.lblNuevoTitulo.Size = new System.Drawing.Size(165, 17);
            this.lblNuevoTitulo.TabIndex = 0;
            this.lblNuevoTitulo.Text = "Registrar nuevo producto";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.pnlNuevo);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 560);
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlResumen.ResumeLayout(false);
            this.pnlCardStock.ResumeLayout(false);
            this.pnlCardStock.PerformLayout();
            this.pnlCardActivos.ResumeLayout(false);
            this.pnlCardActivos.PerformLayout();
            this.pnlCardTotal.ResumeLayout(false);
            this.pnlCardTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pnlNuevo.ResumeLayout(false);
            this.pnlNuevo.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.Panel pnlCardTotal;
        private System.Windows.Forms.Label lblCardTotal;
        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.Panel pnlCardActivos;
        private System.Windows.Forms.Label lblCardActivos;
        private System.Windows.Forms.Label lblActivos;
        private System.Windows.Forms.Panel pnlCardStock;
        private System.Windows.Forms.Label lblCardStock;
        private System.Windows.Forms.Label lblStockTotal;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImagen;
        private System.Windows.Forms.Panel pnlNuevo;
        private System.Windows.Forms.Label lblNuevoTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Button btnSeleccionarImagen;
        private System.Windows.Forms.Label lblNombreImagen;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}