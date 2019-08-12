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
    public partial class UnosKartona : Form
    {
        Pacijent primljeni;
        public UnosKartona(Pacijent p)
        {
            primljeni = p;
            InitializeComponent();
            
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            primljeni.DodajKarton(new Karton(textNapomene.Text, textBolesti.Text, primljeni));
            Close();
        }
    }
}
