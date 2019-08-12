using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public sealed class Pacijent : Osoba
    {
        public Int32 ID { get; private set; }
        public Karton karton { get; private set; }
        public DateTime datumRodjenja { get; private set; }
        public string maticni { get; private set; }
        public string spol { get; private set; }
        public string adresaStanovanja { get; private set; }
        public string bracnoStanje { get; private set; }
        public DateTime datumPrijema { get; private set; }
        public List<VrstaPregleda> trenutniPregledi { get; private set; }
        public double DosadasnjaCijena { get; private set; }
        public List<VrstaPregleda> dosadasnjiNeplaceniPregledi { get; private set; }
        public List<Rata> listaRata { get; private set; }
        public Image slika { get; private set; }

        public Pacijent (string ime1, string prezime1, DateTime datum1, string maticni1, string spol1, string bracnos, string adresa, Image profilna): base(ime1, prezime1)
        {
            ID = IDManager.dajNoviID();
            spol = spol1;
            bracnoStanje = bracnos;
            adresaStanovanja = adresa;
            datumRodjenja = datum1;
            datumPrijema = DateTime.Now;
            maticni = maticni1;
            trenutniPregledi = new List<VrstaPregleda>();
            listaRata = new List<Rata>();
            dosadasnjiNeplaceniPregledi = new List<VrstaPregleda>();
            slika = profilna;
        }

        public void DodajKarton(Karton k)
        {
            karton = k;
        }

        public void ObrisiKarton()
        {
            karton = null;
        }

        public void DodajNovePreglede(List<VrstaPregleda> vrste)
        {
            foreach (VrstaPregleda vrsta in vrste)
            {
                foreach (Aparat aparat in vrsta.potrebniAparati)
                {
                    if (!aparat.uFunkciji)
                    {
                        // Console.WriteLine("Aparat " + aparat.naziv + " nije u funkciji, te pregled " + vrsta.imePregleda + " nije moguce obaviti");
                        throw new Exception("Aparat nije u funkciji");
                    }
                }
            }
            foreach (VrstaPregleda vrsta in vrste)
            {
                if (trenutniPregledi.Count == 0)
                {
                    vrsta.ordinacija.DodajPacijentaURed(this);
                }
                trenutniPregledi.Add(vrsta);
            }
        }

        public void Pregledaj(Pregled pregled)
        {
            this.karton.dosadasnjiPregledi.Add(pregled);
            this.dosadasnjiNeplaceniPregledi.Add(pregled.vrsta);
            this.trenutniPregledi.Remove(pregled.vrsta);
            DosadasnjaCijena += pregled.vrsta.cijenaPregleda;
            if (trenutniPregledi.Count > 0)
            {
                trenutniPregledi[0].ordinacija.DodajPacijentaURed(this);
            }
        }

        public void PregledajBezPlacanja(Pregled pregled)
        {
            this.karton.dosadasnjiPregledi.Add(pregled);
        }

        public void Plati()
        {
            DosadasnjaCijena = 0;
            dosadasnjiNeplaceniPregledi.Clear();
        }

        public void Plati(Rata rata)
        {
            Plati();
            listaRata.Add(rata);
        }

        public bool JeLiRedovan()
        {
            return karton.dosadasnjiPregledi.Count > 3;
        }

        public void PostaviAutentikaciju(string password)
        {
            PostaviPassword(password);
        }

        public bool JeLiTajPacijent(string ime, string prezime)
        {
            return ime.ToLower() == this.ime.ToLower() &&
                prezime.ToLower() == this.prezime.ToLower();
        }
    }
}
