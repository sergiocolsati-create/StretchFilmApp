namespace StretchFilmApp
{
    partial class Usuarios
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
            this.btnNuevaVendedora = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.lblSeccionVendedoras = new System.Windows.Forms.Label();
            this.pnlVendedorasHeader = new System.Windows.Forms.Panel();
            this.lblColNombreV = new System.Windows.Forms.Label();
            this.lblColEmailV = new System.Windows.Forms.Label();
            this.lblColEstadoV = new System.Windows.Forms.Label();
            this.lblColSolicitudes = new System.Windows.Forms.Label();
            this.lblColUltimoAcceso = new System.Windows.Forms.Label();
            this.lblColContrasenaV = new System.Windows.Forms.Label();
            this.pnlVendedoras = new System.Windows.Forms.Panel();
            this.pnlSeccionAdmins = new System.Windows.Forms.Panel();
            this.btnNuevoAdmin = new System.Windows.Forms.Button();
            this.lblSeccionAdmins = new System.Windows.Forms.Label();
            this.pnlAdminsHeader = new System.Windows.Forms.Panel();
            this.lblColNombreA = new System.Windows.Forms.Label();
            this.lblColEmailA = new System.Windows.Forms.Label();
            this.lblColEstadoA = new System.Windows.Forms.Label();
            this.lblColContrasenaA = new System.Windows.Forms.Label();
            this.pnlAdmins = new System.Windows.Forms.Panel();
            this.pnlNueva = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbEstadoNuevo = new System.Windows.Forms.ComboBox();
            this.lblEstadoNuevo = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContrasenaNueva = new System.Windows.Forms.Label();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNuevaTitulo = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlVendedorasHeader.SuspendLayout();
            this.pnlSeccionAdmins.SuspendLayout();
            this.pnlAdminsHeader.SuspendLayout();
            this.pnlNueva.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnNuevaVendedora);
            this.pnlHeader.Controls.Add(this.btnRefrescar);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1190, 66);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnNuevaVendedora
            // 
            this.btnNuevaVendedora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaVendedora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnNuevaVendedora.FlatAppearance.BorderSize = 0;
            this.btnNuevaVendedora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaVendedora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevaVendedora.ForeColor = System.Drawing.Color.White;
            this.btnNuevaVendedora.Location = new System.Drawing.Point(1014, 17);
            this.btnNuevaVendedora.Name = "btnNuevaVendedora";
            this.btnNuevaVendedora.Size = new System.Drawing.Size(160, 32);
            this.btnNuevaVendedora.TabIndex = 3;
            this.btnNuevaVendedora.Text = "👤 Nueva vendedora";
            this.btnNuevaVendedora.UseVisualStyleBackColor = false;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrescar.BackColor = System.Drawing.Color.White;
            this.btnRefrescar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefrescar.Location = new System.Drawing.Point(970, 17);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(36, 32);
            this.btnRefrescar.TabIndex = 2;
            this.btnRefrescar.Text = "⟳";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 40);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(129, 15);
            this.lblSubtitulo.TabIndex = 0;
            this.lblSubtitulo.Text = "6 vendedoras · 1 admin";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTitulo.Location = new System.Drawing.Point(16, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(206, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Usuarios del sistema";
            // 
            // pnlContenido
            // 
            this.pnlContenido.AutoScroll = true;
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.pnlContenido.Controls.Add(this.lblSeccionVendedoras);
            this.pnlContenido.Controls.Add(this.pnlVendedorasHeader);
            this.pnlContenido.Controls.Add(this.pnlVendedoras);
            this.pnlContenido.Controls.Add(this.pnlSeccionAdmins);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 66);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(16, 14, 16, 14);
            this.pnlContenido.Size = new System.Drawing.Size(1190, 282);
            this.pnlContenido.TabIndex = 1;
            // 
            // lblSeccionVendedoras
            // 
            this.lblSeccionVendedoras.AutoSize = true;
            this.lblSeccionVendedoras.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSeccionVendedoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSeccionVendedoras.Location = new System.Drawing.Point(20, 14);
            this.lblSeccionVendedoras.Name = "lblSeccionVendedoras";
            this.lblSeccionVendedoras.Size = new System.Drawing.Size(80, 13);
            this.lblSeccionVendedoras.TabIndex = 0;
            this.lblSeccionVendedoras.Text = "VENDEDORAS";
            // 
            // pnlVendedorasHeader
            // 
            this.pnlVendedorasHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pnlVendedorasHeader.Controls.Add(this.lblColNombreV);
            this.pnlVendedorasHeader.Controls.Add(this.lblColEmailV);
            this.pnlVendedorasHeader.Controls.Add(this.lblColEstadoV);
            this.pnlVendedorasHeader.Controls.Add(this.lblColSolicitudes);
            this.pnlVendedorasHeader.Controls.Add(this.lblColUltimoAcceso);
            this.pnlVendedorasHeader.Controls.Add(this.lblColContrasenaV);
            this.pnlVendedorasHeader.Location = new System.Drawing.Point(20, 36);
            this.pnlVendedorasHeader.Name = "pnlVendedorasHeader";
            this.pnlVendedorasHeader.Size = new System.Drawing.Size(1150, 30);
            this.pnlVendedorasHeader.TabIndex = 1;
            // 
            // lblColNombreV
            // 
            this.lblColNombreV.AutoSize = true;
            this.lblColNombreV.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Bold);
            this.lblColNombreV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblColNombreV.Location = new System.Drawing.Point(8, 8);
            this.lblColNombreV.Name = "lblColNombreV";
            this.lblColNombreV.Size = new System.Drawing.Size(55, 13);
            this.lblColNombreV.TabIndex = 0;
            this.lblColNombreV.Text = "NOMBRE";
            // 
            // lblColEmailV
            // 
            this.lblColEmailV.AutoSize = true;
            this.lblColEmailV.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Bold);
            this.lblColEmailV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblColEmailV.Location = new System.Drawing.Point(180, 8);
            this.lblColEmailV.Name = "lblColEmailV";
            this.lblColEmailV.Size = new System.Drawing.Size(41, 13);
            this.lblColEmailV.TabIndex = 0;
            this.lblColEmailV.Text = "EMAIL";
            // 
            // lblColEstadoV
            // 
            this.lblColEstadoV.AutoSize = true;
            this.lblColEstadoV.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Bold);
            this.lblColEstadoV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblColEstadoV.Location = new System.Drawing.Point(440, 8);
            this.lblColEstadoV.Name = "lblColEstadoV";
            this.lblColEstadoV.Size = new System.Drawing.Size(48, 13);
            this.lblColEstadoV.TabIndex = 0;
            this.lblColEstadoV.Text = "ESTADO";
            // 
            // lblColSolicitudes
            // 
            this.lblColSolicitudes.AutoSize = true;
            this.lblColSolicitudes.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Bold);
            this.lblColSolicitudes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblColSolicitudes.Location = new System.Drawing.Point(580, 8);
            this.lblColSolicitudes.Name = "lblColSolicitudes";
            this.lblColSolicitudes.Size = new System.Drawing.Size(74, 13);
            this.lblColSolicitudes.TabIndex = 0;
            this.lblColSolicitudes.Text = "SOLICITUDES";
            // 
            // lblColUltimoAcceso
            // 
            this.lblColUltimoAcceso.AutoSize = true;
            this.lblColUltimoAcceso.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Bold);
            this.lblColUltimoAcceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblColUltimoAcceso.Location = new System.Drawing.Point(660, 8);
            this.lblColUltimoAcceso.Name = "lblColUltimoAcceso";
            this.lblColUltimoAcceso.Size = new System.Drawing.Size(93, 13);
            this.lblColUltimoAcceso.TabIndex = 0;
            this.lblColUltimoAcceso.Text = "ÚLTIMO ACCESO";
            // 
            // lblColContrasenaV
            // 
            this.lblColContrasenaV.AutoSize = true;
            this.lblColContrasenaV.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Bold);
            this.lblColContrasenaV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblColContrasenaV.Location = new System.Drawing.Point(840, 8);
            this.lblColContrasenaV.Name = "lblColContrasenaV";
            this.lblColContrasenaV.Size = new System.Drawing.Size(81, 13);
            this.lblColContrasenaV.TabIndex = 0;
            this.lblColContrasenaV.Text = "CONTRASEÑA";
            // 
            // pnlVendedoras
            // 
            this.pnlVendedoras.BackColor = System.Drawing.Color.White;
            this.pnlVendedoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVendedoras.Location = new System.Drawing.Point(20, 66);
            this.pnlVendedoras.Name = "pnlVendedoras";
            this.pnlVendedoras.Size = new System.Drawing.Size(1150, 220);
            this.pnlVendedoras.TabIndex = 2;
            // 
            // pnlSeccionAdmins
            // 
            this.pnlSeccionAdmins.Controls.Add(this.btnNuevoAdmin);
            this.pnlSeccionAdmins.Controls.Add(this.lblSeccionAdmins);
            this.pnlSeccionAdmins.Controls.Add(this.pnlAdminsHeader);
            this.pnlSeccionAdmins.Controls.Add(this.pnlAdmins);
            this.pnlSeccionAdmins.Location = new System.Drawing.Point(20, 300);
            this.pnlSeccionAdmins.Name = "pnlSeccionAdmins";
            this.pnlSeccionAdmins.Size = new System.Drawing.Size(1150, 160);
            this.pnlSeccionAdmins.TabIndex = 3;
            // 
            // btnNuevoAdmin
            // 
            this.btnNuevoAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnNuevoAdmin.FlatAppearance.BorderSize = 0;
            this.btnNuevoAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevoAdmin.ForeColor = System.Drawing.Color.White;
            this.btnNuevoAdmin.Location = new System.Drawing.Point(1010, 0);
            this.btnNuevoAdmin.Name = "btnNuevoAdmin";
            this.btnNuevoAdmin.Size = new System.Drawing.Size(140, 30);
            this.btnNuevoAdmin.TabIndex = 4;
            this.btnNuevoAdmin.Text = "👤 Nuevo admin";
            this.btnNuevoAdmin.UseVisualStyleBackColor = false;
            // 
            // lblSeccionAdmins
            // 
            this.lblSeccionAdmins.AutoSize = true;
            this.lblSeccionAdmins.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSeccionAdmins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSeccionAdmins.Location = new System.Drawing.Point(0, 8);
            this.lblSeccionAdmins.Name = "lblSeccionAdmins";
            this.lblSeccionAdmins.Size = new System.Drawing.Size(111, 13);
            this.lblSeccionAdmins.TabIndex = 0;
            this.lblSeccionAdmins.Text = "ADMINISTRADORES";
            // 
            // pnlAdminsHeader
            // 
            this.pnlAdminsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pnlAdminsHeader.Controls.Add(this.lblColNombreA);
            this.pnlAdminsHeader.Controls.Add(this.lblColEmailA);
            this.pnlAdminsHeader.Controls.Add(this.lblColEstadoA);
            this.pnlAdminsHeader.Controls.Add(this.lblColContrasenaA);
            this.pnlAdminsHeader.Location = new System.Drawing.Point(0, 30);
            this.pnlAdminsHeader.Name = "pnlAdminsHeader";
            this.pnlAdminsHeader.Size = new System.Drawing.Size(1150, 30);
            this.pnlAdminsHeader.TabIndex = 1;
            // 
            // lblColNombreA
            // 
            this.lblColNombreA.AutoSize = true;
            this.lblColNombreA.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Bold);
            this.lblColNombreA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblColNombreA.Location = new System.Drawing.Point(8, 8);
            this.lblColNombreA.Name = "lblColNombreA";
            this.lblColNombreA.Size = new System.Drawing.Size(55, 13);
            this.lblColNombreA.TabIndex = 0;
            this.lblColNombreA.Text = "NOMBRE";
            // 
            // lblColEmailA
            // 
            this.lblColEmailA.AutoSize = true;
            this.lblColEmailA.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Bold);
            this.lblColEmailA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblColEmailA.Location = new System.Drawing.Point(180, 8);
            this.lblColEmailA.Name = "lblColEmailA";
            this.lblColEmailA.Size = new System.Drawing.Size(41, 13);
            this.lblColEmailA.TabIndex = 0;
            this.lblColEmailA.Text = "EMAIL";
            // 
            // lblColEstadoA
            // 
            this.lblColEstadoA.AutoSize = true;
            this.lblColEstadoA.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Bold);
            this.lblColEstadoA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblColEstadoA.Location = new System.Drawing.Point(440, 8);
            this.lblColEstadoA.Name = "lblColEstadoA";
            this.lblColEstadoA.Size = new System.Drawing.Size(48, 13);
            this.lblColEstadoA.TabIndex = 0;
            this.lblColEstadoA.Text = "ESTADO";
            // 
            // lblColContrasenaA
            // 
            this.lblColContrasenaA.AutoSize = true;
            this.lblColContrasenaA.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Bold);
            this.lblColContrasenaA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblColContrasenaA.Location = new System.Drawing.Point(610, 8);
            this.lblColContrasenaA.Name = "lblColContrasenaA";
            this.lblColContrasenaA.Size = new System.Drawing.Size(81, 13);
            this.lblColContrasenaA.TabIndex = 0;
            this.lblColContrasenaA.Text = "CONTRASEÑA";
            // 
            // pnlAdmins
            // 
            this.pnlAdmins.BackColor = System.Drawing.Color.White;
            this.pnlAdmins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdmins.Location = new System.Drawing.Point(0, 60);
            this.pnlAdmins.Name = "pnlAdmins";
            this.pnlAdmins.Size = new System.Drawing.Size(1150, 90);
            this.pnlAdmins.TabIndex = 2;
            // 
            // pnlNueva
            // 
            this.pnlNueva.BackColor = System.Drawing.Color.White;
            this.pnlNueva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNueva.Controls.Add(this.btnLimpiar);
            this.pnlNueva.Controls.Add(this.btnGuardar);
            this.pnlNueva.Controls.Add(this.cmbEstadoNuevo);
            this.pnlNueva.Controls.Add(this.lblEstadoNuevo);
            this.pnlNueva.Controls.Add(this.txtContrasena);
            this.pnlNueva.Controls.Add(this.lblContrasenaNueva);
            this.pnlNueva.Controls.Add(this.cmbTipoUsuario);
            this.pnlNueva.Controls.Add(this.lblTipoUsuario);
            this.pnlNueva.Controls.Add(this.txtEmail);
            this.pnlNueva.Controls.Add(this.lblEmail);
            this.pnlNueva.Controls.Add(this.txtNombre);
            this.pnlNueva.Controls.Add(this.lblNombre);
            this.pnlNueva.Controls.Add(this.lblNuevaTitulo);
            this.pnlNueva.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNueva.Location = new System.Drawing.Point(0, 348);
            this.pnlNueva.Name = "pnlNueva";
            this.pnlNueva.Size = new System.Drawing.Size(1190, 230);
            this.pnlNueva.TabIndex = 2;
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
            this.btnLimpiar.TabIndex = 7;
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
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // cmbEstadoNuevo
            // 
            this.cmbEstadoNuevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoNuevo.Location = new System.Drawing.Point(462, 107);
            this.cmbEstadoNuevo.Name = "cmbEstadoNuevo";
            this.cmbEstadoNuevo.Size = new System.Drawing.Size(150, 23);
            this.cmbEstadoNuevo.TabIndex = 5;
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
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(294, 107);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '•';
            this.txtContrasena.Size = new System.Drawing.Size(150, 23);
            this.txtContrasena.TabIndex = 4;
            // 
            // lblContrasenaNueva
            // 
            this.lblContrasenaNueva.AutoSize = true;
            this.lblContrasenaNueva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblContrasenaNueva.Location = new System.Drawing.Point(291, 89);
            this.lblContrasenaNueva.Name = "lblContrasenaNueva";
            this.lblContrasenaNueva.Size = new System.Drawing.Size(67, 15);
            this.lblContrasenaNueva.TabIndex = 0;
            this.lblContrasenaNueva.Text = "Contraseña";
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(17, 107);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(256, 23);
            this.cmbTipoUsuario.TabIndex = 3;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTipoUsuario.Location = new System.Drawing.Point(14, 89);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(89, 15);
            this.lblTipoUsuario.TabIndex = 0;
            this.lblTipoUsuario.Text = "Tipo de usuario";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(294, 54);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(318, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblEmail.Location = new System.Drawing.Point(291, 36);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(14, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblNombre.Location = new System.Drawing.Point(14, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNuevaTitulo
            // 
            this.lblNuevaTitulo.AutoSize = true;
            this.lblNuevaTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNuevaTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblNuevaTitulo.Location = new System.Drawing.Point(14, 8);
            this.lblNuevaTitulo.Name = "lblNuevaTitulo";
            this.lblNuevaTitulo.Size = new System.Drawing.Size(155, 17);
            this.lblNuevaTitulo.TabIndex = 0;
            this.lblNuevaTitulo.Text = "Registrar nuevo usuario";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1190, 578);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlNueva);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 560);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios del sistema";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.pnlVendedorasHeader.ResumeLayout(false);
            this.pnlVendedorasHeader.PerformLayout();
            this.pnlSeccionAdmins.ResumeLayout(false);
            this.pnlSeccionAdmins.PerformLayout();
            this.pnlAdminsHeader.ResumeLayout(false);
            this.pnlAdminsHeader.PerformLayout();
            this.pnlNueva.ResumeLayout(false);
            this.pnlNueva.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnNuevaVendedora;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Label lblSeccionVendedoras;
        private System.Windows.Forms.Panel pnlVendedorasHeader;
        private System.Windows.Forms.Label lblColNombreV;
        private System.Windows.Forms.Label lblColEmailV;
        private System.Windows.Forms.Label lblColEstadoV;
        private System.Windows.Forms.Label lblColSolicitudes;
        private System.Windows.Forms.Label lblColUltimoAcceso;
        private System.Windows.Forms.Label lblColContrasenaV;
        private System.Windows.Forms.Panel pnlVendedoras;
        private System.Windows.Forms.Panel pnlSeccionAdmins;
        private System.Windows.Forms.Button btnNuevoAdmin;
        private System.Windows.Forms.Label lblSeccionAdmins;
        private System.Windows.Forms.Panel pnlAdminsHeader;
        private System.Windows.Forms.Label lblColNombreA;
        private System.Windows.Forms.Label lblColEmailA;
        private System.Windows.Forms.Label lblColEstadoA;
        private System.Windows.Forms.Label lblColContrasenaA;
        private System.Windows.Forms.Panel pnlAdmins;
        private System.Windows.Forms.Panel pnlNueva;
        private System.Windows.Forms.Label lblNuevaTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label lblContrasenaNueva;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblEstadoNuevo;
        private System.Windows.Forms.ComboBox cmbEstadoNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}