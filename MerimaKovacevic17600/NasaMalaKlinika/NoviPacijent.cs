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
    public partial class NoviPacijent : Form
    {
        Klinika klinika;
        ErrorProvider errors;
        List<Control> kontrole;
        public Pacijent napravljeni;

        public NoviPacijent(Klinika k)
        {
            InitializeComponent();
            klinika = k;
            errors = new ErrorProvider();

            // lista svih kontrola koje mogu imati error
            // potrebno za FormDataValidator
            kontrole = new List<Control>();
            kontrole.Add(textIme);
            kontrole.Add(textPrezime);
            kontrole.Add(textAdresa);
            kontrole.Add(dateDatumRodjenja);
            kontrole.Add(textMaticniBroj);
            kontrole.Add(comboBracnoStanje);
            kontrole.Add(comboSpol);
            kontrole.Add(pacijentProfilna1);
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            FormDataValidator.check_and_set_message(textIme.Text, Validacije.JeLiImeValidno, textIme, errors, "Ime nije ispravno");
            FormDataValidator.check_and_set_message(textPrezime.Text, Validacije.JeLiPrezimeValidno, textPrezime, errors, "Prezime nije ispravno");
            FormDataValidator.check_and_set_message(textAdresa.Text, Validacije.JeLiAdresaValidna, textAdresa, errors, "Adresa nije ispravna");
            FormDataValidator.check_and_set_message(dateDatumRodjenja.Value, Validacije.JeLiDatumRodjenjaValidan, dateDatumRodjenja, errors, "Datum rodjenja nije ispravan");
            FormDataValidator.check_and_set_message(comboBracnoStanje.Text, Validacije.JeLiBracnoStanjeValidno, comboBracnoStanje, errors, "Bracno stanje nije ispravno");
            FormDataValidator.check_and_set_message(comboSpol.Text, Validacije.JeLiSpolValidan, comboSpol, errors, "Spol nije ispravan");
            if (Validacije.JeLiMaticniBrojValidan(textMaticniBroj.Text, dateDatumRodjenja.Value))
            {
                errors.SetError(textMaticniBroj, "");
            } else
            {
                errors.SetError(textMaticniBroj, "Maticni broj nije ispravan");
            }
            errors.SetError(pacijentProfilna1, pacijentProfilna1.ErrorSlike());
            if (!FormDataValidator.any_has_error(kontrole, errors))
            {
                Pacijent pacijent = new Pacijent(
                    textIme.Text,
                    textPrezime.Text,
                    dateDatumRodjenja.Value,
                    textMaticniBroj.Text,
                    comboSpol.Text,
                    comboBracnoStanje.Text,
                    textAdresa.Text,
                    pacijentProfilna1.Izabrana
                );
                klinika.DodajNovogPacijenta(pacijent);
                napravljeni = pacijent;
                Close();
                return;
            }
        }
    }
}
