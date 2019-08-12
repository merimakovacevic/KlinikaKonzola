using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public sealed class Pregled
    {
        public DateTime datumPregleda { get; private set; }
        public string opisPregleda { get; private set; }
        public VrstaPregleda vrsta { get; private set; }
        public Doktor doktor { get; private set; }

        public Pregled(string anamneza, VrstaPregleda pregled, Doktor doc)
        {
            opisPregleda = anamneza;
            vrsta = pregled;
            doktor = doc;
            datumPregleda = DateTime.Now;
        }
        
    }
}
