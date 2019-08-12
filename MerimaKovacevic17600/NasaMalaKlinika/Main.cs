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
    public partial class Main : Form
    {
        Klinika klinika;
        Osoba logovanaOsoba;
        public bool Logout;
        public Main(Klinika k, Osoba logovani)
        {
            InitializeComponent();
            klinika = k;
            logovanaOsoba = logovani;
            if (logovanaOsoba is Pacijent)
            {
                menuOpcije.DropDownItems.Remove(dodajNovogPacijentaToolStripMenuItem);
                menuOpcije.DropDownItems.Remove(dodajNoviPregledToolStripMenuItem);
                menuOpcije.DropDownItems.Remove(kreirajKartonToolStripMenuItem);
                menuOpcije.DropDownItems.Remove(pregledajPacijentaToolStripMenuItem);
                menuOpcije.DropDownItems.Remove(plateUposlenikaToolStripMenuItem);
                menuOpcije.DropDownItems.Remove(naplataToolStripMenuItem);
                tabControl1.TabPages.Remove(tabListaOrdinacija);
                tabControl1.TabPages.Remove(tabListaPacijenata);
                pictureBox1.Image = ((Pacijent)logovanaOsoba).slika;
            } else if (logovanaOsoba is Doktor)
            {
                menuOpcije.DropDownItems.Remove(dodajNovogPacijentaToolStripMenuItem);
                menuOpcije.DropDownItems.Remove(kreirajKartonToolStripMenuItem);
                menuOpcije.DropDownItems.Remove(naplataToolStripMenuItem);
            } else
            {
                menuOpcije.DropDownItems.Remove(pregledajPacijentaToolStripMenuItem);
            }
        }

        private void dodajNovogPacijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NoviPacijent(klinika).ShowDialog();
            InitPacijente();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void verzijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0.1.0");
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merima Kovacevic");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitOKorisniku();
            InitPacijente();
        }
        

        private void kreirajKartonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PretragaPacijenta pacijent = new PretragaPacijenta(klinika);
            pacijent.ShowDialog();
            if (pacijent.izabrani != null)
            {
                UnosKartona unos = new UnosKartona(pacijent.izabrani);
                unos.ShowDialog();
                InitPacijente();
            }
        }

        private void pregledZaVozackiIspitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PretragaPacijenta pacijent = new PretragaPacijenta(klinika);
            pacijent.ShowDialog();
            if (pacijent.izabrani != null)
            {
                Pacijent izabrani = pacijent.izabrani;
                izabrani.DodajNovePreglede(new List<VrstaPregleda>
                {
                klinika.PretraziVrstuPregleda("pregled zuba za vozacki ispit/prijavu na konkurs"),
                klinika.PretraziVrstuPregleda("ekg pregled za vozacki ispit/prijavu na konkurs"),
                klinika.PretraziVrstuPregleda("pregled ocnog pritiska za vozacki ispit/prijavu na konkurs")
                });
                InitPacijente();
            }
        }

        private void pregledZaKonkursToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PretragaPacijenta pacijent = new PretragaPacijenta(klinika);
            pacijent.ShowDialog();
            if (pacijent.izabrani != null)
            {
                Pacijent izabrani = pacijent.izabrani;
                izabrani.DodajNovePreglede(new List<VrstaPregleda>
                {
                    klinika.PretraziVrstuPregleda("pregled zuba za vozacki ispit/prijavu na konkurs"),
                    klinika.PretraziVrstuPregleda("dermatoloski obicni pregled za prijavu na konkurs"),
                    klinika.PretraziVrstuPregleda("ekg pregled za vozacki ispit/prijavu na konkurs"),
                    klinika.PretraziVrstuPregleda("pregled ocnog pritiska za vozacki ispit/prijavu na konkurs")
                });
                InitPacijente();
            }
        }

        private void regularniPregledToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PretragaPacijenta pacijent = new PretragaPacijenta(klinika);
            pacijent.ShowDialog();
            if (pacijent.izabrani != null)
            {
                IzborVrstePregleda izbor = new IzborVrstePregleda(klinika);
                izbor.ShowDialog();
                pacijent.izabrani.DodajNovePreglede(new List<VrstaPregleda> { izbor.vrstaPregleda });
                InitPacijente();
            }
        }

        void InitOKorisniku()
        {
            DodajAtributOKorisniku("Ime i prezime", logovanaOsoba.DajImeIPrezime());
            if (logovanaOsoba is Uposlenik)
            {
                Uposlenik uposlenik = (Uposlenik)logovanaOsoba;
                DodajAtributOKorisniku("Plata za ovaj mjesec", uposlenik.IzracunajPlatu(klinika, DateTime.Now.Year, DateTime.Now.Month).ToString());
                DodajAtributOKorisniku("Korisnicko ime", uposlenik.DajKorisnickoIme());
            }
            else if (logovanaOsoba is Pacijent)
            {
                Pacijent pacijent = (Pacijent)logovanaOsoba;
                DodajAtributOKorisniku("Adresa", pacijent.adresaStanovanja);
                DodajAtributOKorisniku("Bracno stanje", pacijent.bracnoStanje);
                DodajAtributOKorisniku("Datum rodjenja", pacijent.datumRodjenja.ToShortDateString());
                DodajAtributOKorisniku("Spol", pacijent.spol);
                DodajAtributOKorisniku("Sljedeci pregled", pacijent.trenutniPregledi.Count == 0 ? "/" : pacijent.trenutniPregledi[0].imePregleda);
                DodajAtributOKorisniku("Danasnji dug", pacijent.DosadasnjaCijena.ToString() + " KM");
            }
        }

        void DodajAtributOKorisniku(string ime, string vrijednost)
        {
            gridOKorisniku.Rows.Add(ime, vrijednost);
        }

        void InitOrdinacije()
        {
            treeOrdinacije.Nodes.Clear();
            gridZauzetost.Rows.Clear();
            foreach (Ordinacija ordinacija in klinika.DajOrdinacije())
            {
                TreeNode node = new TreeNode(ordinacija.imeOrdinacije);
                foreach (Pacijent pacijent in ordinacija.redPacijenataUOrdinaciji)
                {
                    node.Nodes.Add(new TreeNode(pacijent.DajImeIPrezime()));
                }
                treeOrdinacije.Nodes.Add(node);

                gridZauzetost.Rows.Add(ordinacija.imeOrdinacije, ordinacija.redPacijenataUOrdinaciji.Count > 0);
            }

            
        }

        void InitPacijente()
        {
            gridPacijenti.Rows.Clear();
            foreach (Pacijent pacijent in klinika.DajPacijente())
            {
                DodajPacijenta(pacijent);
            }
            InitOrdinacije();
        }

        void DodajPacijenta(Pacijent pacijent)
        {
            gridPacijenti.Rows.Add(new object[]
            {
                pacijent.DajImeIPrezime(),
                pacijent.spol,
                pacijent.datumRodjenja,
                pacijent.datumPrijema,
                pacijent.trenutniPregledi.Count > 0 ? pacijent.trenutniPregledi[0].imePregleda : "/",
                pacijent.DosadasnjaCijena
            });
        }

        private void hitanPregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VrstaPregleda hitanSlucaj = klinika.PretraziVrstuPregleda("hitan slucaj");
            UnosAnamneze unosAnamneze = new UnosAnamneze(hitanSlucaj);
            unosAnamneze.ShowDialog();
            string anamneza = unosAnamneze.tekst;
            PretragaDoktora pretragaDoktora = new PretragaDoktora(klinika);
            pretragaDoktora.JeLiObavezanIzbor = true;
            pretragaDoktora.ShowDialog();
            PretragaPacijenta pretragaPacijenta = new PretragaPacijenta(klinika);
            pretragaPacijenta.ShowDialog();
            Pacijent izabrani = pretragaPacijenta.izabrani;
            if (izabrani == null)
            {
                NoviPacijent noviPacijent;
                do
                {
                    noviPacijent = new NoviPacijent(klinika);
                    noviPacijent.ShowDialog();
                    izabrani = noviPacijent.napravljeni;
                } while (izabrani == null);
            }

            if (izabrani.karton == null)
            {
                PrikaziPoruku("Izabrani pacijent nema kartona, bice automatski kreiran");
                izabrani.DodajKarton(new Karton("DOSAO NA HITAN PREGLED", "Nema informacija", izabrani));
            }

            Pregled pregled = new Pregled(anamneza, hitanSlucaj, pretragaDoktora.izabrani);
            izabrani.PregledajBezPlacanja(pregled);
        }

        void PrikaziPoruku(string text)
        {
            toolStripPoruka.Text = text;
            statusStrip1.Show();
            timer1.Start();
        }

        private void plateUposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PlateUposlenika(klinika).ShowDialog();
        }

        private void pregledajPacijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PretragaOrdinacija ordinacije;
            do
            {
                ordinacije = new PretragaOrdinacija(klinika);
                ordinacije.JeLiObavezanIzbor = true;
                ordinacije.ShowDialog();
                if (ordinacije.izabrani.doktor != logovanaOsoba)
                {
                    PrikaziPoruku("Logovani doktor ne pripada ovoj ordinaciji");
                } else
                {
                    break;
                }
            } while (true);
            if (ordinacije.izabrani.redPacijenataUOrdinaciji.Count == 0)
            {
                PrikaziPoruku("Nema pacijenata u ovoj ordinaciji");
                return;
            }
            Pacijent pacijent = ordinacije.izabrani.UzmiSljedecegPacijenta();
            if (pacijent.karton == null)
            {
                PrikaziPoruku("Pacijent nema karton");
                return;
            }
            VrstaPregleda vrsta = pacijent.trenutniPregledi[0];
            UnosAnamneze anamneza = new UnosAnamneze(vrsta, pacijent);
            anamneza.ShowDialog();
            pacijent.Pregledaj(new Pregled(anamneza.tekst, vrsta, (Doktor)logovanaOsoba));
            InitPacijente();
        }

        private void izlogujSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout = true;
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            statusStrip1.Hide();
        }

        private void uplataZaDanasnjiDanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PretragaPacijenta pretraga = new PretragaPacijenta(klinika);
            pretraga.ShowDialog();
            if (pretraga.izabrani != null)
            {
                new UplataDanas(pretraga.izabrani).ShowDialog();
                InitPacijente();
            }
        }
    }
}
