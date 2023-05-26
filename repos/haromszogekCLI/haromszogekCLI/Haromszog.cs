using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haromszogekCLI
{
    public class Haromszog
    {
        public int a { get; private set; }
        public int b { get; private set; }
        public int c { get; private set; }
        public double terulet { get; private set; }
        public Haromszog(int a, int b, int c) {
            this.a = a;
            this.b = b;
            this.c = c;
            this.terulet = (a * b) / 2;
        }
    }
}
