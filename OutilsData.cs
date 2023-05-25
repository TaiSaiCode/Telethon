using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Integrateur {
    internal class OutilsData {
        private string filename;
        private string defaultPath = "..\\..\\Data\\";
        private string unparsedContent;
        private bool locked = false;

        public OutilsData(string filename) {
            this.filename = defaultPath + filename;
            if (!canAccessFile()) {
                MessageBox.Show("Impossible d'acceder au fichier " + filename);
            }
            else
                setInitialContent();
        }

        /// <summary>
        /// Returns the initial content of the file before any changes have been made.
        /// </summary>
        public string InitialContent {
            get { return unparsedContent; }
        }

        /// <summary>
        /// Gets or sets the text contained in the file
        /// </summary>
        public string Text {
            get { return getTextContent(); }
            set { setContent(value); }
        }

        /// <summary>
        /// Gets or sets the content of the file but as an array of strings.
        /// </summary>
        public string[] TextLines {
            get { return getLinesContent(); }
            set { setContent(value); }
        }

        /// <summary>
        /// Gets or sets a value which prevents the coder from modifying the content of the file BY CALLING THIS OBJECT INSTANCE.<br></br>
        /// 
        /// </summary>
        public bool Locked {
            get { return locked; }
            set { locked = value; }
        }

        public int LinesCount
        {
            get { return getLineCount(); }
        }

        //
        //fonctions et methodes
        //

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool canAccessFile() {
            return (File.Exists(filename));

        }
        private void setInitialContent() {
            var sr = new StreamReader(filename);
            unparsedContent = sr.ReadToEnd();
            sr.Close();
        }

        private string[] getLinesContent() {
            return File.ReadAllLines(filename);
        }
        private string getTextContent() {
            return File.ReadAllText(filename);
        }

        private void setContent(string chaine) {
            if (!locked)
                File.WriteAllText(filename, chaine);
            else
                Console.WriteLine("La modification du fichier " + filename + "est interdite!");
        }
        private void setContent(string[] chaine) {
            if (!locked)
                File.WriteAllLines(filename, chaine);
            else
                Console.WriteLine("La modification du fichier " + filename + "est interdite!");
        }

        public void AddLine(string line) {
            if (!locked)
                File.AppendAllText(filename, (IsEmpty() ? "": "\n") + line);
            else
                Console.WriteLine("La modification du fichier " + filename + "est interdite!");
        }

        public void AddParsedLine(string[] s) {
            string constructed = "";
            for (int i = 0; i < s.Length; i++)
                constructed += s[i] + (i < s.Length - 1 ? ";" : "");
            AddLine(constructed);
        }
        public void AddParsedLine(string[] s, int start, int end)
        {
            if (end > s.Length - 1)
                end = s.Length - 1;

            string constructed = "";
            for (int i = start; i <= end; i++)
                constructed += s[i] + (i < end ? ";" : "");
            AddLine(constructed);
        }

        public void AddLines(string[] lines) {
            if (!locked)
                foreach (string line in lines)
                    AddLine(line);
            else
                Console.WriteLine("La modification du fichier " + filename + "est interdite!");
        }

        public bool IsEmpty()
        {
            return Text.Length == 0;
        }

        public void rollback() {
            setContent(InitialContent);
        }
        public void ShowAndRollback() {
            MessageBox.Show(Text, "Debugging code and rolling back file content: \n [{0}] ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            rollback();
        }

        private List<string[]> getParsedLines() {
            List<string[]> lines = new List<string[]>();
            string[] unparsed = getLinesContent();

            foreach (string line in unparsed) {
                lines.Add(parseline(line));
            }
            return lines;
        }

        public int getLineIndexStartingBy(string s)
        {
            for(int i = 0; i < getLineCount(); i++)
            {
                if (TextLines[i].StartsWith(s))
                    return i;
            }
            return -1;
        }

        public int[] getLineIndexesStartingBy(string s)
        {
            List<int> tab = new List<int>();
            for (int i = 0; i < getLineCount(); i++)
            {
                if (TextLines[i].StartsWith(s))
                    tab.Add(i);
            }

            return tab.ToArray();
        }

        public void changeValueAt(int line_index, int column_index, string value)
        {
            string[] s = getParsedLine(line_index);
            s[column_index] = value;

            List<string> new_content = new List<string>();
            for(int j = 0; j < getLineCount(); j++)
            {
                if (j == line_index)
                {
                    string constructed = "";
                    for (int i = 0; i < s.Length; i++)
                        constructed += s[i] + (i < s.Length - 1 ? ";" : "");
                    new_content.Add(constructed);
                }
                else
                {
                    new_content.Add(TextLines[j]);
                }

            }
            string ss = "";
            for(int i = 0; i < new_content.Count; i++)
            {
                if (i == 0)
                    ss += new_content[i];
                else
                    ss += "\n"+new_content[i];
            }

            Text = ss;
        }

        public string[] getParsedLine(int ndx) {
            return getParsedLines()[ndx];
        }

        public int getLineCount() {
            return getParsedLines().Count;
        }

        private string[] parseline(string line) {
            line += ";";
            line = line.Replace(";;", ";");
            ArrayList maListe = new ArrayList();
            string temp = "";
            for (int i = 0; i < line.Length; i++) {
                if (line[i] != ';') {
                    temp += line[i];
                }
                else {
                    maListe.Add(temp);
                    temp = "";
                }
            }
            string[] fields = new string[maListe.Count];
            for (int i = 0; i < fields.Length; i++) {
                fields[i] = (string)maListe[i];
            }
            return fields;
        }

        private string getField(int lineIndex, int fieldIndex) {
            string[] str = getParsedLines()[lineIndex];
            return str[fieldIndex];
        }
    }
}
