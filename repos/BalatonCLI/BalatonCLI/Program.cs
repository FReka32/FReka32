using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalatonCLI
{
    public class Program
    {
        static List<Telek> telekLista = new List<Telek>();
        static int[] savArak = new int[3];
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("utca.txt");
            string[] sor = sr.ReadLine().Split(' ');
            for (int i = 0; i < 3; i++)
            {
                savArak[i] = int.Parse(sor[i]);
            }
                
            while (!sr.EndOfStream)
            {
                //1.feladat telkek tárolása
                telekLista.Add(new Telek(sr.ReadLine()));
            }

            sr.Close();
            Console.WriteLine("2. feladat. A mintában "+telekLista.Count()+" telek szerepel.");
            Console.Write("3. feladat Egy tulajdonos adószáma: ");
            string adoszam = Console.ReadLine();
            TulajAdatai(adoszam);
            Console.WriteLine("5. feladat.");
            ArakSavonkent();
            Console.ReadLine();
        }
        private static int TulajAdatai(string adoszam)
        {
            int db = 0;
            foreach (Telek telek in telekLista)
                if (telek.adoszam == adoszam)
                {
                    Console.WriteLine(telek.utca + " utca " + telek.hazszam);
                    db++;
                }
            if (db == 0)
            {
                Console.WriteLine("Nem szerepel az adatállományban");
            }
            return db;
        }
        static int ado(char sav, int terulet)
        {
            int osszeg = savArak[sav - 65] * terulet;

            return osszeg < 10000 ? 0 : osszeg;
        }
        private static void ArakSavonkent()
        {
            int[] db = new int[3];
            int[] osszAdo = new int[3];
            foreach (Telek telek in telekLista)
            {
                db[telek.sav - (int)'A']++;
                osszAdo[telek.sav - (int)'A'] += ado(telek.sav, telek.terulet);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine((char)(i + 'A') + " sávba " + db[i] +" telek esik, az adó "+osszAdo[i]+" Ft.");
            }
                
        }

    }
}
