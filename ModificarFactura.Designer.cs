namespace StretchFilmApp
{
    partial class ModificarFactura
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
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtVendedora = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMargen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(109, 136);
            this.txtRUC.MaxLength = 11;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(137, 20);
            this.txtRUC.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "RUC:";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(109, 271);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(137, 20);
            this.dtpVencimiento.TabIndex = 45;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(109, 208);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(137, 20);
            this.txtTotal.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Total:";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(109, 244);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(137, 21);
            this.cboTipo.TabIndex = 42;
            // 
            // txtVendedora
            // 
            this.txtVendedora.Location = new System.Drawing.Point(109, 172);
            this.txtVendedora.Name = "txtVendedora";
            this.txtVendedora.Size = new System.Drawing.Size(137, 20);
            this.txtVendedora.TabIndex = 41;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(109, 100);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(137, 20);
            this.txtCliente.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Vendedora:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(198, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 23);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(39, 396);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 23);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tipo:";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(81, 67);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(31, 13);
            this.lblSerie.TabIndex = 35;
            this.lblSerie.Text = "Serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Serie:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "MODIFICAR FACTURA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Saldo:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(109, 304);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(137, 20);
            this.txtSaldo.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Margen (%):";
            // 
            // txtMargen
            // 
            this.txtMargen.Location = new System.Drawing.Point(109, 344);
            this.txtMargen.Name = "txtMargen";
            this.txtMargen.Size = new System.Drawing.Size(137, 20);
            this.txtMargen.TabIndex = 51;
            // 
            // ModificarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.txtMargen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtVendedora);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarFactura";
            this.Text = "ModificarFactura";
            this.Load += new System.EventHandler(this.ModificarFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TextBox txtVendedora;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMargen;
    }
}