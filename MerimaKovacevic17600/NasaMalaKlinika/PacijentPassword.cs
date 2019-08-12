using ConsoleApplication3;
using Klase;
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
    public partial class PacijentPassword : Form
    {
        Pacijent pacijent;
        ErrorProvider errors;

        public PacijentPassword(Pacijent pacijent)
        {
            InitializeComponent();
            this.pacijent = pacijent;

            errors = new ErrorProvider();
            errors.SetIconAlignment(textSifra2, ErrorIconAlignment.MiddleRight);
            errors.SetIconAlignment(textSifra, ErrorIconAlignment.MiddleRight);
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (errors.GetError(textSifra2) == "" && errors.GetError(textSifra) == "")
            {
                Close();
                pacijent.PostaviAutentikaciju(textSifra.Text);
            }
        }

        private void textSifra2_Validated(object sender, EventArgs e)
        {
            errors.SetError(textSifra2, "");
        }

        private void textSifra2_Validating(object sender, CancelEventArgs e)
        {
            if (textSifra.Text != textSifra2.Text)
            {
                errors.SetError(textSifra2, "Sifre nisu iste");
                e.Cancel = true;
            }
        }

        private void textSifra_Validated(object sender, EventArgs e)
        {
            errors.SetError(textSifra, "");
        }

        private void textSifra_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacije.JeLiSifraValidna(textSifra.Text))
            {
                errors.SetError(textSifra, "Sifra mora imati najmanje 6 karaktera");
                e.Cancel = true;
            }
        }
    }
}
