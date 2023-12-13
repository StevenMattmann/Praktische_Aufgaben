using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wurfel
{
    public partial class WurfelForm : Form
    {
       
        public WurfelForm()
        {
            InitializeComponent();
        }

        private void WurfelnButton_Click(object sender, EventArgs e)
        {
            Wuerfel wuerfel = new Wuerfel();
            int Wurf = wuerfel.Werfen();
            TrowValueLabel.Text = Wurf.ToString();
            LasThrowValueLabel.Text = wuerfel.LetzterWurf.ToString();
        }
    }
}
