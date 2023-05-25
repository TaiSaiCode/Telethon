namespace Project_Integrateur
{
    partial class frmDonnerPrix
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
            this.lblIdentif = new System.Windows.Forms.Label();
            this.lblPts = new System.Windows.Forms.Label();
            this.lstPrix = new System.Windows.Forms.ListBox();
            this.btnAttribuer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdentif
            // 
            this.lblIdentif.AutoSize = true;
            this.lblIdentif.Location = new System.Drawing.Point(8, 14);
            this.lblIdentif.Name = "lblIdentif";
            this.lblIdentif.Size = new System.Drawing.Size(46, 13);
            this.lblIdentif.TabIndex = 0;
            this.lblIdentif.Text = "lblIdentif";
            // 
            // lblPts
            // 
            this.lblPts.AutoSize = true;
            this.lblPts.Location = new System.Drawing.Point(8, 43);
            this.lblPts.Name = "lblPts";
            this.lblPts.Size = new System.Drawing.Size(32, 13);
            this.lblPts.TabIndex = 1;
            this.lblPts.Text = "lblPts";
            // 
            // lstPrix
            // 
            this.lstPrix.FormattingEnabled = true;
            this.lstPrix.Location = new System.Drawing.Point(77, 83);
            this.lstPrix.Name = "lstPrix";
            this.lstPrix.Size = new System.Drawing.Size(362, 277);
            this.lstPrix.TabIndex = 2;
            this.lstPrix.SelectedIndexChanged += new System.EventHandler(this.lstPrix_SelectedIndexChanged);
            // 
            // btnAttribuer
            // 
            this.btnAttribuer.Enabled = false;
            this.btnAttribuer.Location = new System.Drawing.Point(319, 379);
            this.btnAttribuer.Name = "btnAttribuer";
            this.btnAttribuer.Size = new System.Drawing.Size(120, 34);
            this.btnAttribuer.TabIndex = 3;
            this.btnAttribuer.Text = "Attribuer";
            this.btnAttribuer.UseVisualStyleBackColor = true;
            this.btnAttribuer.Click += new System.EventHandler(this.btnAttribuer_Click);
            // 
            // frmDonnerPrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.btnAttribuer);
            this.Controls.Add(this.lstPrix);
            this.Controls.Add(this.lblPts);
            this.Controls.Add(this.lblIdentif);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDonnerPrix";
            this.Text = "frmDonnerPrix";
            this.Load += new System.EventHandler(this.frmDonnerPrix_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdentif;
        private System.Windows.Forms.Label lblPts;
        private System.Windows.Forms.ListBox lstPrix;
        private System.Windows.Forms.Button btnAttribuer;
    }
}