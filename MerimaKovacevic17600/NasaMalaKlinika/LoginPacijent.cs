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
    public partial class LoginPacijent : Form
    {
        Klinika klinika;
        LoginListener listener;
        ErrorProvider errors;

        public LoginPacijent(LoginListener listener, Klinika klinika)
        {
            InitializeComponent();
            this.klinika = klinika;
            this.listener = listener;
            errors = new ErrorProvider();
        }

        private Pacijent NadjiPacijenta()
        {
            foreach (Pacijent pacijent in klinika.DajPacijente())
            {
                if (pacijent.JeLiTajPacijent(textIme.Text, textPrezime.Text))
                {
                    statusStrip1.Hide();
                    return pacijent;
                }
            }
            statusStrip1.Show();
            return null;
        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            Pacijent nadjeni = NadjiPacijenta();
            if (nadjeni != null)
            {
                PronadjenPacijent(nadjeni);
            }
        }

        private void PronadjenPacijent(Pacijent pacijent)
        {
            if (pacijent.ImaLiPassword())
            {
                if (pacijent.JeLiPasswordTacan(textPassword.Text))
                {
                    listener.OnLogin(pacijent);
                    Close();
                    return;
                } else
                {
                    errors.SetError(textPassword, "Netacna sifra");
                }
            } else
            {
                errors.SetError(textPassword, "Korisnik nema sifru");
            }
        }

        private void buttonNovaSifra_Click(object sender, EventArgs e)
        {
            Pacijent nadjeni = NadjiPacijenta();
            if (nadjeni != null)
            {
                if (!nadjeni.ImaLiPassword())
                {
                    new PacijentPassword(nadjeni).ShowDialog();
                } else
                {
                    errors.SetError(textPassword, "Korisnik vec ima sifru");
                }
            }
        }

        private void LoginPacijent_Load(object sender, EventArgs e)
        {

        }
    }
}
