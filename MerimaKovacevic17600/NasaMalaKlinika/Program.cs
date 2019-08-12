using ConsoleApplication3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NasaMalaKlinika
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Klinika klinika_17600 = new Klinika();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginTip(klinika_17600));
            // Application.Run(new Main(klinika_17600, klinika_17600.DajUposlenike().First()));
        }
    }
}
