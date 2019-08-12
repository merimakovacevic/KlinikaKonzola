using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NasaMalaKlinika
{
    public partial class PacijentProfilna : UserControl
    {
        Image _izabrana;
        public Image Izabrana {
            get {
                return _izabrana;
            }
            set {
                _izabrana = value;
                pictureBox1.Image = value;
            }
        }

        public PacijentProfilna()
        {
            InitializeComponent();
        }

        private void obrisatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izabrana = null;
        }

        private void dodatiNovuSlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    Izabrana = Image.FromFile(file);
                }
                catch (IOException)
                {
                    Izabrana = null;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show((PictureBox)sender, 0, 0);
        }

        public string ErrorSlike()
        {
            if (Izabrana == null)
            {
                return "Slika nije izabrana";
            }
            if ((DateTime.Now - dateTimePicker1.Value).Days > 6 * 30)
            {
                return "Slika ne smije biti starija od 6 mjeseci";
            }
            if (dateTimePicker1.Value > DateTime.Now)
            {
                return "Izbor datuma slike mora biti u proslosti";
            }
            return "";
        }
    }
}
