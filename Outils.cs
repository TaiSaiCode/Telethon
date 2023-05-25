using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Project_Integrateur {
    public class Outils {
        /// <summary>
        /// Transfer Controls from one to another.  Location will change for "to" controls
        /// </summary>
        /// <param name="from"></param> 
        /// <param name="to"></param>
        
        public static ArrayList[] TransferControls(TabControl from, Control to) {
            ArrayList[] tab = new ArrayList[from.Controls.Count];
            for(int i=0; i < tab.Length; i++) { 
                tab[i] = new ArrayList();
                TabPage tp = (TabPage)from.Controls[i];
                ArrayList a = AllControls(tp, true);
                foreach(Control c in a) {
                    to.Controls.Add(c);
                    tab[i].Add(c);
                }
                tp.Controls.Clear();
                from.Visible = false;
            }
            return tab;
        }
        
        /// <summary>
        /// Returns an ArrayList containing every controls and subcontrols of the specified control.<br></br>
        /// For example, if the control has a Panel with a GroupBox, all of the controls in that panel and in that groupbox will be in the ArrayList.
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static ArrayList AllControls(Control control, bool reverse) {
            ArrayList list = new ArrayList();
            AddControls(control, list);
            if (reverse) {
                list.Reverse();
            }
            return list;
        }
        /// <summary>
        /// Focus from all the controls of the ArrayList []index.<br></br>
        /// Disables the Back button when index is 0.<br></br>
        /// Disables the Next button when index on the last Index.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="tableau"></param>
        /// <param name="back"></param>
        /// <param name="next"></param>
        public static void setFocus(int index, ArrayList[] tableau, Button back, Button next, Button last) {
            if (index >= 0 && index <= tableau.Length - 1) {
                //code
                for (int i = 0; i < tableau.Length; i++) {
                    foreach (Control c in tableau[i]) { 
                        c.Visible = i == index;
                    }
                }
                
                back.Enabled = index != 0;
                next.Enabled = index != tableau.Length - 1;
                last.Enabled = index == tableau.Length - 1;
            }
        }

        public static void setFocus(int index, ArrayList[] tableau)
        {
            if (index >= 0 && index <= tableau.Length - 1)
            {
                for (int i = 0; i < tableau.Length; i++)
                    foreach (Control c in tableau[i])
                        c.Visible = i == index;
            }
        }

        /// <summary>
        /// Setup the focus on the first index of the ArrayList[]. Disables the back Button
        /// </summary>
        /// <param name="tableau"></param>
        /// <param name="back"></param>
        public static void setupFocus(ArrayList[] tableau, Button back) {
            if (tableau.Length > 0) 
            {
                for (int i = 0; i < tableau.Length; i++) {
                    foreach (Control c in tableau[i])
                        c.Visible = i == 0;
                }
                back.Enabled = false;
            }
        }
        //add something
        /// <summary>
        /// Returns every controls of the specified type from the specified Control.<br></br>
        /// <br></br>
        /// If the boolean parameter is true, the controls from the subcontrols are also considered.<br></br>
        /// For example, if you want the textboxes in a control that has a Panel with a GroupBox, the textboxes in that panel and groupbox would also be added to the ArrayList.
        /// </summary>
        /// <param name="control">The main control containing the wanted controls</param>
        /// <param name="type">Use "typeof(x)" where x should be the type of controls you want</param>
        /// <param name="from_subcontrols_too">If true, the method will collect the correct subcontrols too.</param>
        /// <returns></returns>
        public static ArrayList ControlsOfType(Control control, Type type, bool from_subcontrols_too) {
            ArrayList list = new ArrayList();
            if (from_subcontrols_too) {
                foreach (Control c in AllControls(control, false))
                    if (c.GetType() == type)
                        list.Add(c);
            }
            else
                foreach (Control c in control.Controls)
                    if (c.GetType() == type)
                        list.Add(c);
            return list;
        }

        public static ArrayList ControlsOfType(ArrayList tabs, Type type) {
            ArrayList list = new ArrayList();
            
            foreach (Control c in tabs)
                  if (c.GetType() == type)
                        list.Add(c);
            return list;
        }

        public static bool IsBetween(int number, int min, bool include_min,int max, bool include_max)
        {
            if (include_min)
            {
                if (number < min)
                    return false;
            }
            else if (number <= min)
                return false;

            if (include_max)
            {
                if (number > max)
                    return false;
            }
            else if (number >= max)
                return false;

            return true;
        }

        /// <summary>
        /// Should only be invoked by itself and by AllControls(). Adds the controls from the specified control to the specified ArrayList.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        private static void AddControls(Control source, ArrayList destination) {
            try {
                foreach (Control c in source.Controls) {
                    destination.Add(c);
                    AddControls(c, destination);
                }
            }
            catch (Exception) { }

        }

        public static ArrayList OrderedByXorY(ArrayList list, char axis) {

            string XY = axis.ToString().ToUpper();
            bool isX = XY == "X";


            ArrayList sort = new ArrayList();
            Control[] temp = new Control[list.Count];
            int count = list.Count;

            for (int j = 0; j < count; j++) {
                int index = 0;
                for (int i = 0; i < list.Count; i++) {
                    if (isX) {
                        if ((list[index] as Control).Location.X > (list[i] as Control).Location.X)
                            index = i;
                    }
                    else {
                        if ((list[index] as Control).Location.Y > (list[i] as Control).Location.Y)
                            index = i;
                    }

                }
                temp[j] = list[index] as Control;
                list.RemoveAt(index);
            }
            foreach (Control c in temp)
                sort.Add(c);

            return sort;
        }


        public static bool IsAllFilled(ArrayList list, Type type)
        {
            ArrayList temp = ControlsOfType(list,type);

            foreach(Control c in temp)
                if (c.Text.Length == 0)
                    return false;

            return true;
        }
        public static bool IsAllFilled(ArrayList list)
        {
            foreach (Control c in list)
            {
                if (c.GetType() == typeof(TextBox))
                    if (c.Text.Length == 0)
                        return false;
                if (c.GetType() == typeof(ComboBox))
                    if ((c as ComboBox).SelectedIndex == -1)
                        return false;
            }
            return true;
        }

        /// <summary>
        /// Sets the color of every specified controls by the chosen color if possible
        /// </summary>
        /// <param name="color"></param>
        /// <param name="controls"></param>
        public static void SetColorForAllControls(Color color, Control[] controls)
        {
            foreach (Control c in controls)
            {
                try {c.BackColor = color;}
                catch (Exception) { }
            }
                
        }

        public static bool IsAllFilled(ArrayList list, Control[] except)
        {
            foreach (Control c in list)
            {
                if (!isInArrayList(c, except))
                {
                    if (c.GetType() == typeof(TextBox))
                        if (c.Text.Length == 0)
                            return false;
                    if (c.GetType() == typeof(ComboBox))
                        if ((c as ComboBox).SelectedIndex == -1)
                            return false;
                }
            }
            return true;
        }

        public static bool isInArrayList(Control control, Control[] list)
        {
            foreach(Control c in list)
                if(c==control)
                    return true;

            return false;
        }

        public static string[] ListToArray(List<string> list)
        {
            string[] array = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
                array[i] = list[i];
            return array;
        }

        /// <summary>
        /// Clears all the textboxes and combobox texts from the specified arraylist <br></br>
        /// If the boolean parameter is true, the listboxes items will be cleared.<br></br>
        /// The char parameter accepts X or Y. It determines the axis of the radiobuttons in the arraylist if there any and checks the first one.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="clear_listBoxes"></param>
        /// <param name="radiobuttons_orientationXY"></param>
        public static void ClearAllText(ArrayList list, bool clear_listBoxes, char radiobuttons_orientationXY)
        {
            foreach(Control c in list)
            {
                if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(ComboBox))
                    c.Text = "";
                if (clear_listBoxes)
                    if (c.GetType() == typeof(ListBox))
                        (c as ListBox).Items.Clear();
            }
            if(ControlsOfType(list, typeof(RadioButton)).Count > 0)// next line checks the first radiobutton from the ArrayList if possible
                (OrderedByXorY(ControlsOfType(list, typeof(RadioButton)), radiobuttons_orientationXY)[0] as RadioButton).Checked = true;
        }

        public static void ClearArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = "";
        }
        public static void ClearArray(List<string> array)
        {
            for (int i = 0; i < array.Count(); i++)
                array[i] = "";
        }

        public static void Event_DigitsOnly(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        public static void CheckRadioButtonFromText(ArrayList list, string text)
        {
            foreach (RadioButton rb in ControlsOfType(list, typeof(RadioButton)))
                if (rb.Text == text)
                    rb.Checked = true;
        }
    }
}
