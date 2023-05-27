using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace raktarprogram
{
    
    class Termek
    {
        public int cikkszam { get; set; }
        public string termeknev { get; set; }

        public Termek (string cikkszam, string termeknev)
        {
            this.cikkszam = Convert.ToInt32(cikkszam);
            this.termeknev = termeknev;
        }
    }
}
