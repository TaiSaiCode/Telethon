using System.Drawing;

namespace Project_Integrateur {
    partial class frmDonateur {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonateur));
            this.btnDonateurSuivant = new System.Windows.Forms.Button();
            this.btnDonateurPrecedent = new System.Windows.Forms.Button();
            this.btnDonateurSauve = new System.Windows.Forms.Button();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.tabControlHidden = new System.Windows.Forms.TabControl();
            this.tabDonateurInfo = new System.Windows.Forms.TabPage();
            this.pnlDonateurInfo = new System.Windows.Forms.Panel();
            this.cbBoxDonateurIdExistant = new System.Windows.Forms.ComboBox();
            this.lblDonateur = new System.Windows.Forms.Label();
            this.txtTelephoneDonateur = new System.Windows.Forms.TextBox();
            this.lblTelephoneDonateur = new System.Windows.Forms.Label();
            this.txtCourrielDonateur = new System.Windows.Forms.TextBox();
            this.lblCourrielDonateur = new System.Windows.Forms.Label();
            this.txtNomDonateur = new System.Windows.Forms.TextBox();
            this.lblNomDonateur = new System.Windows.Forms.Label();
            this.txtPrenomDonateur = new System.Windows.Forms.TextBox();
            this.lblPrenomDonateur = new System.Windows.Forms.Label();
            this.txtIdDonateur = new System.Windows.Forms.TextBox();
            this.lblIdDonateur = new System.Windows.Forms.Label();
            this.tabDonateurCarte = new System.Windows.Forms.TabPage();
            this.pnlDonateurCarte = new System.Windows.Forms.Panel();
            this.txtDonateurCvs = new System.Windows.Forms.TextBox();
            this.lblCvs = new System.Windows.Forms.Label();
            this.lblCarte = new System.Windows.Forms.Label();
            this.cbCCExpAnnee = new System.Windows.Forms.ComboBox();
            this.rbtnVisa = new System.Windows.Forms.RadioButton();
            this.txtNumeroDonateur = new System.Windows.Forms.TextBox();
            this.rbtnMcard = new System.Windows.Forms.RadioButton();
            this.lblExpireDonateur = new System.Windows.Forms.Label();
            this.lblNumeroDonateur = new System.Windows.Forms.Label();
            this.rbtnAexpress = new System.Windows.Forms.RadioButton();
            this.cbCCExpMois = new System.Windows.Forms.ComboBox();
            this.tabDonateurDon = new System.Windows.Forms.TabPage();
            this.lblPoints = new System.Windows.Forms.Label();
            this.picPrix = new System.Windows.Forms.PictureBox();
            this.dtpDon = new System.Windows.Forms.DateTimePicker();
            this.lblDateDonateur = new System.Windows.Forms.Label();
            this.lblInfoDonateur = new System.Windows.Forms.Label();
            this.txtMontantDonateur = new System.Windows.Forms.TextBox();
            this.lblMontantDonateur = new System.Windows.Forms.Label();
            this.tabDonateurResume = new System.Windows.Forms.TabPage();
            this.pnlDonateurResume = new System.Windows.Forms.Panel();
            this.lboxDonateur = new System.Windows.Forms.ListBox();
            this.ttDonateur = new System.Windows.Forms.ToolTip(this.components);
            this.pnlNavigation.SuspendLayout();
            this.tabControlHidden.SuspendLayout();
            this.tabDonateurInfo.SuspendLayout();
            this.pnlDonateurInfo.SuspendLayout();
            this.tabDonateurCarte.SuspendLayout();
            this.pnlDonateurCarte.SuspendLayout();
            this.tabDonateurDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrix)).BeginInit();
            this.tabDonateurResume.SuspendLayout();
            this.pnlDonateurResume.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDonateurSuivant
            // 
            this.btnDonateurSuivant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDonateurSuivant.BackgroundImage")));
            this.btnDonateurSuivant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDonateurSuivant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonateurSuivant.Location = new System.Drawing.Point(135, 13);
            this.btnDonateurSuivant.Name = "btnDonateurSuivant";
            this.btnDonateurSuivant.Size = new System.Drawing.Size(50, 40);
            this.btnDonateurSuivant.TabIndex = 31;
            this.btnDonateurSuivant.UseVisualStyleBackColor = true;
            this.btnDonateurSuivant.Click += new System.EventHandler(this.btnDonateurSuivant_Click);
            // 
            // btnDonateurPrecedent
            // 
            this.btnDonateurPrecedent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDonateurPrecedent.BackgroundImage")));
            this.btnDonateurPrecedent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDonateurPrecedent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonateurPrecedent.Location = new System.Drawing.Point(13, 13);
            this.btnDonateurPrecedent.Name = "btnDonateurPrecedent";
            this.btnDonateurPrecedent.Size = new System.Drawing.Size(50, 40);
            this.btnDonateurPrecedent.TabIndex = 32;
            this.btnDonateurPrecedent.UseVisualStyleBackColor = true;
            this.btnDonateurPrecedent.Click += new System.EventHandler(this.btnDonateurPrecedent_Click);
            // 
            // btnDonateurSauve
            // 
            this.btnDonateurSauve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDonateurSauve.BackgroundImage")));
            this.btnDonateurSauve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDonateurSauve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonateurSauve.Enabled = false;
            this.btnDonateurSauve.Location = new System.Drawing.Point(76, 13);
            this.btnDonateurSauve.Name = "btnDonateurSauve";
            this.btnDonateurSauve.Size = new System.Drawing.Size(50, 40);
            this.btnDonateurSauve.TabIndex = 33;
            this.btnDonateurSauve.UseVisualStyleBackColor = true;
            this.btnDonateurSauve.Click += new System.EventHandler(this.btnDonateurSauve_Click);
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavigation.Controls.Add(this.btnDonateurSauve);
            this.pnlNavigation.Controls.Add(this.btnDonateurSuivant);
            this.pnlNavigation.Controls.Add(this.btnDonateurPrecedent);
            this.pnlNavigation.Location = new System.Drawing.Point(390, 325);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(200, 67);
            this.pnlNavigation.TabIndex = 34;
            // 
            // tabControlHidden
            // 
            this.tabControlHidden.Controls.Add(this.tabDonateurInfo);
            this.tabControlHidden.Controls.Add(this.tabDonateurCarte);
            this.tabControlHidden.Controls.Add(this.tabDonateurDon);
            this.tabControlHidden.Controls.Add(this.tabDonateurResume);
            this.tabControlHidden.Location = new System.Drawing.Point(6, 15);
            this.tabControlHidden.Name = "tabControlHidden";
            this.tabControlHidden.SelectedIndex = 0;
            this.tabControlHidden.Size = new System.Drawing.Size(613, 389);
            this.tabControlHidden.TabIndex = 34;
            this.tabControlHidden.Tag = "";
            // 
            // tabDonateurInfo
            // 
            this.tabDonateurInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDonateurInfo.Controls.Add(this.pnlDonateurInfo);
            this.tabDonateurInfo.Location = new System.Drawing.Point(4, 22);
            this.tabDonateurInfo.Name = "tabDonateurInfo";
            this.tabDonateurInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabDonateurInfo.Size = new System.Drawing.Size(605, 363);
            this.tabDonateurInfo.TabIndex = 0;
            this.tabDonateurInfo.Text = "donateurInfoTab";
            this.tabDonateurInfo.UseVisualStyleBackColor = true;
            // 
            // pnlDonateurInfo
            // 
            this.pnlDonateurInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlDonateurInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDonateurInfo.Controls.Add(this.cbBoxDonateurIdExistant);
            this.pnlDonateurInfo.Controls.Add(this.lblDonateur);
            this.pnlDonateurInfo.Controls.Add(this.txtTelephoneDonateur);
            this.pnlDonateurInfo.Controls.Add(this.lblTelephoneDonateur);
            this.pnlDonateurInfo.Controls.Add(this.txtCourrielDonateur);
            this.pnlDonateurInfo.Controls.Add(this.lblCourrielDonateur);
            this.pnlDonateurInfo.Controls.Add(this.txtNomDonateur);
            this.pnlDonateurInfo.Controls.Add(this.lblNomDonateur);
            this.pnlDonateurInfo.Controls.Add(this.txtPrenomDonateur);
            this.pnlDonateurInfo.Controls.Add(this.lblPrenomDonateur);
            this.pnlDonateurInfo.Controls.Add(this.txtIdDonateur);
            this.pnlDonateurInfo.Controls.Add(this.lblIdDonateur);
            this.pnlDonateurInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDonateurInfo.Location = new System.Drawing.Point(3, 3);
            this.pnlDonateurInfo.Name = "pnlDonateurInfo";
            this.pnlDonateurInfo.Size = new System.Drawing.Size(599, 357);
            this.pnlDonateurInfo.TabIndex = 35;
            // 
            // cbBoxDonateurIdExistant
            // 
            this.cbBoxDonateurIdExistant.FormattingEnabled = true;
            this.cbBoxDonateurIdExistant.Location = new System.Drawing.Point(359, 139);
            this.cbBoxDonateurIdExistant.Name = "cbBoxDonateurIdExistant";
            this.cbBoxDonateurIdExistant.Size = new System.Drawing.Size(112, 21);
            this.cbBoxDonateurIdExistant.TabIndex = 31;
            this.cbBoxDonateurIdExistant.SelectedIndexChanged += new System.EventHandler(this.cbBoxDonateurIdExistant_SelectedIndexChanged);
            // 
            // lblDonateur
            // 
            this.lblDonateur.AutoSize = true;
            this.lblDonateur.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonateur.Location = new System.Drawing.Point(160, 72);
            this.lblDonateur.Name = "lblDonateur";
            this.lblDonateur.Size = new System.Drawing.Size(311, 31);
            this.lblDonateur.TabIndex = 30;
            this.lblDonateur.Text = "Information du Donateur";
            // 
            // txtTelephoneDonateur
            // 
            this.txtTelephoneDonateur.Location = new System.Drawing.Point(286, 300);
            this.txtTelephoneDonateur.MaxLength = 10;
            this.txtTelephoneDonateur.Name = "txtTelephoneDonateur";
            this.txtTelephoneDonateur.Size = new System.Drawing.Size(182, 20);
            this.txtTelephoneDonateur.TabIndex = 29;
            this.ttDonateur.SetToolTip(this.txtTelephoneDonateur, "Format de téléphone est de 10 chiffe sans espace.\r\ne.g : 12345671234\r\n");
            // 
            // lblTelephoneDonateur
            // 
            this.lblTelephoneDonateur.AutoSize = true;
            this.lblTelephoneDonateur.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephoneDonateur.Location = new System.Drawing.Point(125, 300);
            this.lblTelephoneDonateur.Name = "lblTelephoneDonateur";
            this.lblTelephoneDonateur.Size = new System.Drawing.Size(100, 24);
            this.lblTelephoneDonateur.TabIndex = 28;
            this.lblTelephoneDonateur.Text = "Telephone";
            // 
            // txtCourrielDonateur
            // 
            this.txtCourrielDonateur.Location = new System.Drawing.Point(287, 260);
            this.txtCourrielDonateur.Name = "txtCourrielDonateur";
            this.txtCourrielDonateur.Size = new System.Drawing.Size(182, 20);
            this.txtCourrielDonateur.TabIndex = 27;
            this.ttDonateur.SetToolTip(this.txtCourrielDonateur, "Le format du Courriel contien votre pseudo avec le domain de votre courriel\r\ne.g " +
        ": Pseudo@domain.com");
            this.txtCourrielDonateur.Leave += new System.EventHandler(this.txtCourrielDonateur_Leave);
            // 
            // lblCourrielDonateur
            // 
            this.lblCourrielDonateur.AutoSize = true;
            this.lblCourrielDonateur.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourrielDonateur.Location = new System.Drawing.Point(125, 260);
            this.lblCourrielDonateur.Name = "lblCourrielDonateur";
            this.lblCourrielDonateur.Size = new System.Drawing.Size(83, 24);
            this.lblCourrielDonateur.TabIndex = 26;
            this.lblCourrielDonateur.Text = "Courriel";
            // 
            // txtNomDonateur
            // 
            this.txtNomDonateur.Location = new System.Drawing.Point(286, 220);
            this.txtNomDonateur.Name = "txtNomDonateur";
            this.txtNomDonateur.Size = new System.Drawing.Size(183, 20);
            this.txtNomDonateur.TabIndex = 25;
            // 
            // lblNomDonateur
            // 
            this.lblNomDonateur.AutoSize = true;
            this.lblNomDonateur.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomDonateur.Location = new System.Drawing.Point(125, 220);
            this.lblNomDonateur.Name = "lblNomDonateur";
            this.lblNomDonateur.Size = new System.Drawing.Size(53, 24);
            this.lblNomDonateur.TabIndex = 24;
            this.lblNomDonateur.Text = "Nom";
            // 
            // txtPrenomDonateur
            // 
            this.txtPrenomDonateur.Location = new System.Drawing.Point(287, 180);
            this.txtPrenomDonateur.Name = "txtPrenomDonateur";
            this.txtPrenomDonateur.Size = new System.Drawing.Size(182, 20);
            this.txtPrenomDonateur.TabIndex = 23;
            // 
            // lblPrenomDonateur
            // 
            this.lblPrenomDonateur.AutoSize = true;
            this.lblPrenomDonateur.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenomDonateur.Location = new System.Drawing.Point(125, 180);
            this.lblPrenomDonateur.Name = "lblPrenomDonateur";
            this.lblPrenomDonateur.Size = new System.Drawing.Size(81, 24);
            this.lblPrenomDonateur.TabIndex = 22;
            this.lblPrenomDonateur.Text = "Prenom";
            // 
            // txtIdDonateur
            // 
            this.txtIdDonateur.Enabled = false;
            this.txtIdDonateur.Location = new System.Drawing.Point(286, 140);
            this.txtIdDonateur.Name = "txtIdDonateur";
            this.txtIdDonateur.Size = new System.Drawing.Size(52, 20);
            this.txtIdDonateur.TabIndex = 21;
            // 
            // lblIdDonateur
            // 
            this.lblIdDonateur.AutoSize = true;
            this.lblIdDonateur.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDonateur.Location = new System.Drawing.Point(125, 140);
            this.lblIdDonateur.Name = "lblIdDonateur";
            this.lblIdDonateur.Size = new System.Drawing.Size(32, 24);
            this.lblIdDonateur.TabIndex = 20;
            this.lblIdDonateur.Text = "ID";
            // 
            // tabDonateurCarte
            // 
            this.tabDonateurCarte.Controls.Add(this.pnlDonateurCarte);
            this.tabDonateurCarte.Location = new System.Drawing.Point(4, 22);
            this.tabDonateurCarte.Name = "tabDonateurCarte";
            this.tabDonateurCarte.Padding = new System.Windows.Forms.Padding(3);
            this.tabDonateurCarte.Size = new System.Drawing.Size(605, 363);
            this.tabDonateurCarte.TabIndex = 1;
            this.tabDonateurCarte.Text = "donateurCarteTab";
            this.tabDonateurCarte.UseVisualStyleBackColor = true;
            // 
            // pnlDonateurCarte
            // 
            this.pnlDonateurCarte.BackColor = System.Drawing.Color.Transparent;
            this.pnlDonateurCarte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDonateurCarte.Controls.Add(this.txtDonateurCvs);
            this.pnlDonateurCarte.Controls.Add(this.lblCvs);
            this.pnlDonateurCarte.Controls.Add(this.lblCarte);
            this.pnlDonateurCarte.Controls.Add(this.cbCCExpAnnee);
            this.pnlDonateurCarte.Controls.Add(this.rbtnVisa);
            this.pnlDonateurCarte.Controls.Add(this.txtNumeroDonateur);
            this.pnlDonateurCarte.Controls.Add(this.rbtnMcard);
            this.pnlDonateurCarte.Controls.Add(this.lblExpireDonateur);
            this.pnlDonateurCarte.Controls.Add(this.lblNumeroDonateur);
            this.pnlDonateurCarte.Controls.Add(this.rbtnAexpress);
            this.pnlDonateurCarte.Controls.Add(this.cbCCExpMois);
            this.pnlDonateurCarte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDonateurCarte.Location = new System.Drawing.Point(3, 3);
            this.pnlDonateurCarte.Name = "pnlDonateurCarte";
            this.pnlDonateurCarte.Size = new System.Drawing.Size(599, 357);
            this.pnlDonateurCarte.TabIndex = 30;
            this.pnlDonateurCarte.Visible = false;
            // 
            // txtDonateurCvs
            // 
            this.txtDonateurCvs.Location = new System.Drawing.Point(245, 293);
            this.txtDonateurCvs.MaxLength = 3;
            this.txtDonateurCvs.Name = "txtDonateurCvs";
            this.txtDonateurCvs.Size = new System.Drawing.Size(58, 20);
            this.txtDonateurCvs.TabIndex = 33;
            // 
            // lblCvs
            // 
            this.lblCvs.AutoSize = true;
            this.lblCvs.BackColor = System.Drawing.Color.Transparent;
            this.lblCvs.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCvs.Location = new System.Drawing.Point(66, 293);
            this.lblCvs.Name = "lblCvs";
            this.lblCvs.Size = new System.Drawing.Size(52, 24);
            this.lblCvs.TabIndex = 32;
            this.lblCvs.Text = "CVS";
            // 
            // lblCarte
            // 
            this.lblCarte.AutoSize = true;
            this.lblCarte.BackColor = System.Drawing.Color.Transparent;
            this.lblCarte.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarte.Location = new System.Drawing.Point(160, 72);
            this.lblCarte.Name = "lblCarte";
            this.lblCarte.Size = new System.Drawing.Size(347, 31);
            this.lblCarte.TabIndex = 31;
            this.lblCarte.Text = "Information Carte de Credit";
            // 
            // cbCCExpAnnee
            // 
            this.cbCCExpAnnee.FormattingEnabled = true;
            this.cbCCExpAnnee.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027"});
            this.cbCCExpAnnee.Location = new System.Drawing.Point(373, 242);
            this.cbCCExpAnnee.Name = "cbCCExpAnnee";
            this.cbCCExpAnnee.Size = new System.Drawing.Size(121, 21);
            this.cbCCExpAnnee.TabIndex = 11;
            // 
            // rbtnVisa
            // 
            this.rbtnVisa.BackColor = System.Drawing.Color.Transparent;
            this.rbtnVisa.Checked = true;
            this.rbtnVisa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnVisa.Image = ((System.Drawing.Image)(resources.GetObject("rbtnVisa.Image")));
            this.rbtnVisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtnVisa.Location = new System.Drawing.Point(68, 126);
            this.rbtnVisa.Name = "rbtnVisa";
            this.rbtnVisa.Size = new System.Drawing.Size(102, 40);
            this.rbtnVisa.TabIndex = 0;
            this.rbtnVisa.TabStop = true;
            this.rbtnVisa.Text = "Visa";
            this.rbtnVisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnVisa.UseVisualStyleBackColor = false;
            // 
            // txtNumeroDonateur
            // 
            this.txtNumeroDonateur.Location = new System.Drawing.Point(245, 187);
            this.txtNumeroDonateur.MaxLength = 16;
            this.txtNumeroDonateur.Name = "txtNumeroDonateur";
            this.txtNumeroDonateur.Size = new System.Drawing.Size(313, 20);
            this.txtNumeroDonateur.TabIndex = 8;
            this.ttDonateur.SetToolTip(this.txtNumeroDonateur, "Format de carte de credit est de 16 chiffe sans espace\r\ne.g : 1234567891234567\r\n");
            // 
            // rbtnMcard
            // 
            this.rbtnMcard.BackColor = System.Drawing.Color.Transparent;
            this.rbtnMcard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMcard.Image = ((System.Drawing.Image)(resources.GetObject("rbtnMcard.Image")));
            this.rbtnMcard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtnMcard.Location = new System.Drawing.Point(205, 129);
            this.rbtnMcard.Name = "rbtnMcard";
            this.rbtnMcard.Size = new System.Drawing.Size(160, 40);
            this.rbtnMcard.TabIndex = 1;
            this.rbtnMcard.Text = "Master Card";
            this.rbtnMcard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnMcard.UseVisualStyleBackColor = false;
            // 
            // lblExpireDonateur
            // 
            this.lblExpireDonateur.AutoSize = true;
            this.lblExpireDonateur.BackColor = System.Drawing.Color.Transparent;
            this.lblExpireDonateur.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpireDonateur.Location = new System.Drawing.Point(66, 237);
            this.lblExpireDonateur.Name = "lblExpireDonateur";
            this.lblExpireDonateur.Size = new System.Drawing.Size(168, 24);
            this.lblExpireDonateur.TabIndex = 9;
            this.lblExpireDonateur.Text = "Date d\'Expiration";
            // 
            // lblNumeroDonateur
            // 
            this.lblNumeroDonateur.AutoSize = true;
            this.lblNumeroDonateur.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroDonateur.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDonateur.Location = new System.Drawing.Point(66, 183);
            this.lblNumeroDonateur.Name = "lblNumeroDonateur";
            this.lblNumeroDonateur.Size = new System.Drawing.Size(82, 24);
            this.lblNumeroDonateur.TabIndex = 7;
            this.lblNumeroDonateur.Text = "Numero";
            // 
            // rbtnAexpress
            // 
            this.rbtnAexpress.BackColor = System.Drawing.Color.Transparent;
            this.rbtnAexpress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAexpress.Image = ((System.Drawing.Image)(resources.GetObject("rbtnAexpress.Image")));
            this.rbtnAexpress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtnAexpress.Location = new System.Drawing.Point(386, 126);
            this.rbtnAexpress.Name = "rbtnAexpress";
            this.rbtnAexpress.Size = new System.Drawing.Size(200, 40);
            this.rbtnAexpress.TabIndex = 2;
            this.rbtnAexpress.Text = "American Express";
            this.rbtnAexpress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnAexpress.UseVisualStyleBackColor = false;
            // 
            // cbCCExpMois
            // 
            this.cbCCExpMois.FormattingEnabled = true;
            this.cbCCExpMois.Items.AddRange(new object[] {
            "Janvier",
            "Fevrier",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Aout",
            "Septembre",
            "Octobre",
            "Novembre",
            "Decembre"});
            this.cbCCExpMois.Location = new System.Drawing.Point(246, 242);
            this.cbCCExpMois.Name = "cbCCExpMois";
            this.cbCCExpMois.Size = new System.Drawing.Size(121, 21);
            this.cbCCExpMois.TabIndex = 10;
            // 
            // tabDonateurDon
            // 
            this.tabDonateurDon.Controls.Add(this.lblPoints);
            this.tabDonateurDon.Controls.Add(this.picPrix);
            this.tabDonateurDon.Controls.Add(this.dtpDon);
            this.tabDonateurDon.Controls.Add(this.lblDateDonateur);
            this.tabDonateurDon.Controls.Add(this.lblInfoDonateur);
            this.tabDonateurDon.Controls.Add(this.txtMontantDonateur);
            this.tabDonateurDon.Controls.Add(this.lblMontantDonateur);
            this.tabDonateurDon.Location = new System.Drawing.Point(4, 22);
            this.tabDonateurDon.Name = "tabDonateurDon";
            this.tabDonateurDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabDonateurDon.Size = new System.Drawing.Size(605, 363);
            this.tabDonateurDon.TabIndex = 3;
            this.tabDonateurDon.Text = "tabDonateurDon";
            this.tabDonateurDon.UseVisualStyleBackColor = true;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(135, 246);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(55, 13);
            this.lblPoints.TabIndex = 35;
            this.lblPoints.Text = "lblPoints";
            // 
            // picPrix
            // 
            this.picPrix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPrix.Image = global::Project_Integrateur.Properties.Resources.MicrosoftTeams_image;
            this.picPrix.Location = new System.Drawing.Point(531, 17);
            this.picPrix.Name = "picPrix";
            this.picPrix.Size = new System.Drawing.Size(60, 57);
            this.picPrix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrix.TabIndex = 34;
            this.picPrix.TabStop = false;
            this.ttDonateur.SetToolTip(this.picPrix, "Cliquer ici pour attribuer vos prix");
            this.picPrix.Click += new System.EventHandler(this.picPrix_Click);
            // 
            // dtpDon
            // 
            this.dtpDon.Location = new System.Drawing.Point(294, 201);
            this.dtpDon.Name = "dtpDon";
            this.dtpDon.Size = new System.Drawing.Size(183, 20);
            this.dtpDon.TabIndex = 33;
            // 
            // lblDateDonateur
            // 
            this.lblDateDonateur.AutoSize = true;
            this.lblDateDonateur.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDonateur.Location = new System.Drawing.Point(134, 197);
            this.lblDateDonateur.Name = "lblDateDonateur";
            this.lblDateDonateur.Size = new System.Drawing.Size(122, 24);
            this.lblDateDonateur.TabIndex = 32;
            this.lblDateDonateur.Text = "Date du Don";
            // 
            // lblInfoDonateur
            // 
            this.lblInfoDonateur.AutoSize = true;
            this.lblInfoDonateur.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDonateur.Location = new System.Drawing.Point(235, 77);
            this.lblInfoDonateur.Name = "lblInfoDonateur";
            this.lblInfoDonateur.Size = new System.Drawing.Size(160, 31);
            this.lblInfoDonateur.TabIndex = 31;
            this.lblInfoDonateur.Text = "Ajouter Don";
            // 
            // txtMontantDonateur
            // 
            this.txtMontantDonateur.Location = new System.Drawing.Point(294, 162);
            this.txtMontantDonateur.Name = "txtMontantDonateur";
            this.txtMontantDonateur.Size = new System.Drawing.Size(183, 20);
            this.txtMontantDonateur.TabIndex = 29;
            this.txtMontantDonateur.TextChanged += new System.EventHandler(this.txtMontantDonateur_TextChanged);
            // 
            // lblMontantDonateur
            // 
            this.lblMontantDonateur.AutoSize = true;
            this.lblMontantDonateur.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantDonateur.Location = new System.Drawing.Point(134, 157);
            this.lblMontantDonateur.Name = "lblMontantDonateur";
            this.lblMontantDonateur.Size = new System.Drawing.Size(87, 24);
            this.lblMontantDonateur.TabIndex = 28;
            this.lblMontantDonateur.Text = "Montant";
            // 
            // tabDonateurResume
            // 
            this.tabDonateurResume.Controls.Add(this.pnlDonateurResume);
            this.tabDonateurResume.Location = new System.Drawing.Point(4, 22);
            this.tabDonateurResume.Name = "tabDonateurResume";
            this.tabDonateurResume.Padding = new System.Windows.Forms.Padding(3);
            this.tabDonateurResume.Size = new System.Drawing.Size(605, 363);
            this.tabDonateurResume.TabIndex = 2;
            this.tabDonateurResume.Text = "donateurResume";
            this.tabDonateurResume.UseVisualStyleBackColor = true;
            // 
            // pnlDonateurResume
            // 
            this.pnlDonateurResume.BackColor = System.Drawing.Color.Transparent;
            this.pnlDonateurResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDonateurResume.Controls.Add(this.lboxDonateur);
            this.pnlDonateurResume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDonateurResume.Location = new System.Drawing.Point(3, 3);
            this.pnlDonateurResume.Name = "pnlDonateurResume";
            this.pnlDonateurResume.Size = new System.Drawing.Size(599, 357);
            this.pnlDonateurResume.TabIndex = 30;
            this.pnlDonateurResume.Visible = false;
            // 
            // lboxDonateur
            // 
            this.lboxDonateur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxDonateur.FormattingEnabled = true;
            this.lboxDonateur.ItemHeight = 19;
            this.lboxDonateur.Location = new System.Drawing.Point(43, 44);
            this.lboxDonateur.Name = "lboxDonateur";
            this.lboxDonateur.Size = new System.Drawing.Size(304, 270);
            this.lboxDonateur.TabIndex = 0;
            // 
            // frmDonateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlHidden);
            this.Controls.Add(this.pnlNavigation);
            this.Name = "frmDonateur";
            this.Size = new System.Drawing.Size(973, 577);
            this.Load += new System.EventHandler(this.frmDonateur_Load);
            this.pnlNavigation.ResumeLayout(false);
            this.tabControlHidden.ResumeLayout(false);
            this.tabDonateurInfo.ResumeLayout(false);
            this.pnlDonateurInfo.ResumeLayout(false);
            this.pnlDonateurInfo.PerformLayout();
            this.tabDonateurCarte.ResumeLayout(false);
            this.pnlDonateurCarte.ResumeLayout(false);
            this.pnlDonateurCarte.PerformLayout();
            this.tabDonateurDon.ResumeLayout(false);
            this.tabDonateurDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrix)).EndInit();
            this.tabDonateurResume.ResumeLayout(false);
            this.pnlDonateurResume.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDonateurSuivant;
        private System.Windows.Forms.Button btnDonateurPrecedent;
        private System.Windows.Forms.Button btnDonateurSauve;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.TabControl tabControlHidden;
        private System.Windows.Forms.TabPage tabDonateurInfo;
        private System.Windows.Forms.Panel pnlDonateurInfo;
        private System.Windows.Forms.TextBox txtTelephoneDonateur;
        private System.Windows.Forms.Label lblTelephoneDonateur;
        private System.Windows.Forms.TextBox txtCourrielDonateur;
        private System.Windows.Forms.Label lblCourrielDonateur;
        private System.Windows.Forms.TextBox txtNomDonateur;
        private System.Windows.Forms.Label lblNomDonateur;
        private System.Windows.Forms.TextBox txtPrenomDonateur;
        private System.Windows.Forms.Label lblPrenomDonateur;
        private System.Windows.Forms.TextBox txtIdDonateur;
        private System.Windows.Forms.Label lblIdDonateur;
        private System.Windows.Forms.TabPage tabDonateurCarte;
        private System.Windows.Forms.TabPage tabDonateurResume;
        private System.Windows.Forms.Panel pnlDonateurResume;
        private System.Windows.Forms.Panel pnlDonateurCarte;
        private System.Windows.Forms.ComboBox cbCCExpAnnee;
        private System.Windows.Forms.RadioButton rbtnAexpress;
        private System.Windows.Forms.ComboBox cbCCExpMois;
        private System.Windows.Forms.RadioButton rbtnMcard;
        private System.Windows.Forms.Label lblExpireDonateur;
        private System.Windows.Forms.RadioButton rbtnVisa;
        private System.Windows.Forms.TextBox txtNumeroDonateur;
        private System.Windows.Forms.Label lblNumeroDonateur;
        private System.Windows.Forms.Label lblDonateur;
        private System.Windows.Forms.Label lblCarte;
        private System.Windows.Forms.TextBox txtDonateurCvs;
        private System.Windows.Forms.Label lblCvs;
        private System.Windows.Forms.ListBox lboxDonateur;
        private System.Windows.Forms.TabPage tabDonateurDon;
        private System.Windows.Forms.DateTimePicker dtpDon;
        private System.Windows.Forms.Label lblDateDonateur;
        private System.Windows.Forms.Label lblInfoDonateur;
        private System.Windows.Forms.TextBox txtMontantDonateur;
        private System.Windows.Forms.Label lblMontantDonateur;
        private System.Windows.Forms.ComboBox cbBoxDonateurIdExistant;
        private System.Windows.Forms.PictureBox picPrix;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.ToolTip ttDonateur;
    }
}
