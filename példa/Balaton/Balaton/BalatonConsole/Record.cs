using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalatonConsole
{
    public class Record
    {
        public string Adoszam
        {
            get;
            private set;
        }

        public string UtcaNev
        {
            get;
            private set;
        }

        public string HazSzam
        {
            get;
            private set;
        }

        public char AdoKategoria
        {
            get;
            set;
        }

        public int Terulet
        {
            get;
            private set;
        }

        public Record(string sor)
        {
            string[] mezok = sor.Split(' ');
            Adoszam=mezok[0];
            UtcaNev=mezok[1];
            HazSzam=mezok[2];
            AdoKategoria = mezok[3][0];
            //AdoKategoria=char.Parse(mezok[3]);
            Terulet = int.Parse(mezok[4]); 
        }
    }
}
