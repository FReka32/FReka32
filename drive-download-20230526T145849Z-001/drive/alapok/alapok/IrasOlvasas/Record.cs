using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrasOlvasas
{
    internal class Record
    {
        private string nev;
        public long oktAzon;
        public string osztaly;
        public string megJ;

        public String Nev //jellemzo/property
        {
            private set
            {
                if(value.Length > 4)
                {
                    nev = value;    
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Hiba!");
                }
            }
            get
            {
                return nev;
            }
        } 

        public Record() { }
        public Record(string nev, long oktAzon, string osztaly, string megJ)
        {
            Nev = nev;
            this.oktAzon = oktAzon;
            this.osztaly = osztaly;
            this.megJ = megJ;

        }
        public override string ToString() //fuggveny/function
        {
            return $"nev: {nev}\nokatasi a.: {oktAzon}";
        }
    }
}
