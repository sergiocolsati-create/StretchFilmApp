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
            this.btnNuevoMargen = new System.Windows.Forms.Button();
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
            this.flpMargenes.Size = new System.Drawing.Size(964, 484);
            this.flpMargenes.TabIndex = 3;
            // 
            // btnNuevoMargen
            // 
            this.btnNuevoMargen.Location = new System.Drawing.Point(869, 32);
            this.btnNuevoMargen.Name = "btnNuevoMargen";
            this.btnNuevoMargen.Size = new System.Drawing.Size(122, 23);
            this.btnNuevoMargen.TabIndex = 4;
            this.btnNuevoMargen.Text = "Nuevo Margen";
            this.btnNuevoMargen.UseVisualStyleBackColor = true;
            this.btnNuevoMargen.Click += new System.EventHandler(this.btnNuevoMargen_Click);
            // 
            // Margenes
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 606);
            this.Controls.Add(this.btnNuevoMargen);
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
        private System.Windows.Forms.Button btnNuevoMargen;
    }
}