using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalatonCLI
{
    internal class Telek
    {
        public string adoszam { get; set; }
        public string utca { get; set; }
        public string hazszam { get; set; }
        public char sav { get; set; }
        public int terulet { get; set; }
        public Telek(string sor)
        {
            string[] adatok = sor.Split(' ');
            adoszam = adatok[0];
            utca = adatok[1];
            hazszam = adatok[2];
            sav = adatok[3][0];
            int ez;
            terulet = int.TryParse(adatok[4], out ez) ? ez : 0;
        }
    }
}
