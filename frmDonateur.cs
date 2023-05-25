using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;

namespace Project_Integrateur {

    public partial class frmDonateur : UserControl {
        private int currentScreenIndex = 0;
        private ArrayList[] tabs;//controls du tabpage du current screen index
        private string[] temp_datas = new string[11];
        private int points = 0;

        private OutilsData fichier_donateur;
        private OutilsData fichier_don;
        public frmDonateur() {
            InitializeComponent();
            tabs = Outils.TransferControls(tabControlHidden, this);
            Outils.setupFocus(tabs, btnDonateurPrecedent);
            txtIdDonateur.Text = "1";

            txtTelephoneDonateur.KeyPress += Outils.Event_DigitsOnly;
            txtNumeroDonateur.KeyPress += Outils.Event_DigitsOnly;
            txtDonateurCvs.KeyPress += Outils.Event_DigitsOnly;
            txtMontantDonateur.KeyPress += Outils.Event_DigitsOnly;
            txtNumeroDonateur.Leave += txtNumeroCarte_Leave;
            txtTelephoneDonateur.Leave += txtTelephoneDonateur_Leave;
            txtNumeroDonateur.TextChanged += textbox_TextChanged;
            txtTelephoneDonateur.TextChanged += textbox_TextChanged;
            txtCourrielDonateur.TextChanged += textbox_TextChanged;

            fichier_donateur = new OutilsData("donateurs.txt");
            fichier_don = new OutilsData("dons.txt");

        }

        private void btnDonateurSuivant_Click(object sender, EventArgs e) {
            ArrayList temp = tabs[currentScreenIndex];
            if (!Outils.IsAllFilled(temp, new Control[] { cbBoxDonateurIdExistant }))
                return;
            if (currentScreenIndex < tabs.Length - 1) {
                fillDatas();
                currentScreenIndex++;
                Outils.setFocus(currentScreenIndex, tabs, btnDonateurPrecedent, btnDonateurSuivant, btnDonateurSauve);

                SetVisibleControlsDon(false);
            }
            if (currentScreenIndex == tabs.Length - 1)
            {
                lboxDonateur.Items.Clear();
                foreach (string s in temp_datas)
                {
                    lboxDonateur.Items.Add(s);
                }
            }
        }

        private void btnDonateurPrecedent_Click(object sender, EventArgs e) {
            if (currentScreenIndex > 0) {
                currentScreenIndex--;
                Outils.setFocus(currentScreenIndex, tabs, btnDonateurPrecedent, btnDonateurSuivant, btnDonateurSauve);
            }
        }

        private void btnDonateurSauve_Click(object sender, EventArgs e) {
            string[] strings = new string[4];
            strings[0] = fichier_don.getLineCount() + "";
            strings[1] = txtIdDonateur.Text;
            strings[2] = txtMontantDonateur.Text + "$";
            strings[3] = dtpDon.Text;

            if (currentScreenIndex == 2)
            {
                fichier_don.AddParsedLine(strings);
                string lbl = lblPoints.Text;
                string s = lbl.Substring(0, lbl.LastIndexOf(' '));
                s = s.Substring(s.LastIndexOf(' ')+1);
                int points = int.Parse(s)+ frmDonnerPrix.convertMoneyToPoints(int.Parse(txtMontantDonateur.Text));

                int id_donateur = int.Parse(lbl.Substring(0, lbl.IndexOf(' ')));
                int index_ligne_fichier = fichier_donateur.getLineIndexStartingBy(id_donateur+";");

                fichier_donateur.changeValueAt(index_ligne_fichier,10,points+"");

                MessageBox.Show("Don ajouté! Vous avez maintenant "+ points+"pts");
                
            }
            if (currentScreenIndex == 3)
            {
                fichier_don.AddParsedLine(strings);
                fichier_donateur.AddParsedLine(temp_datas);
                MessageBox.Show("Donateur et don ajoutés!");
            }

            currentScreenIndex = 0;
            Outils.setFocus(currentScreenIndex, tabs, btnDonateurPrecedent, btnDonateurSuivant, btnDonateurSauve);

            foreach (ArrayList list in tabs)
                Outils.ClearAllText(list, true, 'X');

            Outils.ClearArray(temp_datas);
            updateFormData();
        }


        private void frmDonateur_Load(object sender, EventArgs e) {
            for (int i = 0; i < fichier_donateur.getLineCount(); i++) {
                new Donateur(fichier_donateur.getParsedLine(i));
            }
            updateFormData();
        }

        public void updateFormData() {
            if (!fichier_donateur.canAccessFile())
                return;

            cbBoxDonateurIdExistant.Items.Clear();
            txtIdDonateur.Text = fichier_donateur.getLineCount()+"";
            foreach (string s in fichier_donateur.TextLines)
                cbBoxDonateurIdExistant.Items.Add(s);
        }

        private void fillDatas()
        {
            switch (currentScreenIndex)
            {
                case 0:
                    temp_datas[0] = txtIdDonateur.Text;
                    temp_datas[1] = txtPrenomDonateur.Text;
                    temp_datas[2] = txtNomDonateur.Text;
                    temp_datas[3] = txtCourrielDonateur.Text;
                    temp_datas[4] = txtTelephoneDonateur.Text;
                    break;
                case 1:
                    if (rbtnVisa.Checked)
                        temp_datas[5] = rbtnVisa.Text;
                    if (rbtnMcard.Checked)
                        temp_datas[5] = rbtnMcard.Text;
                    if (rbtnAexpress.Checked)
                        temp_datas[5] = rbtnAexpress.Text;

                    temp_datas[6] = txtNumeroDonateur.Text;
                    temp_datas[7] = cbCCExpMois.Text;
                    temp_datas[8] = cbCCExpAnnee.Text;
                    temp_datas[9] = txtDonateurCvs.Text;
                    temp_datas[10] = "0";
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Sets the visibility of the the trophy pic/button and donner info label.<br></br>
        /// This should be true when a donner is selected from the combobox BUT false when clicking the "next" button.
        /// </summary>
        /// <param name="visible"></param>
        private void SetVisibleControlsDon(bool visible)
        {
            lblPoints.Visible = visible;
            picPrix.Visible = visible;
        }


        private void cbBoxDonateurIdExistant_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fills the textboxes based on the index of the combobox
            string[] source = fichier_donateur.getParsedLine(cbBoxDonateurIdExistant.SelectedIndex);
            txtIdDonateur.Text = source[0];
            txtPrenomDonateur.Text = source[1];
            txtNomDonateur.Text = source[2];
            txtCourrielDonateur.Text = source[3];
            txtTelephoneDonateur.Text = source[4];
            Outils.CheckRadioButtonFromText(tabs[1], source[5]);
            txtNumeroDonateur.Text = source[6];
            cbCCExpMois.Text = source[7];
            cbCCExpAnnee.Text = source[8];
            txtDonateurCvs.Text = source[9];
            SetVisibleControlsDon(true);
            lblPoints.Text = source[0]+" : " + source[1]+" " + source[2] + " a "+ source[10] + " pts";
            picPrix.Enabled = int.Parse(source[10]) > 0 ? true : false;

            //enables the save button
            
            Outils.ClearArray(temp_datas);
            Outils.setFocus(2, tabs);
            currentScreenIndex = 2;
            btnDonateurSauve.Enabled = false;
            btnDonateurSuivant.Enabled = false;
            btnDonateurPrecedent.Enabled = false;

        }

        private void picPrix_Click(object sender, EventArgs e)
        {
            string[] s = fichier_donateur.getParsedLine(cbBoxDonateurIdExistant.SelectedIndex);
            
            new frmDonnerPrix(s[0], s[1], s[2], s[10], lblPoints);
        }

        private void txtMontantDonateur_TextChanged(object sender, EventArgs e)
        {
            if(cbBoxDonateurIdExistant.SelectedIndex != -1)
                btnDonateurSauve.Enabled = txtMontantDonateur.Text.Length > 0;
        }

        private void txtCourrielDonateur_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            WarnAboutFormat(txtCourrielDonateur, !regex.IsMatch(txtCourrielDonateur.Text), "Le format du courriel est invalide");
        }

        private void txtTelephoneDonateur_Leave(object sender, EventArgs e)
        {
            WarnAboutFormat(txtTelephoneDonateur, txtTelephoneDonateur.TextLength < 10, "Le numéro de téléphone doit contenir au moins 10 chiffres");
        }

        private void txtNumeroCarte_Leave(object sender, EventArgs e)
        {
            WarnAboutFormat(txtNumeroDonateur, txtNumeroDonateur.TextLength < 16, "Le numéro de carte de crédit doit contenir 16 chiffres");
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void WarnAboutFormat(TextBox textbox, bool warning_condition, string warning)
        {
            if (warning_condition)
            {
                textbox.BackColor = Color.Pink;
                MessageBox.Show(warning, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textbox.Focus();
            }
            else
                textbox.BackColor = Color.White;
        }
    }
}
