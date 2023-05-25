using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_Integrateur {
    public class Donateur {
        private int id;
        private string prenom;
        private string nom;
        private string courriel;
        private string telephone;
        private string typeCarte;
        private string numCarte;
        private string moisExpCarte;
        private string anExpCarte;
        private string cvsCarte;
        private int points;
        public static List<Donateur> liste = new List<Donateur>();
        public Donateur(string id, string prenom, string nom, string courriel, string telephone, string typeCarte, string numCarte, string moisExpCarte, string anExpCarte, string cvsCarte, string points) {
            this.prenom = prenom;
            this.nom = nom;
            this.courriel = courriel;
            this.telephone = telephone;
            this.typeCarte = typeCarte;
            this.numCarte = numCarte;
            this.moisExpCarte = moisExpCarte;
            this.anExpCarte = anExpCarte;
            this.cvsCarte = cvsCarte;
            this.points = int.Parse(points);
        }  
        public Donateur(string[] strings) : this(strings[0], strings[1], strings[2], strings[3], strings[4], strings[5], strings[6], strings[7], strings[8], strings[9], strings[10]) {

        }

        //getter methodes
        public string getPrenom() {
            return prenom;
        }
        public string getNom() {
            return nom;
        }
        public string getCourriel() {
            return courriel;
        }
        public string getTelephone() {
            return telephone;
        }

        public string getTypeCarte() {
            return typeCarte;
        }
        public string getNumCarte() {
            return numCarte;
        }

        public string getMoisExpCarte() {
            return moisExpCarte;
        }
        public string getAnExpCarte() {
            return anExpCarte;
        }

        public string getCvsCarte() {
            return cvsCarte;
        }

        public int getId()
        {
            return id;
        }
        public int getPoints()
        {
            return points;
        }

        //ToString()
        public override string ToString() {
            string s = "";
            for (int i = 0; i < ToTableau().Length; i++) {
                s += ToTableau()[i] + (i < ToTableau().Length - 1 ? ";" : "");
            }
            return s;
        }
        public string[] ToTableau() {
            return new string[] { prenom, nom, courriel, telephone, typeCarte, numCarte, moisExpCarte, anExpCarte, cvsCarte, points+"" };
        }
    }
}
