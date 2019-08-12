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
    public partial class LoginTip : Form, LoginListener
    {
        Klinika klinika;
        Main main;
        public LoginTip(Klinika klinika)
        {
            this.klinika = klinika;
            InitializeComponent();
        }

        private void buttonUposlenik_Click(object sender, EventArgs e)
        {
            LoginUposlenik dialog = new LoginUposlenik(this, klinika);
            dialog.ShowDialog();
        }

        private void buttonPacijent_Click(object sender, EventArgs e)
        {
            LoginPacijent dialog = new LoginPacijent(this, klinika);
            dialog.ShowDialog();
        }

        public void OnLogin(Osoba osoba)
        {
            main = new Main(klinika, osoba);
            main.Show();
            Hide();
            main.FormClosed += OnMainClosed;
        }

        private void OnMainClosed(object sender, FormClosedEventArgs e)
        {
            if (main.Logout)
            {
                Show();
            } else
            {
                Close();
            }
        }

        private void LoginTip_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 10);
            float[] dashValues = { 1.0F, 1.0F };
            Pen blackPen = new Pen(Color.Black, 10);
            blackPen.DashPattern = dashValues;
            e.Graphics.DrawLine(pen, 20, 100, 20, 200);
            e.Graphics.DrawLine(pen, new Point(20, 100), new Point(70, 200));
            e.Graphics.DrawLine(pen, new Point(70, 100), new Point(70, 200));
            e.Graphics.DrawLine(pen, new Point(70, 100), new Point(100, 200));
            e.Graphics.DrawLine(pen, new Point(130, 100), new Point(100, 200));
            e.Graphics.DrawLine(pen, new Point(130, 100), new Point(130, 200));
            e.Graphics.DrawLine(blackPen, new Point(130, 150), new Point(170, 100));
            e.Graphics.DrawLine(blackPen, new Point(130, 150), new Point(170, 200));
        }
    }
}
