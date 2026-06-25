namespace StretchFilmApp
{
    partial class EditarMargen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dtpVigenciaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpVigenciaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.chkSinFechaFin = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(110, 75);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(258, 20);
            this.txtProducto.TabIndex = 35;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(110, 120);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(258, 20);
            this.txtCliente.TabIndex = 34;
            // 
            // dtpVigenciaFin
            // 
            this.dtpVigenciaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVigenciaFin.Location = new System.Drawing.Point(110, 243);
            this.dtpVigenciaFin.Name = "dtpVigenciaFin";
            this.dtpVigenciaFin.Size = new System.Drawing.Size(98, 20);
            this.dtpVigenciaFin.TabIndex = 33;
            // 
            // dtpVigenciaInicio
            // 
            this.dtpVigenciaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVigenciaInicio.Location = new System.Drawing.Point(110, 203);
            this.dtpVigenciaInicio.Name = "dtpVigenciaInicio";
            this.dtpVigenciaInicio.Size = new System.Drawing.Size(98, 20);
            this.dtpVigenciaInicio.TabIndex = 32;
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(300, 161);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(68, 20);
            this.txtMaximo.TabIndex = 31;
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(110, 161);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(68, 20);
            this.txtMinimo.TabIndex = 30;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(244, 305);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(92, 305);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Aceptar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chkSinFechaFin
            // 
            this.chkSinFechaFin.AutoSize = true;
            this.chkSinFechaFin.Location = new System.Drawing.Point(234, 245);
            this.chkSinFechaFin.Name = "chkSinFechaFin";
            this.chkSinFechaFin.Size = new System.Drawing.Size(85, 17);
            this.chkSinFechaFin.TabIndex = 27;
            this.chkSinFechaFin.Text = "Sin fecha fin";
            this.chkSinFechaFin.UseVisualStyleBackColor = true;
            this.chkSinFechaFin.CheckedChanged += new System.EventHandler(this.chkSinFechaFin_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Fecha fin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Fecha inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(231, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Máximo (%):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mínimo (%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "EDITAR MARGEN";
            // 
            // EditarMargen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 357);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.dtpVigenciaFin);
            this.Controls.Add(this.dtpVigenciaInicio);
            this.Controls.Add(this.txtMaximo);
            this.Controls.Add(this.txtMinimo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkSinFechaFin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditarMargen";
            this.Text = "EditarMargen";
            this.Load += new System.EventHandler(this.EditarMargen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DateTimePicker dtpVigenciaFin;
        private System.Windows.Forms.DateTimePicker dtpVigenciaInicio;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox chkSinFechaFin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}