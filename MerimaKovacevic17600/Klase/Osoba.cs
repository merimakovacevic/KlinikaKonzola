using Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    abstract public class Osoba
    {
        public Osoba(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }
        protected string ime { get; private set; }
        protected string prezime { get; private set; }
        string password;
        public string DajImeIPrezime()
        {
            return ime + " " + prezime;
        }
        public override string ToString()
        {
            return DajImeIPrezime();
        }
        protected void PostaviPassword(string password)
        {
            this.password = Utilities.DajMD5(password);
        }
        public bool ImaLiPassword()
        {
            return password != null;
        }
        public bool JeLiPasswordTacan(string password)
        {
            return this.password == Utilities.DajMD5(password);
        }
    }
}
