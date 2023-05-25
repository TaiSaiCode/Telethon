using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Project_Integrateur
{
    public partial class Connexion : Form
    {
        private const string USERNAME = "Téléthon2022";
        private const string PASSWORD = "Don@2022";
        public Connexion()
        {
            InitializeComponent();

            txtUtilisateur.TextChanged += textbox_TextChanged;
            txtMotPasse.TextChanged += textbox_TextChanged;


        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            btnConnexion.Enabled = txtMotPasse.TextLength * txtUtilisateur.TextLength > 0;
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if(txtUtilisateur.Text==USERNAME && txtMotPasse.Text == PASSWORD)
            {
                txtMotPasse.Text = "";
                new Accueil(this);
            }
            else
                MessageBox.Show("Utilisateur ou mot de passe invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
            
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // On s'assure que c'est bien l'intention de l'utilisateur de quitter l'application
            DialogResult reponse = MessageBox.Show("Désirez-vous réellement quitter cette application ? ", "Attention",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            // Si tel est le cas, on met fin à l'application.
            if (reponse == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
