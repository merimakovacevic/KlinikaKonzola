using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase
{
    public class Validacije
    {
        public static bool JeLiSifraValidna(string password)
        {
            return password.Length >= 6;
        }

        public static bool JeLiImeValidno(string ime)
        {
            return ime.Length > 0;
        }

        public static bool JeLiPrezimeValidno(string prezime)
        {
            return prezime.Length > 0;
        }

        public static bool JeLiMaticniBrojValidan(string maticni, DateTime datumRodjenja)
        {
            return Utilities.TacanMaticniBroj(maticni, datumRodjenja);
        }

        public static bool JeLiAdresaValidna(string adresa)
        {
            return adresa.Length > 0;
        }

        public static bool JeLiDatumRodjenjaValidan(DateTime datum)
        {
            return (datum - DateTime.Now).Days < 0 && datum < DateTime.Now;
        }

        public static bool JeLiSpolValidan(string spol)
        {
            return spol.Length > 0;
        }

        public static bool JeLiBracnoStanjeValidno(string bracnoStanje)
        {
            return bracnoStanje.Length > 0;
        }
    }
}
