using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication3;

namespace NasaMalaKlinika
{
    class PretragaDoktora : PretraziOsobu<Doktor>
    {
        public PretragaDoktora(Klinika k) : base(k)
        {
        }

        protected override IEnumerable<Doktor> DajOsobe()
        {
            return klinika.DajDoktore();
        }
    }
}
