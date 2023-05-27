using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalatonConsole
{
    public class BalatonCLI
    {
        public static int A_adosav = 800, B_adosav = 600, C_adosav = 100;

        public static List<Record> AdatokBeolvasasa()
        {
            List<Record> adatok = new List<Record>();
            StreamReader reader = new StreamReader("utca.txt");
            string[] adosavok = reader.ReadLine().Split(' ');
            A_adosav = int.Parse(adosavok[0]);
            B_adosav = int.Parse(adosavok[1]);
            C_adosav = int.Parse(adosavok[2]);
            while (!reader.EndOfStream)
            {
                Record egyRecord = new Record(reader.ReadLine());
                adatok.Add(egyRecord);
            }
            return adatok;
        }

        public static int Ado(char adoSav, int terulet)
        {
            int fizetendoAdo = 0;
            if (adoSav == 'A')
            {
                fizetendoAdo = terulet * A_adosav;
            }
            else if (adoSav == 'B')
            {
                fizetendoAdo = terulet * B_adosav;
            }
            else
            {
                fizetendoAdo = terulet * C_adosav;
            }
            if (fizetendoAdo < 10000)
            {
                return 0;
            }
            else
            {
                return fizetendoAdo;
            }
        }
        static void Main(string[] args)
        {
            List<Record> adatok = AdatokBeolvasasa();
            Console.WriteLine($"2. feladat. A mintában {adatok.Count} telek szerepel.");
            Console.Write("3. feladat. Egy tulajdonos adószáma: ");
            string bekertAdoszam = Console.ReadLine();
            bool talalt = false;
            foreach (var adat in adatok)
            {
                if (adat.Adoszam == bekertAdoszam)
                {
                    talalt = true;
                    Console.WriteLine($"{adat.UtcaNev} utca {adat.HazSzam}");
                }
            }
            if (!talalt)
            {
                Console.WriteLine("Nem szerepel az adatállományban.");
            }
            Console.WriteLine("5. feladat");
            Dictionary<char, int> telkekSzamaAdosavonkent = new Dictionary<char, int>();
            Dictionary<char, int> fizetendoAdoAdosavonkent = new Dictionary<char, int>();
            foreach (var item in adatok)
            {
                if (telkekSzamaAdosavonkent.ContainsKey(item.AdoKategoria))
                {
                    telkekSzamaAdosavonkent[item.AdoKategoria] += 1;
                }
                else
                {
                    telkekSzamaAdosavonkent[item.AdoKategoria] = 1;
                }
                if (fizetendoAdoAdosavonkent.ContainsKey(item.AdoKategoria))
                {
                    fizetendoAdoAdosavonkent[item.AdoKategoria] += Ado(item.AdoKategoria, item.Terulet);
                }
                else
                {
                    fizetendoAdoAdosavonkent[item.AdoKategoria] = Ado(item.AdoKategoria, item.Terulet);
                }
            }
            foreach (var item in telkekSzamaAdosavonkent)
            {
                Console.WriteLine($"{item.Key} sávba {item.Value} telek esik, az adó {fizetendoAdoAdosavonkent[item.Key]} Ft.");
            }
            Console.WriteLine("6. feladat:");
            StreamWriter writer = new StreamWriter("teljes.txt");
            foreach (var item in adatok)
            {
                writer.WriteLine($"{item.Adoszam} {item.UtcaNev} {item.HazSzam} {item.AdoKategoria} {item.Terulet} {Ado(item.AdoKategoria, item.Terulet)}");
            }
            writer.Close();
            Console.WriteLine("A teljes.txt fájl elkészült.");
            Console.ReadKey();
        }
    }
}
