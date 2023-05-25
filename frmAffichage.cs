using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Integrateur
{
    public partial class frmAffichage : UserControl
    {
        private Button[] buttonsToColor;

        public frmAffichage()
        {
            InitializeComponent();
            buttonsToColor = new Button[] { btnAfficheCommenditaire, btnAfficheDon,btnAfficheDonateur,btnAffichePrix};
            foreach (Button button in buttonsToColor)
                button.Click += Color_buttons_onClick;
        }

        private void Color_buttons_onClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor==Color.Blue)
                foreach (Button b in buttonsToColor)
                    b.BackColor = b == button ? Color.RoyalBlue : Color.Blue;
        }

        private void btnAfficheDonateur_Click(object sender, EventArgs e)
        {
            //On efface les colonne precedent
            dataAffichage.Columns.Clear();
            //On Ajoute les colonne dans le datagridview
            dataAffichage.Columns.Add("colID", "ID");
            dataAffichage.Columns.Add("colPrenom", "Prenom");
            dataAffichage.Columns.Add("colNom", "Nom");
            dataAffichage.Columns.Add("colCourriel", "Courriel");
            dataAffichage.Columns.Add("colTelephone", "Telephone");
            dataAffichage.Columns.Add("colCarte", "Carte");
            dataAffichage.Columns.Add("colNumCarte", "Numero Carte");
            dataAffichage.Columns.Add("colMois", "Mois");
            dataAffichage.Columns.Add("colAnnee", "Annee");
            dataAffichage.Columns.Add("colCVS", "CVS");
            dataAffichage.Columns.Add("colPoints", "Points");

            // Import les donner du fichier donateurs.txt dans le datagridview ligne par ligne
            using (var streamReader = new StreamReader("../../Data/donateurs.txt"))
            {
                dataAffichage.Rows.Clear();
                dataAffichage.Refresh();
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();
                    var values = line.Split(';');
                    var rowIndex = dataAffichage.Rows.Add();
                    for (int i = 0; i < values.Length; i++)
                    {
                        dataAffichage.Rows[rowIndex].Cells[i].Value = values[i];
                    }
                }

            }
            
        }

        private void btnAfficheDon_Click(object sender, EventArgs e)
        {
            //On efface les colonne precedent
            dataAffichage.Columns.Clear();
            //On Ajoute les colonne dans le datagridview
            dataAffichage.Columns.Add("colIDDon", "ID");
            dataAffichage.Columns.Add("colIdDonateur", "ID Donateur");
            dataAffichage.Columns.Add("colMontant", "Montant");
            dataAffichage.Columns.Add("colDate", "Date");

            // Import les donner du fichier dons.txt dans le datagridview ligne par ligne
            using (var streamReader = new StreamReader("../../Data/dons.txt"))
            {
                dataAffichage.Rows.Clear();
                dataAffichage.Refresh();
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();
                    var values = line.Split(';');
                    var rowIndex = dataAffichage.Rows.Add();
                    for (int i = 0; i < values.Length; i++)
                    {
                        dataAffichage.Rows[rowIndex].Cells[i].Value = values[i];
                    }
                }

            }
        }

        private void btnAfficheCommenditaire_Click(object sender, EventArgs e)
        {
            //On efface les colonne precedent
            dataAffichage.Columns.Clear();
            //On Ajoute les colonne dans le datagridview
            dataAffichage.Columns.Add("colIDCommenditaire", "ID");
            dataAffichage.Columns.Add("colPrenom", "Prenom");
            dataAffichage.Columns.Add("colNom", "Nom");

            // Import les donner du fichier dons.txt dans le datagridview ligne par ligne
            using (var streamReader = new StreamReader("../../Data/commanditaires.txt"))
            {
                dataAffichage.Rows.Clear();
                dataAffichage.Refresh();
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();
                    var values = line.Split(';');
                    var rowIndex = dataAffichage.Rows.Add();
                    for (int i = 0; i < 3; i++)
                    {
                        dataAffichage.Rows[rowIndex].Cells[i].Value = values[i];
                    }
                }

            }
        }

        private void btnAffichePrix_Click(object sender, EventArgs e)
        {
            //On efface les colonne precedent
            dataAffichage.Columns.Clear();
            //On Ajoute les colonne dans le datagridview
            dataAffichage.Columns.Add("colIDPrix", "ID");
            dataAffichage.Columns.Add("colIDCommenditaire", "ID Commanditaire");
            dataAffichage.Columns.Add("colArticle", "Article");
            dataAffichage.Columns.Add("colValeur", "Valeur");
            dataAffichage.Columns.Add("colQuantite", "Quantite");

            // Import les donner du fichier dons.txt dans le datagridview ligne par ligne
            using (var streamReader = new StreamReader("../../Data/prix.txt"))
            {
                dataAffichage.Rows.Clear();
                dataAffichage.Refresh();
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();
                    var values = line.Split(';');
                    var rowIndex = dataAffichage.Rows.Add();
                    for (int i = 0; i < values.Length; i++)
                    {
                        dataAffichage.Rows[rowIndex].Cells[i].Value = values[i];
                    }
                }

            }
        }
    }
}
