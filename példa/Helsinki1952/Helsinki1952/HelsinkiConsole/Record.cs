using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelsinkiConsole
{
    public class Record
    {
        public int Helyezes
        {
            get;
            private set;
        }

        public int TagokSzama
        {
            get;
            private set;
        }

        public string SportagNeve
        {
            get;
            private set;
        }

        public string VersenyszamNeve
        {
            get;
            private set;
        }

        public int Pontszam
        {
            get
            {
                switch (Helyezes)
                {
                    case 1:
                        {
                            return 7;
                        }
                    case 2:
                        {
                            return 5;
                        }
                    case 3:
                        {
                            return 4;
                        }
                    case 4:
                        {
                            return 3;
                        }
                    case 5:
                        {
                            return 2;
                        }
                    case 6:
                        {
                            return 1;
                        }
                    default:
                        {
                            return 0;
                        }
                }
            }
        }

        public Record(string sor)
        {
            string[] mezok = sor.Split(' ');
            Helyezes = int.Parse(mezok[0]);
            TagokSzama = int.Parse(mezok[1]);
            SportagNeve = mezok[2];
            VersenyszamNeve = mezok[3];
        }
    }
}
