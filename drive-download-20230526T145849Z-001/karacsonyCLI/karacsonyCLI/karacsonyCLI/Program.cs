using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace karacsonyCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NapiMunka> list = new List<NapiMunka>();
            //3.
            StreamReader sr = new StreamReader("diszek.txt");
            while (!sr.EndOfStream) 
            {
                NapiMunka nm = new NapiMunka(sr.ReadLine());
                list.Add(nm);
            }
            sr.Close();
            //4.
            Console.WriteLine(NapiMunka.KeszultDb);
            //5. volt-e 0-s nap
            bool vane = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].AngyalkaKesz==0 && list[i].FenyofaKesz==0 && list[i].HarangKesz==0)
                {
                    vane=true;
                }
            }
            if (vane)
            {
                Console.WriteLine("Volt olyan nap amikor egy dísz sem készült");
            }
            else
            {
                Console.WriteLine("Nem volt olyan nap amikor egy dísz sem készült");
            }

            //6. adott napi keszlet
            int angyalkeszlet = 0;
            int harangkeszlet = 0;
            int fenyokeszlet = 0;
            Console.Write("Adja meg a keresett napot [1 ... 40]: ");
            int nap = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < nap; i++)
            {
                angyalkeszlet += list[i].AngyalkaKesz + list[i].AngyalkaEladott;
                harangkeszlet += list[i].HarangKesz + list[i].HarangEladott;
                fenyokeszlet += list[i].FenyofaKesz + list[i].FenyofaEladott;
            }
            Console.WriteLine("A(z) "+nap+". nap végén "+harangkeszlet+" harang, "+angyalkeszlet+" angyalka és "+fenyokeszlet+" fenyőfa maradt készleten.");

            //7. legtobbet eladott
            int eladottangyal = 0;
            int eladottharang = 0;
            int eladottfenyo = 0;
            foreach (var item in list)
            {
                eladottangyal -= item.AngyalkaEladott;
                eladottharang -= item.HarangEladott;
                eladottfenyo -= item.FenyofaEladott;
            }
            /*
            if((eladottangyal >= eladottharang && eladottangyal > eladottfenyo) || (eladottangyal > eladottharang && eladottangyal >= eladottfenyo))
            {
                Console.WriteLine("Angyal: "+eladottangyal);
            }
            if ((eladottharang >= eladottangyal && eladottharang > eladottfenyo) || (eladottharang > eladottangyal && eladottharang >= eladottfenyo))
            {
                Console.WriteLine("Harang: "+eladottharang);
            }
            if ((eladottfenyo >= eladottangyal && eladottfenyo > eladottharang) || (eladottfenyo > eladottangyal && eladottfenyo >= eladottharang))
            {
                Console.WriteLine("Fenyő: "+eladottfenyo);
            }
            */
            int max=Math.Max(Math.Max(eladottfenyo, eladottharang), Math.Max(eladottfenyo,eladottangyal));
            Console.WriteLine("Legtöbbet eladott dísz: "+max+" darab");
            if (eladottangyal == max)
            {
                Console.WriteLine("Angyalka");
            }
            if (eladottfenyo == max)
            {
                Console.WriteLine("Fenyő");
            }
            if (eladottharang == max)
            {
                Console.WriteLine("Harang");
            }
            //8. ha a napi bevetel nagyobb mint 10000Ft, napszam:bevetel bevetel.txt
            int jonap = 0;
            StreamWriter sw = new StreamWriter("bevetel.txt");
            foreach (var item in list)
            {
                if(item.NapiBevetel() >= 10000)
                {
                    jonap++;
                    sw.WriteLine(item.Nap+".nap : "+ item.NapiBevetel()+ " Ft;");
                }
            }
            sw.WriteLine("Ennyi napon lett a bevétel legalább 10000 Ft: " +jonap);
            sw.Close();

            Console.ReadLine();
        }
    }
}
