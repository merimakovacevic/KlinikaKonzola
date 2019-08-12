using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplication3;

namespace NasaMalaKlinika
{
    public partial class LoginUposlenik : Form
    {
        private Klinika klinika;
        LoginListener listener;

        public LoginUposlenik(LoginListener listener, Klinika klinika)
        {
            InitializeComponent();
            this.listener = listener;
            this.klinika = klinika;
        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            foreach (Uposlenik uposlenik in this.klinika.DajUposlenike()) {
                // Ako je uneseni login tacan za ovog uposlenika
                if (uposlenik.JeLiTacanLogin(textUsername.Text, textPassword.Text))
                {
                    // Logujem tog uposlenika
                    listener.OnLogin(uposlenik);
                    Close();

                    return;
                }
            }
            // Nije pronadjen uposlenik
            statusStrip1.Show();
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
