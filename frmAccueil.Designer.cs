namespace Project_Integrateur {
    partial class frmAccueil {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblDon = new System.Windows.Forms.Label();
            this.pnlAcceuil = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlAcceuil.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(145, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(388, 201);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // lblDon
            // 
            this.lblDon.AutoSize = true;
            this.lblDon.BackColor = System.Drawing.Color.Transparent;
            this.lblDon.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDon.Location = new System.Drawing.Point(139, 74);
            this.lblDon.Name = "lblDon";
            this.lblDon.Size = new System.Drawing.Size(394, 31);
            this.lblDon.TabIndex = 0;
            this.lblDon.Text = "Faire un don. Faire la différence";
            // 
            // pnlAcceuil
            // 
            this.pnlAcceuil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAcceuil.BackgroundImage")));
            this.pnlAcceuil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAcceuil.Controls.Add(this.pictureBox3);
            this.pnlAcceuil.Controls.Add(this.lblDon);
            this.pnlAcceuil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAcceuil.Location = new System.Drawing.Point(0, 0);
            this.pnlAcceuil.Name = "pnlAcceuil";
            this.pnlAcceuil.Size = new System.Drawing.Size(657, 450);
            this.pnlAcceuil.TabIndex = 4;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAcceuil);
            this.Name = "frmAccueil";
            this.Size = new System.Drawing.Size(657, 450);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlAcceuil.ResumeLayout(false);
            this.pnlAcceuil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblDon;
        private System.Windows.Forms.Panel pnlAcceuil;
    }
}
