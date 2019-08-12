namespace ConsoleApplication3
{
    abstract public class Uposlenik : Osoba
    {
        string korisnickoIme;
        double plata;
        virtual public double IzracunajPlatu(Klinika k, int godina, int mjesec)
        {
            return plata;
        }
        public Uposlenik(string ime, string prezime, double plata) : base(ime, prezime)
        {
            this.plata = plata;
        }
        public bool JeLiTacanLogin(string username, string password)
        {
            return korisnickoIme == username && JeLiPasswordTacan(password);
        }
        public void PostaviAutentikaciju(string username, string password)
        {
            korisnickoIme = username;
            PostaviPassword(password);
        }
        public string DajKorisnickoIme()
        {
            return korisnickoIme;
        }
    }
}