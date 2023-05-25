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
    public partial class frmDonnerPrix : Form
    {
        private OutilsData fichier_donateurs = new OutilsData("donateurs.txt");
        private OutilsData fichier_prix = new OutilsData("prix.txt");
        private int points_donateur;
        private int id_donateur_actuel;
        private Label label;

        public frmDonnerPrix(string id, string prenom, string nom, string points, Label label)
        {
            InitializeComponent();
            MaximumSize = new Size(Width,Height);
            MinimumSize = new Size(Width, Height);
            

            lblIdentif.Text = id + " : " + prenom + " " + nom;
            lblPts.Text = points + " pts";

            points_donateur = int.Parse(points);
            id_donateur_actuel = int.Parse(id);

            this.label = label;
            
            ShowDialog();
        }

        private void updateList()
        {
            lstPrix.Items.Clear();
            foreach (string s in fichier_prix.TextLines)
            {
                string[] tab = s.Split(';');//0=id,1=id_comm,2=nom_prix,3=valeur_prix,4=quantité

                //
                //****************************************************************************************
                //**************** NE PAS OUBLIER D'ÉTABLIR LES RATIOS DE $ ET PTS ***********************
                //****************************************************************************************
                //
                int pts_prix = int.Parse(tab[3].Replace("$", ""));// modifier le ratio pour les proportionnalités (montant $ vs points)

                if (points_donateur >= pts_prix)
                {
                    if (int.Parse(tab[4]) > 0)
                        lstPrix.Items.Add(tab[0] + " - " + tab[2] + " - " + tab[3] + " - " + tab[4]);
                }
            }
        }

        private void frmDonnerPrix_Load(object sender, EventArgs e)
        {
            updateList();
        }

        public static int convertMoneyToPoints(int montant)
        {
            if (Outils.IsBetween(montant, 50, true, 200, false))
                return 1;
            if (Outils.IsBetween(montant, 200, true, 350, false))
                return 2;
            if (Outils.IsBetween(montant, 350, true, 500, false))
                return 3;
            if (montant >= 500)
                return 5 + ((int)((montant - 500) / 500)) * 4;

            return 0;
        }

        private void btnAttribuer_Click(object sender, EventArgs e)
        {
            if (lstPrix.SelectedIndex == -1)
                return;

            string s = lstPrix.Text;//prend toute la ligne sélectionnée du listbox
            int qte = int.Parse(s.Substring(s.LastIndexOf(' ') + 1))-1;//quantité
            
            s = s.Substring(0, s.LastIndexOf(" -"));//substring du début de la ligne jusqu'au " -" exclus
            s = s.Substring(s.LastIndexOf(' ')+1);//substring qui commence au dernier espace
            MessageBox.Show("Prix Attribué");
            int prix_a_retirer = int.Parse(s);

            points_donateur -= prix_a_retirer;
            lblPts.Text = points_donateur + " pts";

            //
            // Update le label
            //
            label.Text = points_donateur + " pts";

            //
            // Update les quantités
            //
            int id_prix = int.Parse(lstPrix.Text.Substring(0, lstPrix.Text.IndexOf(' ')));

            fichier_prix.changeValueAt(id_prix, 4, qte + "");

            updateList();

            //
            // Update le donnateur
            //
            fichier_donateurs.changeValueAt(fichier_donateurs.getLineIndexStartingBy(id_donateur_actuel + ";"), 10, points_donateur + "");
        }

        private void lstPrix_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAttribuer.Enabled = lstPrix.SelectedIndex != -1;
        }
    }
}
