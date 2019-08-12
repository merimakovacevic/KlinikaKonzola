using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public sealed class Karton
    {
        public List<Pregled> dosadasnjiPregledi { get; private set; }
        public string listaProslihBolesti { get; private set; }
        public string napomene { get; private set; }
        public Pacijent pacijent { get; private set; }
        public Karton(string napomene, string prosleBolesti, Pacijent pacijent)
        {
            this.napomene = napomene;
            listaProslihBolesti = prosleBolesti;
            this.pacijent = pacijent;
            dosadasnjiPregledi = new List<Pregled>();
        }
       
    }
}
