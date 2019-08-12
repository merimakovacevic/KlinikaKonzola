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
    public partial class UnosAnamneze : Form
    {
        public string tekst;
        Pacijent pacijent;
        VrstaPregleda vrstaPregleda;
        public UnosAnamneze(VrstaPregleda vrstaPregleda, Pacijent pacijent = null)
        {
            InitializeComponent();
            this.pacijent = pacijent;
            this.vrstaPregleda = vrstaPregleda;

            labelVrstaPregleda.Text = vrstaPregleda.imePregleda;
            if (pacijent != null)
            {
                labelImeIPrezime.Text = pacijent.DajImeIPrezime();
                pictureBox1.Image = pacijent.slika;
            } else
            {
                groupPacijent.Hide();
            }
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                Close();
            } else
            {
                statusStrip1.Show();
            }
        }
    }
}
