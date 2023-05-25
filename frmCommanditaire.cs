using System;
using System.Collections;
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
    public partial class frmCommanditaire : UserControl
    {
        private int currentScreenIndex = 0;
        private ArrayList[] tabs;
        private string[] temp_datas = new string[6];

        private OutilsData fichier_commanditaires;
        private OutilsData fichier_prix;
        public frmCommanditaire()
        {
            InitializeComponent();
            tabs = Outils.TransferControls(tabControlCommanditaire, this);
            Outils.setupFocus(tabs, btnCommanditairePrecedent);
            txtIdCommanditaire.Text = "1";
            txtQuantitePrix.KeyPress += Outils.Event_DigitsOnly;
            txtValeurPrix.KeyPress += Outils.Event_DigitsOnly;
            fichier_commanditaires = new OutilsData("commanditaires.txt");
            fichier_prix = new OutilsData("prix.txt");
            lblValueIdCommanditaire.Visible = false;

            txtQuantitePrix.TextChanged += ToggleSaveButton;
            txtValeurPrix.TextChanged += ToggleSaveButton;
            cbArticlePrix.SelectedIndexChanged += ToggleSaveButton;

        }

        private void btnCommanditairePrecedent_Click_1(object sender, EventArgs e)
        {

            if (currentScreenIndex > 0)
            {
                currentScreenIndex--;
                Outils.setFocus(currentScreenIndex, tabs, btnCommanditairePrecedent, btnCommanditaireSuivant, btnCommanditaireSauver);
                lblValueIdCommanditaire.Visible = false;
            }

        }

        private void btnCommanditaireSuivant_Click_1(object sender, EventArgs e)
        {
            ArrayList temp = tabs[currentScreenIndex];
            if (!Outils.IsAllFilled(temp, new Control[] { cbBoxCommanditaireIdExistant }))
                return;
            if (currentScreenIndex < tabs.Length - 1) {
                fillDatas();
                currentScreenIndex++;
                Outils.setFocus(currentScreenIndex, tabs, btnCommanditairePrecedent, btnCommanditaireSuivant, btnCommanditaireSauver);
                lblValueIdCommanditaire.Visible = false;
            }
            if (currentScreenIndex == tabs.Length - 1) {
                lboxCommanditairePrix.Items.Clear();
                foreach (string s in temp_datas) {
                    lboxCommanditairePrix.Items.Add(s);
                }
            }
        }

        private void btnCommanditaireSauver_Click(object sender, EventArgs e) {
            string[] strings = new string[5];
            strings[0] = fichier_prix.getLineCount() + "";
            strings[1] = txtIdCommanditaire.Text;
            strings[2] = cbArticlePrix.Text;
            strings[3] = frmDonnerPrix.convertMoneyToPoints(int.Parse(txtValeurPrix.Text))+"";
            strings[4] = txtQuantitePrix.Text;

            if (currentScreenIndex == 1) {
                fichier_prix.AddParsedLine(strings);
                MessageBox.Show("Prix ajouté!");

            }
            if (currentScreenIndex == 2) {
                fichier_prix.AddParsedLine(strings);
                fichier_commanditaires.AddParsedLine(temp_datas,0,2);
                MessageBox.Show("Commanditaires et prix ajoutés!");
            }

            currentScreenIndex = 0;
            Outils.setFocus(currentScreenIndex, tabs, btnCommanditairePrecedent, btnCommanditaireSuivant, btnCommanditaireSauver);

            foreach (ArrayList list in tabs)
                Outils.ClearAllText(list, true, 'X');

            Outils.ClearArray(temp_datas);
            updateFormData();
        }

        private void ToggleSaveButton(object sender, EventArgs e)
        {
            if (cbBoxCommanditaireIdExistant.SelectedIndex == -1)
                return;
            btnCommanditaireSauver.Enabled = txtQuantitePrix.TextLength * txtValeurPrix.TextLength > 0 && cbArticlePrix.SelectedIndex > -1;
        }

        public void updateFormData() {
            if (!fichier_commanditaires.canAccessFile())
                return;

            cbBoxCommanditaireIdExistant.Items.Clear();
            txtIdCommanditaire.Text = fichier_commanditaires.getLineCount() + "";
            foreach (string s in fichier_commanditaires.TextLines)
                cbBoxCommanditaireIdExistant.Items.Add(s);
        }

        private void fillDatas() {
            switch (currentScreenIndex)
            {
                case 0:
                    temp_datas[0] = txtIdCommanditaire.Text;
                    temp_datas[1] = txtPrenomCommanditaire.Text;
                    temp_datas[2] = txtNomCommanditaire.Text;
                    break;
                case 1:
                    temp_datas[3] = cbArticlePrix.Text;
                    temp_datas[4] = txtValeurPrix.Text;
                    temp_datas[5] = txtQuantitePrix.Text;
                    break;
                default:
                    break;
            }
        }

        private void cbBoxCommanditaireID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fills the textboxes based on the index of the combobox
            string[] source = fichier_commanditaires.getParsedLine(cbBoxCommanditaireIdExistant.SelectedIndex);
            txtIdCommanditaire.Text = source[0];
            txtPrenomCommanditaire.Text = source[1];
            txtNomCommanditaire.Text = source[2];
            //enables the save button

            Outils.ClearArray(temp_datas);
            Outils.setFocus(1, tabs);
            currentScreenIndex = 1;
            btnCommanditaireSauver.Enabled = false;
            btnCommanditaireSuivant.Enabled = false;
            btnCommanditairePrecedent.Enabled = false;
            lblValueIdCommanditaire.Text = source[0] +" : " + source[1] + " " + source[2];
            lblValueIdCommanditaire.Visible = true;

        }

        private void frmCommanditaire_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < fichier_commanditaires.getLineCount(); i++)
            {
                new Commanditaire(fichier_commanditaires.getParsedLine(i));
            }
            updateFormData();
        }

        private void txtValeurPrix_TextChanged(object sender, EventArgs e)
        {
            if(txtValeurPrix.TextLength>0)
                txtValeurPrix.BackColor = int.Parse(txtValeurPrix.Text) >= 50 ? Color.White : Color.Pink;
            else
                txtValeurPrix.BackColor = Color.Pink;
        }

        private void txtValeurPrix_Leave(object sender, EventArgs e)
        {
            if(txtValeurPrix.TextLength == 0 || int.Parse(txtValeurPrix.Text) < 50)
            {
                txtValeurPrix.Focus();
                MessageBox.Show("Veuillez entrer une valeur d'au moins 50$", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
      
}
