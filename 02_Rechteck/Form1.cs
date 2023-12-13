using System;
using System.Windows.Forms;
using AUFGABE.BLJ;

namespace RechteckBerechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void end_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void berechnen_Click(object sender, EventArgs e)
        {

            if (double.TryParse(widthTextbox.Text, out double width) && double.TryParse(heightTextbox.Text, out double height))
            {
                Rechteck rechteck = new Rechteck();

                rechteck.Height = height;
                rechteck.Width = width;

                string flaeche = rechteck.GetArea().ToString();

                textBox1.Text = $"Fläche: {flaeche}";
            }
            else
            {
                MessageBox.Show("Bitte gültige Zahlen für Breite und Höhe eingeben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}