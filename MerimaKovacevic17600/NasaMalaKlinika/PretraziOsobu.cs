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
    public abstract partial class PretraziOsobu<T> : Form
    {
        protected Klinika klinika;
        public T izabrani;
        public bool JeLiObavezanIzbor;
        public PretraziOsobu(Klinika k)
        {
            InitializeComponent();
            klinika = k;
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            izabrani = (T)listPacijenti.SelectedItem;
            Close();
        }

        private void textIme_TextChanged(object sender, EventArgs e)
        {
            listPacijenti.Items.Clear();
            foreach (object o in DajOsobe())
            {
                if (o.ToString().ToLower().Contains(textIme.Text)) {
                    listPacijenti.Items.Add(o);
                }
            }
        }

        private void PretraziPacijenta_Load(object sender, EventArgs e)
        {
            textIme_TextChanged(null, null);
        }

        protected abstract IEnumerable<T> DajOsobe();

        private void PretraziOsobu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (JeLiObavezanIzbor && izabrani == null)
            {
                e.Cancel = true;
                statusStrip1.Show();
            }
        }
    }
}
