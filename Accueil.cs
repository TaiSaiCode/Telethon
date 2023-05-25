using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Integrateur
{
    
    public partial class Accueil : Form
    {
        private Form depConn;
        private Button[] buttonsToColor;

        public Accueil(Form depConnexion)
        {
            InitializeComponent();
            depConn = depConnexion;
            depConn.Hide();
            this.Show();

            buttonsToColor = new Button[] { btnAccueil, btnDonateur, btnCommanditaire, btnAffichage, btnPropos };
            foreach (Button button in buttonsToColor)
                button.Click += Color_Buttons_onClick;
        }

        public void Color_Buttons_onClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor == Color.Blue)
                foreach (Button b in buttonsToColor)
                    b.BackColor = b == button ? Color.RoyalBlue : Color.Blue;
        }

        private void btnDonateur_Click(object sender, EventArgs e) {
            frmDonateur objDonateur = new frmDonateur(); 
            pnlMain.Controls.Add(objDonateur);
            objDonateur.BringToFront();
            objDonateur.Show();
        }

        private void btnAccueil_Click(object sender, EventArgs e) {
            frmAccueil objAccueil = new frmAccueil();
            pnlMain.Controls.Add(objAccueil);
            objAccueil.BringToFront();
            objAccueil.Show();
        }

        private void btnCommanditaire_Click(object sender, EventArgs e) {
            frmCommanditaire objCommenditaire = new frmCommanditaire();
            pnlMain.Controls.Add(objCommenditaire);
            objCommenditaire.BringToFront();
            objCommenditaire.Show();
        }

        private void btnAffichage_Click(object sender, EventArgs e) {
            frmAffichage objAffichage = new frmAffichage();
            pnlMain.Controls.Add(objAffichage);
            objAffichage.BringToFront();
            objAffichage.Show();
        }

        private void btnPropos_Click(object sender, EventArgs e) {
            frmPropos objPropos = new frmPropos();
            pnlMain.Controls.Add(objPropos);
            objPropos.BringToFront();
            objPropos.Show();
        }

        private void picFermer_Click(object sender, EventArgs e)
        {
            depConn.Show();
            Close();
        }

        private void btnAccueil_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnAccueil.BackColor = Color.RoyalBlue;
        }
    }
}
