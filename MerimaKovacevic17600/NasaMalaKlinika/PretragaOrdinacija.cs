using ConsoleApplication3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaMalaKlinika
{
    class PretragaOrdinacija : PretraziOsobu<Ordinacija>
    {
        public PretragaOrdinacija(Klinika k) : base(k)
        {
        }

        protected override IEnumerable<Ordinacija> DajOsobe()
        {
            return klinika.DajOrdinacije();
        }
    }
}
