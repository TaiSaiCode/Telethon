namespace Project_Integrateur
{
    partial class frmCommanditaire
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommanditaire));
            this.tabControlCommanditaire = new System.Windows.Forms.TabControl();
            this.tabCommanditaireInfo = new System.Windows.Forms.TabPage();
            this.pnlCommenditaireInfo = new System.Windows.Forms.Panel();
            this.cbBoxCommanditaireIdExistant = new System.Windows.Forms.ComboBox();
            this.lblCommanditaire = new System.Windows.Forms.Label();
            this.txtNomCommanditaire = new System.Windows.Forms.TextBox();
            this.lblNomCommenditaire = new System.Windows.Forms.Label();
            this.txtPrenomCommanditaire = new System.Windows.Forms.TextBox();
            this.lblPrenomCommenditaire = new System.Windows.Forms.Label();
            this.txtIdCommanditaire = new System.Windows.Forms.TextBox();
            this.lblIDCommenditaire = new System.Windows.Forms.Label();
            this.tabCommanditairePrix = new System.Windows.Forms.TabPage();
            this.pnlCommenditairePrix = new System.Windows.Forms.Panel();
            this.lblValueIdCommanditaire = new System.Windows.Forms.Label();
            this.txtQuantitePrix = new System.Windows.Forms.TextBox();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.lblInfoCommenditaire = new System.Windows.Forms.Label();
            this.txtValeurPrix = new System.Windows.Forms.TextBox();
            this.lblValeur = new System.Windows.Forms.Label();
            this.lblArticleCommenditaire = new System.Windows.Forms.Label();
            this.cbArticlePrix = new System.Windows.Forms.ComboBox();
            this.tabCommanditaireResume = new System.Windows.Forms.TabPage();
            this.pnlCommenditaireResume = new System.Windows.Forms.Panel();
            this.lboxCommanditairePrix = new System.Windows.Forms.ListBox();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnCommanditaireSauver = new System.Windows.Forms.Button();
            this.btnCommanditaireSuivant = new System.Windows.Forms.Button();
            this.btnCommanditairePrecedent = new System.Windows.Forms.Button();
            this.ttCommanditaire = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlCommanditaire.SuspendLayout();
            this.tabCommanditaireInfo.SuspendLayout();
            this.pnlCommenditaireInfo.SuspendLayout();
            this.tabCommanditairePrix.SuspendLayout();
            this.pnlCommenditairePrix.SuspendLayout();
            this.tabCommanditaireResume.SuspendLayout();
            this.pnlCommenditaireResume.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCommanditaire
            // 
            this.tabControlCommanditaire.Controls.Add(this.tabCommanditaireInfo);
            this.tabControlCommanditaire.Controls.Add(this.tabCommanditairePrix);
            this.tabControlCommanditaire.Controls.Add(this.tabCommanditaireResume);
            this.tabControlCommanditaire.Location = new System.Drawing.Point(3, 3);
            this.tabControlCommanditaire.Name = "tabControlCommanditaire";
            this.tabControlCommanditaire.SelectedIndex = 0;
            this.tabControlCommanditaire.Size = new System.Drawing.Size(545, 370);
            this.tabControlCommanditaire.TabIndex = 35;
            this.tabControlCommanditaire.Tag = "";
            // 
            // tabCommanditaireInfo
            // 
            this.tabCommanditaireInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCommanditaireInfo.Controls.Add(this.pnlCommenditaireInfo);
            this.tabCommanditaireInfo.Location = new System.Drawing.Point(4, 22);
            this.tabCommanditaireInfo.Name = "tabCommanditaireInfo";
            this.tabCommanditaireInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommanditaireInfo.Size = new System.Drawing.Size(537, 344);
            this.tabCommanditaireInfo.TabIndex = 0;
            this.tabCommanditaireInfo.Text = "commanditaireInfoTab";
            this.tabCommanditaireInfo.UseVisualStyleBackColor = true;
            // 
            // pnlCommenditaireInfo
            // 
            this.pnlCommenditaireInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlCommenditaireInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCommenditaireInfo.Controls.Add(this.cbBoxCommanditaireIdExistant);
            this.pnlCommenditaireInfo.Controls.Add(this.lblCommanditaire);
            this.pnlCommenditaireInfo.Controls.Add(this.txtNomCommanditaire);
            this.pnlCommenditaireInfo.Controls.Add(this.lblNomCommenditaire);
            this.pnlCommenditaireInfo.Controls.Add(this.txtPrenomCommanditaire);
            this.pnlCommenditaireInfo.Controls.Add(this.lblPrenomCommenditaire);
            this.pnlCommenditaireInfo.Controls.Add(this.txtIdCommanditaire);
            this.pnlCommenditaireInfo.Controls.Add(this.lblIDCommenditaire);
            this.pnlCommenditaireInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCommenditaireInfo.Location = new System.Drawing.Point(3, 3);
            this.pnlCommenditaireInfo.Name = "pnlCommenditaireInfo";
            this.pnlCommenditaireInfo.Size = new System.Drawing.Size(531, 338);
            this.pnlCommenditaireInfo.TabIndex = 35;
            // 
            // cbBoxCommanditaireIdExistant
            // 
            this.cbBoxCommanditaireIdExistant.FormattingEnabled = true;
            this.cbBoxCommanditaireIdExistant.Location = new System.Drawing.Point(362, 156);
            this.cbBoxCommanditaireIdExistant.Name = "cbBoxCommanditaireIdExistant";
            this.cbBoxCommanditaireIdExistant.Size = new System.Drawing.Size(121, 21);
            this.cbBoxCommanditaireIdExistant.TabIndex = 31;
            this.cbBoxCommanditaireIdExistant.SelectedIndexChanged += new System.EventHandler(this.cbBoxCommanditaireID_SelectedIndexChanged);
            // 
            // lblCommanditaire
            // 
            this.lblCommanditaire.AutoSize = true;
            this.lblCommanditaire.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommanditaire.Location = new System.Drawing.Point(137, 88);
            this.lblCommanditaire.Name = "lblCommanditaire";
            this.lblCommanditaire.Size = new System.Drawing.Size(385, 31);
            this.lblCommanditaire.TabIndex = 30;
            this.lblCommanditaire.Text = "Information du Commanditaire";
            // 
            // txtNomCommanditaire
            // 
            this.txtNomCommanditaire.Location = new System.Drawing.Point(300, 237);
            this.txtNomCommanditaire.Name = "txtNomCommanditaire";
            this.txtNomCommanditaire.Size = new System.Drawing.Size(183, 20);
            this.txtNomCommanditaire.TabIndex = 25;
            // 
            // lblNomCommenditaire
            // 
            this.lblNomCommenditaire.AutoSize = true;
            this.lblNomCommenditaire.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCommenditaire.Location = new System.Drawing.Point(139, 237);
            this.lblNomCommenditaire.Name = "lblNomCommenditaire";
            this.lblNomCommenditaire.Size = new System.Drawing.Size(53, 24);
            this.lblNomCommenditaire.TabIndex = 24;
            this.lblNomCommenditaire.Text = "Nom";
            // 
            // txtPrenomCommanditaire
            // 
            this.txtPrenomCommanditaire.Location = new System.Drawing.Point(301, 197);
            this.txtPrenomCommanditaire.Name = "txtPrenomCommanditaire";
            this.txtPrenomCommanditaire.Size = new System.Drawing.Size(182, 20);
            this.txtPrenomCommanditaire.TabIndex = 23;
            // 
            // lblPrenomCommenditaire
            // 
            this.lblPrenomCommenditaire.AutoSize = true;
            this.lblPrenomCommenditaire.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenomCommenditaire.Location = new System.Drawing.Point(139, 197);
            this.lblPrenomCommenditaire.Name = "lblPrenomCommenditaire";
            this.lblPrenomCommenditaire.Size = new System.Drawing.Size(81, 24);
            this.lblPrenomCommenditaire.TabIndex = 22;
            this.lblPrenomCommenditaire.Text = "Prenom";
            // 
            // txtIdCommanditaire
            // 
            this.txtIdCommanditaire.Enabled = false;
            this.txtIdCommanditaire.Location = new System.Drawing.Point(300, 157);
            this.txtIdCommanditaire.Name = "txtIdCommanditaire";
            this.txtIdCommanditaire.Size = new System.Drawing.Size(52, 20);
            this.txtIdCommanditaire.TabIndex = 21;
            // 
            // lblIDCommenditaire
            // 
            this.lblIDCommenditaire.AutoSize = true;
            this.lblIDCommenditaire.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCommenditaire.Location = new System.Drawing.Point(139, 157);
            this.lblIDCommenditaire.Name = "lblIDCommenditaire";
            this.lblIDCommenditaire.Size = new System.Drawing.Size(32, 24);
            this.lblIDCommenditaire.TabIndex = 20;
            this.lblIDCommenditaire.Text = "ID";
            // 
            // tabCommanditairePrix
            // 
            this.tabCommanditairePrix.Controls.Add(this.pnlCommenditairePrix);
            this.tabCommanditairePrix.Location = new System.Drawing.Point(4, 22);
            this.tabCommanditairePrix.Name = "tabCommanditairePrix";
            this.tabCommanditairePrix.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommanditairePrix.Size = new System.Drawing.Size(537, 344);
            this.tabCommanditairePrix.TabIndex = 1;
            this.tabCommanditairePrix.Text = "commanditairePrixTab";
            this.tabCommanditairePrix.UseVisualStyleBackColor = true;
            // 
            // pnlCommenditairePrix
            // 
            this.pnlCommenditairePrix.BackColor = System.Drawing.Color.Transparent;
            this.pnlCommenditairePrix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCommenditairePrix.Controls.Add(this.lblValueIdCommanditaire);
            this.pnlCommenditairePrix.Controls.Add(this.txtQuantitePrix);
            this.pnlCommenditairePrix.Controls.Add(this.lblQuantite);
            this.pnlCommenditairePrix.Controls.Add(this.lblInfoCommenditaire);
            this.pnlCommenditairePrix.Controls.Add(this.txtValeurPrix);
            this.pnlCommenditairePrix.Controls.Add(this.lblValeur);
            this.pnlCommenditairePrix.Controls.Add(this.lblArticleCommenditaire);
            this.pnlCommenditairePrix.Controls.Add(this.cbArticlePrix);
            this.pnlCommenditairePrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCommenditairePrix.Location = new System.Drawing.Point(3, 3);
            this.pnlCommenditairePrix.Name = "pnlCommenditairePrix";
            this.pnlCommenditairePrix.Size = new System.Drawing.Size(531, 338);
            this.pnlCommenditairePrix.TabIndex = 30;
            this.pnlCommenditairePrix.Visible = false;
            // 
            // lblValueIdCommanditaire
            // 
            this.lblValueIdCommanditaire.AutoSize = true;
            this.lblValueIdCommanditaire.BackColor = System.Drawing.Color.Transparent;
            this.lblValueIdCommanditaire.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueIdCommanditaire.Location = new System.Drawing.Point(195, 287);
            this.lblValueIdCommanditaire.Name = "lblValueIdCommanditaire";
            this.lblValueIdCommanditaire.Size = new System.Drawing.Size(61, 15);
            this.lblValueIdCommanditaire.TabIndex = 34;
            this.lblValueIdCommanditaire.Text = "lblValueId";
            // 
            // txtQuantitePrix
            // 
            this.txtQuantitePrix.Location = new System.Drawing.Point(307, 242);
            this.txtQuantitePrix.Name = "txtQuantitePrix";
            this.txtQuantitePrix.Size = new System.Drawing.Size(58, 20);
            this.txtQuantitePrix.TabIndex = 33;
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantite.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantite.Location = new System.Drawing.Point(194, 242);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(88, 24);
            this.lblQuantite.TabIndex = 32;
            this.lblQuantite.Text = "Quantité";
            // 
            // lblInfoCommenditaire
            // 
            this.lblInfoCommenditaire.AutoSize = true;
            this.lblInfoCommenditaire.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoCommenditaire.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoCommenditaire.Location = new System.Drawing.Point(192, 90);
            this.lblInfoCommenditaire.Name = "lblInfoCommenditaire";
            this.lblInfoCommenditaire.Size = new System.Drawing.Size(213, 31);
            this.lblInfoCommenditaire.TabIndex = 31;
            this.lblInfoCommenditaire.Text = "Information Prix";
            // 
            // txtValeurPrix
            // 
            this.txtValeurPrix.Location = new System.Drawing.Point(307, 196);
            this.txtValeurPrix.Name = "txtValeurPrix";
            this.txtValeurPrix.Size = new System.Drawing.Size(121, 20);
            this.txtValeurPrix.TabIndex = 8;
            this.ttCommanditaire.SetToolTip(this.txtValeurPrix, "Entrer une valeur pour votre article");
            this.txtValeurPrix.TextChanged += new System.EventHandler(this.txtValeurPrix_TextChanged);
            this.txtValeurPrix.Leave += new System.EventHandler(this.txtValeurPrix_Leave);
            // 
            // lblValeur
            // 
            this.lblValeur.AutoSize = true;
            this.lblValeur.BackColor = System.Drawing.Color.Transparent;
            this.lblValeur.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValeur.Location = new System.Drawing.Point(194, 196);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(98, 24);
            this.lblValeur.TabIndex = 9;
            this.lblValeur.Text = "Valeur ($)";
            // 
            // lblArticleCommenditaire
            // 
            this.lblArticleCommenditaire.AutoSize = true;
            this.lblArticleCommenditaire.BackColor = System.Drawing.Color.Transparent;
            this.lblArticleCommenditaire.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticleCommenditaire.Location = new System.Drawing.Point(194, 147);
            this.lblArticleCommenditaire.Name = "lblArticleCommenditaire";
            this.lblArticleCommenditaire.Size = new System.Drawing.Size(70, 24);
            this.lblArticleCommenditaire.TabIndex = 7;
            this.lblArticleCommenditaire.Text = "Article";
            // 
            // cbArticlePrix
            // 
            this.cbArticlePrix.FormattingEnabled = true;
            this.cbArticlePrix.Items.AddRange(new object[] {
            "BBQ",
            "Calendrier",
            "Repas pour Deux",
            "Televiseur"});
            this.cbArticlePrix.Location = new System.Drawing.Point(307, 147);
            this.cbArticlePrix.Name = "cbArticlePrix";
            this.cbArticlePrix.Size = new System.Drawing.Size(121, 21);
            this.cbArticlePrix.TabIndex = 10;
            // 
            // tabCommanditaireResume
            // 
            this.tabCommanditaireResume.Controls.Add(this.pnlCommenditaireResume);
            this.tabCommanditaireResume.Location = new System.Drawing.Point(4, 22);
            this.tabCommanditaireResume.Name = "tabCommanditaireResume";
            this.tabCommanditaireResume.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommanditaireResume.Size = new System.Drawing.Size(537, 344);
            this.tabCommanditaireResume.TabIndex = 2;
            this.tabCommanditaireResume.Text = "commanditaireResume";
            this.tabCommanditaireResume.UseVisualStyleBackColor = true;
            // 
            // pnlCommenditaireResume
            // 
            this.pnlCommenditaireResume.BackColor = System.Drawing.Color.Transparent;
            this.pnlCommenditaireResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCommenditaireResume.Controls.Add(this.lboxCommanditairePrix);
            this.pnlCommenditaireResume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCommenditaireResume.Location = new System.Drawing.Point(3, 3);
            this.pnlCommenditaireResume.Name = "pnlCommenditaireResume";
            this.pnlCommenditaireResume.Size = new System.Drawing.Size(531, 338);
            this.pnlCommenditaireResume.TabIndex = 30;
            this.pnlCommenditaireResume.Visible = false;
            // 
            // lboxCommanditairePrix
            // 
            this.lboxCommanditairePrix.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxCommanditairePrix.FormattingEnabled = true;
            this.lboxCommanditairePrix.ItemHeight = 19;
            this.lboxCommanditairePrix.Location = new System.Drawing.Point(43, 44);
            this.lboxCommanditairePrix.Name = "lboxCommanditairePrix";
            this.lboxCommanditairePrix.Size = new System.Drawing.Size(304, 270);
            this.lboxCommanditairePrix.TabIndex = 0;
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavigation.Controls.Add(this.btnCommanditaireSauver);
            this.pnlNavigation.Controls.Add(this.btnCommanditaireSuivant);
            this.pnlNavigation.Controls.Add(this.btnCommanditairePrecedent);
            this.pnlNavigation.Location = new System.Drawing.Point(390, 325);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(200, 67);
            this.pnlNavigation.TabIndex = 36;
            // 
            // btnCommanditaireSauver
            // 
            this.btnCommanditaireSauver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCommanditaireSauver.BackgroundImage")));
            this.btnCommanditaireSauver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCommanditaireSauver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCommanditaireSauver.Enabled = false;
            this.btnCommanditaireSauver.Location = new System.Drawing.Point(76, 13);
            this.btnCommanditaireSauver.Name = "btnCommanditaireSauver";
            this.btnCommanditaireSauver.Size = new System.Drawing.Size(50, 40);
            this.btnCommanditaireSauver.TabIndex = 33;
            this.btnCommanditaireSauver.UseVisualStyleBackColor = true;
            this.btnCommanditaireSauver.Click += new System.EventHandler(this.btnCommanditaireSauver_Click);
            // 
            // btnCommanditaireSuivant
            // 
            this.btnCommanditaireSuivant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCommanditaireSuivant.BackgroundImage")));
            this.btnCommanditaireSuivant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCommanditaireSuivant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCommanditaireSuivant.Location = new System.Drawing.Point(135, 13);
            this.btnCommanditaireSuivant.Name = "btnCommanditaireSuivant";
            this.btnCommanditaireSuivant.Size = new System.Drawing.Size(50, 40);
            this.btnCommanditaireSuivant.TabIndex = 31;
            this.btnCommanditaireSuivant.UseVisualStyleBackColor = true;
            this.btnCommanditaireSuivant.Click += new System.EventHandler(this.btnCommanditaireSuivant_Click_1);
            // 
            // btnCommanditairePrecedent
            // 
            this.btnCommanditairePrecedent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCommanditairePrecedent.BackgroundImage")));
            this.btnCommanditairePrecedent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCommanditairePrecedent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCommanditairePrecedent.Location = new System.Drawing.Point(13, 13);
            this.btnCommanditairePrecedent.Name = "btnCommanditairePrecedent";
            this.btnCommanditairePrecedent.Size = new System.Drawing.Size(50, 40);
            this.btnCommanditairePrecedent.TabIndex = 32;
            this.btnCommanditairePrecedent.UseVisualStyleBackColor = true;
            this.btnCommanditairePrecedent.Click += new System.EventHandler(this.btnCommanditairePrecedent_Click_1);
            // 
            // frmCommanditaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.tabControlCommanditaire);
            this.Name = "frmCommanditaire";
            this.Size = new System.Drawing.Size(897, 574);
            this.Load += new System.EventHandler(this.frmCommanditaire_Load);
            this.tabControlCommanditaire.ResumeLayout(false);
            this.tabCommanditaireInfo.ResumeLayout(false);
            this.pnlCommenditaireInfo.ResumeLayout(false);
            this.pnlCommenditaireInfo.PerformLayout();
            this.tabCommanditairePrix.ResumeLayout(false);
            this.pnlCommenditairePrix.ResumeLayout(false);
            this.pnlCommenditairePrix.PerformLayout();
            this.tabCommanditaireResume.ResumeLayout(false);
            this.pnlCommenditaireResume.ResumeLayout(false);
            this.pnlNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCommanditaire;
        private System.Windows.Forms.TabPage tabCommanditaireInfo;
        private System.Windows.Forms.Panel pnlCommenditaireInfo;
        private System.Windows.Forms.Label lblCommanditaire;
        private System.Windows.Forms.TextBox txtNomCommanditaire;
        private System.Windows.Forms.Label lblNomCommenditaire;
        private System.Windows.Forms.TextBox txtPrenomCommanditaire;
        private System.Windows.Forms.Label lblPrenomCommenditaire;
        private System.Windows.Forms.TextBox txtIdCommanditaire;
        private System.Windows.Forms.Label lblIDCommenditaire;
        private System.Windows.Forms.TabPage tabCommanditairePrix;
        private System.Windows.Forms.Panel pnlCommenditairePrix;
        private System.Windows.Forms.TextBox txtQuantitePrix;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label lblInfoCommenditaire;
        private System.Windows.Forms.TextBox txtValeurPrix;
        private System.Windows.Forms.Label lblValeur;
        private System.Windows.Forms.Label lblArticleCommenditaire;
        private System.Windows.Forms.ComboBox cbArticlePrix;
        private System.Windows.Forms.TabPage tabCommanditaireResume;
        private System.Windows.Forms.Panel pnlCommenditaireResume;
        private System.Windows.Forms.ListBox lboxCommanditairePrix;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnCommanditaireSauver;
        private System.Windows.Forms.Button btnCommanditaireSuivant;
        private System.Windows.Forms.Button btnCommanditairePrecedent;
        private System.Windows.Forms.ComboBox cbBoxCommanditaireIdExistant;
        private System.Windows.Forms.Label lblValueIdCommanditaire;
        private System.Windows.Forms.ToolTip ttCommanditaire;
    }
}
