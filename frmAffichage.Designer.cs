namespace Project_Integrateur
{
    partial class frmAffichage
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
            this.btnAfficheDonateur = new System.Windows.Forms.Button();
            this.btnAfficheDon = new System.Windows.Forms.Button();
            this.btnAfficheCommenditaire = new System.Windows.Forms.Button();
            this.btnAffichePrix = new System.Windows.Forms.Button();
            this.dataAffichage = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataAffichage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAfficheDonateur
            // 
            this.btnAfficheDonateur.BackColor = System.Drawing.Color.Blue;
            this.btnAfficheDonateur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficheDonateur.ForeColor = System.Drawing.Color.White;
            this.btnAfficheDonateur.Location = new System.Drawing.Point(23, 30);
            this.btnAfficheDonateur.Name = "btnAfficheDonateur";
            this.btnAfficheDonateur.Size = new System.Drawing.Size(128, 43);
            this.btnAfficheDonateur.TabIndex = 3;
            this.btnAfficheDonateur.Text = "Donnateurs";
            this.btnAfficheDonateur.UseVisualStyleBackColor = false;
            this.btnAfficheDonateur.Click += new System.EventHandler(this.btnAfficheDonateur_Click);
            // 
            // btnAfficheDon
            // 
            this.btnAfficheDon.BackColor = System.Drawing.Color.Blue;
            this.btnAfficheDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficheDon.ForeColor = System.Drawing.Color.White;
            this.btnAfficheDon.Location = new System.Drawing.Point(181, 30);
            this.btnAfficheDon.Name = "btnAfficheDon";
            this.btnAfficheDon.Size = new System.Drawing.Size(128, 43);
            this.btnAfficheDon.TabIndex = 4;
            this.btnAfficheDon.Text = "Don";
            this.btnAfficheDon.UseVisualStyleBackColor = false;
            this.btnAfficheDon.Click += new System.EventHandler(this.btnAfficheDon_Click);
            // 
            // btnAfficheCommenditaire
            // 
            this.btnAfficheCommenditaire.BackColor = System.Drawing.Color.Blue;
            this.btnAfficheCommenditaire.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficheCommenditaire.ForeColor = System.Drawing.Color.White;
            this.btnAfficheCommenditaire.Location = new System.Drawing.Point(335, 30);
            this.btnAfficheCommenditaire.Name = "btnAfficheCommenditaire";
            this.btnAfficheCommenditaire.Size = new System.Drawing.Size(128, 43);
            this.btnAfficheCommenditaire.TabIndex = 5;
            this.btnAfficheCommenditaire.Text = "Commanditaire";
            this.btnAfficheCommenditaire.UseVisualStyleBackColor = false;
            this.btnAfficheCommenditaire.Click += new System.EventHandler(this.btnAfficheCommenditaire_Click);
            // 
            // btnAffichePrix
            // 
            this.btnAffichePrix.BackColor = System.Drawing.Color.Blue;
            this.btnAffichePrix.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAffichePrix.ForeColor = System.Drawing.Color.White;
            this.btnAffichePrix.Location = new System.Drawing.Point(497, 30);
            this.btnAffichePrix.Name = "btnAffichePrix";
            this.btnAffichePrix.Size = new System.Drawing.Size(128, 43);
            this.btnAffichePrix.TabIndex = 6;
            this.btnAffichePrix.Text = "Prix";
            this.btnAffichePrix.UseVisualStyleBackColor = false;
            this.btnAffichePrix.Click += new System.EventHandler(this.btnAffichePrix_Click);
            // 
            // dataAffichage
            // 
            this.dataAffichage.AllowUserToAddRows = false;
            this.dataAffichage.AllowUserToDeleteRows = false;
            this.dataAffichage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAffichage.Location = new System.Drawing.Point(23, 103);
            this.dataAffichage.Name = "dataAffichage";
            this.dataAffichage.ReadOnly = true;
            this.dataAffichage.Size = new System.Drawing.Size(602, 287);
            this.dataAffichage.TabIndex = 7;
            // 
            // frmAffichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataAffichage);
            this.Controls.Add(this.btnAffichePrix);
            this.Controls.Add(this.btnAfficheCommenditaire);
            this.Controls.Add(this.btnAfficheDon);
            this.Controls.Add(this.btnAfficheDonateur);
            this.Name = "frmAffichage";
            this.Size = new System.Drawing.Size(687, 439);
            ((System.ComponentModel.ISupportInitialize)(this.dataAffichage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfficheDonateur;
        private System.Windows.Forms.Button btnAfficheDon;
        private System.Windows.Forms.Button btnAfficheCommenditaire;
        private System.Windows.Forms.Button btnAffichePrix;
        private System.Windows.Forms.DataGridView dataAffichage;
    }
}
