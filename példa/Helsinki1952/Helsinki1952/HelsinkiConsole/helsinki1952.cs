using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelsinkiConsole
{
    public class helsinki1952
    {
        //4. feladat
        public static int HelyezesbolPontszam(int helyezes)
        {
            switch (helyezes)
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

        public static List<Record> AdatokBeolvasasa()
        {
            List<Record> adatok = new List<Record>();
            StreamReader reader = new StreamReader("helsinki.txt");
            while (!reader.EndOfStream)
            {
                Record egyRecord = new Record(reader.ReadLine());
                adatok.Add(egyRecord);
            }
            reader.Close();
            return adatok;
        }
        static void Main(string[] args)
        {
            List<Record> adatok = AdatokBeolvasasa();
            
            Console.WriteLine("3. feladat:");
            Console.WriteLine($"A magyar olimpikonok {adatok.Count} pontszerző helyezést értek el.");
            Console.WriteLine("5. feladat:");
            int tornaPontszam = 0;
            int osszLetszam = 0;
            foreach (var item in adatok)
            {
                osszLetszam += item.TagokSzama;
                if (item.SportagNeve == "torna")
                {
                    tornaPontszam += HelyezesbolPontszam(item.Helyezes);
                }
            }
            Console.WriteLine($"A magyarok {tornaPontszam} pontot szereztek összesen a torna sportágban");
            Console.WriteLine("6. feladat:");
            Console.WriteLine("8. feladat:");
            StreamWriter writer = new StreamWriter("foglalas.txt");
            writer.WriteLine($"Szeretnék asztalokat foglalni {osszLetszam} főre!");
            writer.Close();
            Console.WriteLine("A foglalas.txt fájl elkészült.");
            Dictionary<string,int> pontszamokSportagankent=new Dictionary<string,int>();
            foreach (var item in adatok)
            {
                if (pontszamokSportagankent.ContainsKey(item.SportagNeve))
                {
                    pontszamokSportagankent[item.SportagNeve] += HelyezesbolPontszam(item.Helyezes);
                }
                else
                {
                    pontszamokSportagankent[item.SportagNeve] = HelyezesbolPontszam(item.Helyezes);
                }
            }
            foreach (var item in pontszamokSportagankent)
            {
                Console.WriteLine($"{item.Key} {item.Value} pont");
            }
            Console.ReadKey();
        }
    }
}
