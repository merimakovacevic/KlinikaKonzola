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
    public partial class IzborVrstePregleda : Form
    {
        Klinika klinika;
        public VrstaPregleda vrstaPregleda;
        public IzborVrstePregleda(Klinika k)
        {
            InitializeComponent();
            klinika = k;
        }

        private void IzborVrstePregleda_Load(object sender, EventArgs e)
        {
            treeVrstePregleda.Nodes.Clear();
            foreach (Ordinacija ordinacija in klinika.DajOrdinacije())
            {
                TreeNode node = new TreeNode(ordinacija.imeOrdinacije);
                foreach (VrstaPregleda vp in klinika.vratiListuPregledaPoOrdinacijama(ordinacija))
                {
                    node.Nodes.Add(vp.imePregleda);
                }
                treeVrstePregleda.Nodes.Add(node);
            }
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            if (treeVrstePregleda.SelectedNode == null ||
                treeVrstePregleda.SelectedNode.Parent == null)
            {
                statusStrip1.Show();
                return;
            }
            vrstaPregleda = klinika.PretraziVrstuPregleda(treeVrstePregleda.SelectedNode.Text);
            Close();
        }
    }
}
