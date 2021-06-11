using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS025ZakladyAlgoritmu
{
    public partial class ZakladyAlgoritmuForm : Form
    {
        public ZakladyAlgoritmuForm()
        {
            InitializeComponent();
        }
        static string Alg1NerovnostSoucetJinakSoucet3x(string vstup)
        {
            string[] data = vstup.Split(',');
            return NerovnostSoucetJinakSoucet3x(int.Parse(data[0]), int.Parse(data[1])).ToString();
        }
        static int NerovnostSoucetJinakSoucet3x(int a, int b)
        {
            return (a == b) ? (3 * (a + b)) : (a + b);
        }
        public delegate string Algoritmus(string vstup);

        private void vstupTextBox_TextChanged(object sender, EventArgs e)
        {
            Algoritmus[] algoritmy = new Algoritmus[2];
            algoritmy[0] = Alg1NerovnostSoucetJinakSoucet3x;
            algoritmy[1] = Alg2RozdilOd51NeboTrojnasobek;
            try
            {
                vystupLabel.Text = string.Format("= {0}", algoritmy[algoritmyComboBox.SelectedIndex](vstupTextBox.Text));
            }
            catch
            {
                vystupLabel.Text = string.Format("= {0}", "?");
            }
        }
        static string Alg2RozdilOd51NeboTrojnasobek(string vstup)
        {
            return RozdilOd51NeboTrojnasobek(int.Parse(vstup)).ToString();
        }
        static int RozdilOd51NeboTrojnasobek(int n)
        {
            return (n < 51) ? Math.Abs(51 - n) : (3 * Math.Abs(51 - n));
        }
    }
}
