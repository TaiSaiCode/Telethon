namespace Project_Integrateur
{
    partial class Connexion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.pnlConnexionGauche = new System.Windows.Forms.Panel();
            this.picTelethon = new System.Windows.Forms.PictureBox();
            this.pnlConnexionDroite = new System.Windows.Forms.Panel();
            this.picFermer = new System.Windows.Forms.PictureBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtMotPasse = new System.Windows.Forms.TextBox();
            this.txtUtilisateur = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ttConnexion = new System.Windows.Forms.ToolTip(this.components);
            this.pnlConnexionGauche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTelethon)).BeginInit();
            this.pnlConnexionDroite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFermer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConnexionGauche
            // 
            this.pnlConnexionGauche.BackColor = System.Drawing.Color.Blue;
            this.pnlConnexionGauche.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlConnexionGauche.BackgroundImage")));
            this.pnlConnexionGauche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlConnexionGauche.Controls.Add(this.picTelethon);
            this.pnlConnexionGauche.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlConnexionGauche.Location = new System.Drawing.Point(0, 0);
            this.pnlConnexionGauche.Name = "pnlConnexionGauche";
            this.pnlConnexionGauche.Size = new System.Drawing.Size(338, 337);
            this.pnlConnexionGauche.TabIndex = 0;
            // 
            // picTelethon
            // 
            this.picTelethon.Image = ((System.Drawing.Image)(resources.GetObject("picTelethon.Image")));
            this.picTelethon.Location = new System.Drawing.Point(3, 3);
            this.picTelethon.Name = "picTelethon";
            this.picTelethon.Size = new System.Drawing.Size(332, 97);
            this.picTelethon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTelethon.TabIndex = 0;
            this.picTelethon.TabStop = false;
            // 
            // pnlConnexionDroite
            // 
            this.pnlConnexionDroite.BackColor = System.Drawing.Color.Yellow;
            this.pnlConnexionDroite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlConnexionDroite.BackgroundImage")));
            this.pnlConnexionDroite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlConnexionDroite.Controls.Add(this.picFermer);
            this.pnlConnexionDroite.Controls.Add(this.btnConnexion);
            this.pnlConnexionDroite.Controls.Add(this.pictureBox4);
            this.pnlConnexionDroite.Controls.Add(this.pictureBox3);
            this.pnlConnexionDroite.Controls.Add(this.txtMotPasse);
            this.pnlConnexionDroite.Controls.Add(this.txtUtilisateur);
            this.pnlConnexionDroite.Controls.Add(this.pictureBox2);
            this.pnlConnexionDroite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConnexionDroite.Location = new System.Drawing.Point(338, 0);
            this.pnlConnexionDroite.Name = "pnlConnexionDroite";
            this.pnlConnexionDroite.Size = new System.Drawing.Size(313, 337);
            this.pnlConnexionDroite.TabIndex = 1;
            // 
            // picFermer
            // 
            this.picFermer.BackColor = System.Drawing.Color.Transparent;
            this.picFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFermer.Image = ((System.Drawing.Image)(resources.GetObject("picFermer.Image")));
            this.picFermer.Location = new System.Drawing.Point(285, 3);
            this.picFermer.Name = "picFermer";
            this.picFermer.Size = new System.Drawing.Size(25, 25);
            this.picFermer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFermer.TabIndex = 9;
            this.picFermer.TabStop = false;
            this.picFermer.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnConnexion.Enabled = false;
            this.btnConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.Color.White;
            this.btnConnexion.Location = new System.Drawing.Point(109, 255);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(88, 38);
            this.btnConnexion.TabIndex = 7;
            this.btnConnexion.Text = "Connexion";
            this.ttConnexion.SetToolTip(this.btnConnexion, "Veuilez Éntrer votre Utilisateur et votre Mot de Passe");
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(59, 204);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(59, 156);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // txtMotPasse
            // 
            this.txtMotPasse.Location = new System.Drawing.Point(109, 213);
            this.txtMotPasse.Name = "txtMotPasse";
            this.txtMotPasse.PasswordChar = '*';
            this.txtMotPasse.Size = new System.Drawing.Size(100, 20);
            this.txtMotPasse.TabIndex = 2;
            // 
            // txtUtilisateur
            // 
            this.txtUtilisateur.Location = new System.Drawing.Point(109, 167);
            this.txtUtilisateur.Name = "txtUtilisateur";
            this.txtUtilisateur.Size = new System.Drawing.Size(100, 20);
            this.txtUtilisateur.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(77, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(651, 337);
            this.ControlBox = false;
            this.Controls.Add(this.pnlConnexionDroite);
            this.Controls.Add(this.pnlConnexionGauche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlConnexionGauche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTelethon)).EndInit();
            this.pnlConnexionDroite.ResumeLayout(false);
            this.pnlConnexionDroite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFermer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConnexionGauche;
        private System.Windows.Forms.PictureBox picTelethon;
        private System.Windows.Forms.Panel pnlConnexionDroite;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtMotPasse;
        private System.Windows.Forms.TextBox txtUtilisateur;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.PictureBox picFermer;
        private System.Windows.Forms.ToolTip ttConnexion;
    }
}

