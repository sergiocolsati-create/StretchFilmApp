namespace StretchFilmApp
{
    partial class HistorialPagos
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
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarPago = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AllowUserToResizeColumns = false;
            this.dgvHistorial.AllowUserToResizeRows = false;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(28, 62);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(453, 270);
            this.dgvHistorial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "HISTORIAL DE PAGOS";
            // 
            // btnEliminarPago
            // 
            this.btnEliminarPago.Location = new System.Drawing.Point(370, 31);
            this.btnEliminarPago.Name = "btnEliminarPago";
            this.btnEliminarPago.Size = new System.Drawing.Size(111, 23);
            this.btnEliminarPago.TabIndex = 2;
            this.btnEliminarPago.Text = "Eliminar Pago";
            this.btnEliminarPago.UseVisualStyleBackColor = true;
            this.btnEliminarPago.Click += new System.EventHandler(this.btnEliminarPago_Click);
            // 
            // HistorialPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 361);
            this.Controls.Add(this.btnEliminarPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHistorial);
            this.Name = "HistorialPagos";
            this.Text = "Historial de Pagos";
            this.Load += new System.EventHandler(this.HistorialPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarPago;
    }
}