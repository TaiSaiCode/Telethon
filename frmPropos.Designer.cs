namespace Project_Integrateur
{
    partial class frmPropos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEquipe = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEquipe
            // 
            this.lblEquipe.AutoSize = true;
            this.lblEquipe.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipe.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipe.Location = new System.Drawing.Point(40, 76);
            this.lblEquipe.Name = "lblEquipe";
            this.lblEquipe.Size = new System.Drawing.Size(272, 31);
            this.lblEquipe.TabIndex = 1;
            this.lblEquipe.Text = "Projet Déveloper Par:";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.BackColor = System.Drawing.Color.Transparent;
            this.lblAuteur.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuteur.Location = new System.Drawing.Point(40, 136);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(187, 62);
            this.lblAuteur.TabIndex = 2;
            this.lblAuteur.Text = "Bruno Théoret\r\nTom Tran\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 72);
            this.label1.TabIndex = 4;
            this.label1.Text = "Une application permettant a la gestion de don pour \r\nune organization, ajoute a " +
    "une liste le donateur, don,\r\ncommenditaire, et les prix,ensuite affiche les info" +
    "rmation.";
            // 
            // frmPropos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAuteur);
            this.Controls.Add(this.lblEquipe);
            this.Name = "frmPropos";
            this.Size = new System.Drawing.Size(644, 436);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEquipe;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.Label label1;
    }
}
