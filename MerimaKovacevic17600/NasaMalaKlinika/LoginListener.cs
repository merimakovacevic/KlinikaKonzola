using ConsoleApplication3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaMalaKlinika
{
    public interface LoginListener
    {
        void OnLogin(Osoba osoba);
    }
}
