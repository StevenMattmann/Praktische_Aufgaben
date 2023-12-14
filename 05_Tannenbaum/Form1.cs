using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Tannenbaum
{
   
   public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void TanneZeichnenButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Stammbreite.Text, out int stammbreite) &&
                int.TryParse(Stammhoehe.Text, out int stammhoehe) &&
                int.TryParse(Kronenhoehe.Text, out int kronenhoehe))
            {

                Tanne m = new Tanne(stammhoehe, stammbreite, kronenhoehe);
                string tanneZeichnung = m.Zeichnen();
                textBox1.AppendText(tanneZeichnung);

            }
            else
            {
                MessageBox.Show("Ungültige Eingabe. Bitte geben Sie ganze Zahlen ein.");
            }
        }
    }
}

