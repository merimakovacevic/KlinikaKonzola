using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public sealed class Klinika
    {
        List<Ordinacija> ordinacije;
        List<Osoba> osobe;
        List<VrstaPregleda> sveVrstePregleda;

        public Klinika()
        {
            ordinacije = new List<Ordinacija>();
            sveVrstePregleda = new List<VrstaPregleda>();
            osobe = new List<Osoba>();

            osobe.Add(new Doktor("Doktor 1", "Prezime 1", 700));
            osobe.Add(new Doktor("Doktor 2", "Prezime 2", 1000));
            osobe.Add(new Doktor("Doktor 3", "Prezime 3", 800));
            osobe.Add(new Doktor("Doktor 4", "Prezime 4", 1200));

            Aparat aparat17600_uv = new Aparat("UV Lampa");
            Aparat aparat17600_ekg = new Aparat("EKG");
            Aparat aparat17600_lampa = new Aparat("UV Lampa za polimerizaciju"); //stomatologija
            Aparat aparat17600_rentgenzuba = new Aparat("Rentgen za snimanje zuba");
            Aparat aparat17600_rtg = new Aparat("RTG aparat"); //stomatologija
            Aparat aparat17600_dermatoskop = new Aparat("Dermatoskop");
            Aparat aparat17600_laserfoto = new Aparat("Laserski koagulator"); //oftalmologija
            Aparat aparat17600_slitlamp = new Aparat("Slit lamp sa digitalnom kamerom"); //oftalmologija
            Aparat aparat17600_lensometar = new Aparat("Auto lensometar sa ekranom u boji"); //oftalmologija
            Aparat aparat17600_ultrazvuk = new Aparat("Ultrazvucni aparat"); //kardiologija

            Ordinacija ordinacija17600_dermatologija = new Ordinacija("Dermatologija", (Doktor) osobe[0], new List<Aparat> { aparat17600_uv, aparat17600_dermatoskop });
            Ordinacija ordinacija17600_kardiologija = new Ordinacija("Kardiologija", (Doktor)osobe[1], new List<Aparat> { aparat17600_ekg, aparat17600_ultrazvuk });
            Ordinacija ordinacija17600_stomatologija = new Ordinacija("Stomatologija", (Doktor)osobe[2], new List<Aparat> { aparat17600_rtg, aparat17600_lampa, aparat17600_rentgenzuba });
            Ordinacija ordinacija17600_oftamologija = new Ordinacija("Oftamologija", (Doktor)osobe[3], new List<Aparat> { aparat17600_lensometar, aparat17600_slitlamp });
            ((Doktor)osobe[0]).PostaviAutentikaciju("doktor.1", "sifra");
            ((Doktor)osobe[1]).PostaviAutentikaciju("doktor.2", "sifra");
            ((Doktor)osobe[2]).PostaviAutentikaciju("doktor.3", "sifra");
            ((Doktor)osobe[3]).PostaviAutentikaciju("doktor.4", "sifra");

            ordinacije.Add(ordinacija17600_dermatologija);
            ordinacije.Add(ordinacija17600_kardiologija);
            ordinacije.Add(ordinacija17600_stomatologija);
            ordinacije.Add(ordinacija17600_oftamologija);

            osobe.Add(new Pacijent("Ana", "Anic", new DateTime(1994, 11, 21), "2111994014980", "y", "neudata", "Mustafe Pintola br 10", null));
            osobe.Add(new Pacijent("Sebija", "Sebic", new DateTime(1990, 04, 01), "0104996170014", "z", "udata", "Titova br 100", null));
            osobe.Add(new Pacijent("Adi", "Adic", new DateTime(1991, 05, 10), "1005991170014", "m", "ozenjen", "Ferhadija br 125", null));
            osobe.Add(new Pacijent("Hari", "Haric", new DateTime(1980, 01, 27), "2701980123800", "m", "neozenjen", "Semira Fraste br 6", null));

            osobe.Add(new Osoblje("Portir", "Vrataric", 10));
            ((Osoblje)osobe[8]).PostaviAutentikaciju("portir", "sifra");
            osobe.Add(new Tehnicar("Tessa", "Smith", 500));
            ((Tehnicar)osobe[9]).PostaviAutentikaciju("medsister", "sifra");

            sveVrstePregleda.Add(new VrstaPregleda("Pregled zuba", 20, new List<Aparat> { }, ordinacija17600_stomatologija));
            sveVrstePregleda.Add(new VrstaPregleda("Hitan slucaj", 0, new List<Aparat> { }, null));
            sveVrstePregleda.Add(new VrstaPregleda("Mjerenje pritiska", 20, new List<Aparat> { }, ordinacija17600_kardiologija));
            sveVrstePregleda.Add(new VrstaPregleda("EKG pregled", 30, new List<Aparat> { aparat17600_ekg }, ordinacija17600_kardiologija));
            sveVrstePregleda.Add(new VrstaPregleda("Dermatoloski obicni pregled", 20, new List<Aparat> { }, ordinacija17600_dermatologija));
            sveVrstePregleda.Add(new VrstaPregleda("Dermatoloski napredni pregled", 30, new List<Aparat> { aparat17600_uv }, ordinacija17600_dermatologija));
            sveVrstePregleda.Add(new VrstaPregleda("Pregled ocnog pritiska", 20, new List<Aparat> { }, ordinacija17600_oftamologija));

            sveVrstePregleda.Add(new VrstaPregleda("Pregled zuba za vozacki ispit/prijavu na konkurs", 10, new List<Aparat> { }, ordinacija17600_stomatologija));
            sveVrstePregleda.Add(new VrstaPregleda("EKG pregled za vozacki ispit/prijavu na konkurs", 15, new List<Aparat> { aparat17600_ekg }, ordinacija17600_kardiologija));
            sveVrstePregleda.Add(new VrstaPregleda("Pregled ocnog pritiska za vozacki ispit/prijavu na konkurs", 10, new List<Aparat> { }, ordinacija17600_oftamologija));
            sveVrstePregleda.Add(new VrstaPregleda("Dermatoloski obicni pregled za prijavu na konkurs", 10, new List<Aparat> { }, ordinacija17600_dermatologija));
        }

        public List<VrstaPregleda> vratiListuPregledaPoOrdinacijama(Ordinacija ordinacija)
        {
            List<VrstaPregleda> vratiti = new List<VrstaPregleda>();
            foreach(VrstaPregleda vrsta in sveVrstePregleda)
            {
                if (vrsta.ordinacija == ordinacija)
                {
                    vratiti.Add(vrsta);
                }
            }
            return vratiti;
        }

        public IEnumerable<Pacijent> DajPacijente()
        {
            return osobe
                .Where((Osoba osoba) => osoba is Pacijent)
                .Select((Osoba osoba) => (Pacijent)osoba);
        }

        public IEnumerable<Uposlenik> DajUposlenike()
        {
            return osobe
                .Where((Osoba osoba) => osoba is Uposlenik)
                .Select((Osoba osoba) => (Uposlenik)osoba);
        }

        public IEnumerable<Doktor> DajDoktore()
        {
            return osobe
                .Where((Osoba osoba) => osoba is Doktor)
                .Select((Osoba osoba) => (Doktor)osoba);
        }

        public IEnumerable<Ordinacija> DajOrdinacije()
        {
            return ordinacije;
        }

        public VrstaPregleda PretraziVrstuPregleda(string naziv)
        {
            foreach(VrstaPregleda vrsta in sveVrstePregleda)
            {
                if (vrsta.imePregleda.ToLower() == naziv.ToLower()) return vrsta;
            }
            return null;
        }

        public void DodajNovogPacijenta(Pacijent p)
        {
            osobe.Add(p);
        }

        public List<Pacijent> NadjiPacijente(string pretraga)
        {
            List<Pacijent> pacijenti = new List<Pacijent>();
            foreach(Osoba osoba in osobe)
            {
                if (osoba is Pacijent)
                {
                    Pacijent pacijent = (Pacijent)osoba;
                    if (pacijent.DajImeIPrezime().ToLower().Contains(pretraga.ToLower()))
                    {
                        pacijenti.Add(pacijent);
                    }
                }
            }
            return pacijenti;
        }

        public Karton NadjiKarton(int id)
        {
            foreach (Osoba osoba in osobe)
            {
                if (osoba is Pacijent)
                {
                    Pacijent pacijent = (Pacijent)osoba;
                    if (pacijent.ID == id && pacijent.karton != null)
                    {
                        return pacijent.karton;
                    }
                }
            }
            return null;
        }
    }
}
