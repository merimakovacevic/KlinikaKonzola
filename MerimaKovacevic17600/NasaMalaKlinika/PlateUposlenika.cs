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
    public partial class PlateUposlenika : Form
    {
        Klinika klinika;
        public PlateUposlenika(Klinika k)
        {
            InitializeComponent();
            klinika = k;
        }

        private void PlateUposlenika_Paint(object sender, PaintEventArgs e)
        {
            int index = 0;
            Pen pen = new Pen(Color.Blue);
            foreach (Uposlenik uposlenik in klinika.DajUposlenike())
            {
                int plata = (int)uposlenik.IzracunajPlatu(klinika, DateTime.Now.Year, DateTime.Now.Month);
                e.Graphics.DrawRectangle(pen, new Rectangle(10, index * 50 + 20, plata / 3, 40));
                string plataText = uposlenik.DajImeIPrezime() + ": " + plata;
                e.Graphics.DrawString(plataText, new Font("Times new roman", 10), Brushes.Black, plata / 3 + 20, index * 50 + 20);
                index++;
            }
        }

    }
}
