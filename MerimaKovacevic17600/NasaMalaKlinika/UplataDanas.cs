using ConsoleApplication3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NasaMalaKlinika
{
    public partial class UplataDanas : Form
    {
        Pacijent p;
        public UplataDanas(Pacijent pacijent)
        {
            InitializeComponent();
            labelKolicina.Text = pacijent.DosadasnjaCijena.ToString() + " KM";
            p = pacijent;
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            if (p.trenutniPregledi.Count > 0)
            {
                statusStrip1.Show();
            } else
            {
                p.Plati();
                Close();
            }
        }
    }
}
