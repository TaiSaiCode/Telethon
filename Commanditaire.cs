using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Integrateur {
    internal class Commanditaire {

        private int id;
        private string prenom;
        private string nom;
        
        public static List<Commanditaire> liste = new List<Commanditaire>();
        public Commanditaire(string id, string prenom, string nom) {
            this.prenom = prenom;
            this.nom = nom;
            //liste.Add(this);
        }
        public Commanditaire(string[] strings) : this(strings[0], strings[1], strings[2]) {

        }

        //getter methodes
        public string getPrenom() {
            return prenom;
        }
        public string getNom() {
            return nom;
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
            return new string[] { prenom, nom };
        }
    }
}
