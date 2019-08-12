using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication3;

namespace NasaMalaKlinika
{
    class PretragaPacijenta : PretraziOsobu<Pacijent>
    {
        public PretragaPacijenta(Klinika k) : base(k)
        {
        }

        protected override IEnumerable<Pacijent> DajOsobe()
        {
            return this.klinika.DajPacijente();
        }
    }
}
