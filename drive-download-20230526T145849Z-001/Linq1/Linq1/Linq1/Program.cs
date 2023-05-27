using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    class termek
    {
        public string nev { get; set; }
        public int db { get; set; }

        public termek(string nev, int db)
        {
            this.nev = nev;
            this.db = db;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            //LINQ
            //Lista előkészítése
            List<termek> lista = new List<termek>();
            lista.Add(new termek("alma", 10));
            lista.Add(new termek("alma", 23));
            lista.Add(new termek("körte", 13));
            lista.Add(new termek("körte", 6));
            lista.Add(new termek("tojás", 5));
            lista.Add(new termek("alma", 17));
            lista.Add(new termek("tojás", 25));
            lista.Add(new termek("tojás", 6));
            lista.Add(new termek("tojás", 2));
            lista.Add(new termek("sajt", 25));

            /*foreach (termek termek in lista)
            {
                Console.WriteLine(termek.nev +" "+termek.db );
            }*/

            //rendezés order by-al db szerint

            var rendezettlista = lista.OrderBy(k=>k.db).ToList();

            foreach (termek termek in rendezettlista)
            {
                //Console.WriteLine(termek.nev + " " + termek.db);
            }
            //rendezés order by-al abc szerint

            var rendezettlistaabc = lista.OrderBy(k => k.nev).ToList();

            foreach (termek termek in rendezettlistaabc)
            {
                //Console.WriteLine(termek.nev + " " + termek.db);
            }

            //másodlagos rendezés
            var rendezettlistamasodlagos = lista.OrderBy(k => k.nev).ThenBy(k=>k.db).ToList();

            foreach (termek termek in rendezettlistamasodlagos)
            {
                //Console.WriteLine(termek.nev + " " + termek.db);
            }

            //csökkenő sorrend
            var rendezettlistacsokkeno = lista.OrderByDescending(k => k.db).ToList();

            foreach (termek termek in rendezettlistacsokkeno)
            {
                //Console.WriteLine(termek.nev + " " + termek.db);
            }

            //első elem kiválasztása (első max érték)
            termek maxtermek = lista.OrderByDescending(k => k.db).First();

            //Console.WriteLine("A legtöbb darabos termék: "+maxtermek.nev+ " " +maxtermek.db+ " db");

            //max kiválasztása megadott kulcs szerint

            int max = lista.Max(k=>k.db);
            //Console.WriteLine("A legtöbb darabos termékek: ");
            foreach (var item in rendezettlistacsokkeno)
            {
                if(item.db == max)
                {
                    //Console.WriteLine(item.nev+ " " +item.db+ " db");
                }
            }

            //almák

            var almalista = lista.Where(k => k.nev == "alma").OrderBy(k=>k.db);
            int maximumalmadb = lista.Where(k => k.nev == "alma").OrderBy(k => k.db).Max(k=>k.db);
            //Console.WriteLine("A legtöbb alma: "+maximumalmadb);
            int almateteldb = lista.Where(k => k.nev == "alma").OrderBy(k => k.db).Count();
            //Console.WriteLine("Alma tétel a listán: "+almateteldb + " db");
            foreach (var item in almalista)
            {
                //Console.WriteLine(item.nev + " " + item.db);
            }


            //almák darabszáma

            int almakszama = lista.Where(k => k.nev == "alma").Sum(k=>k.db);
            //Console.WriteLine("Almák száma összesen: " +almakszama+ " db");

            //almák száma átlagosan

            double almakszamaatlagosan = lista.Where(k => k.nev == "alma").Average(k => k.db);
            //Console.WriteLine("Almák száma átlagosan: " + almakszamaatlagosan + " db");

            //maximum

            /*
              1. A körték minden adata:
              2. Az összes tétel Fordított ABC rendben:
              3. A tojások darabszám szerint csökkenő sorrendben (OrderByDescendig)
              4. Melyik a körték legelső elleme?
              5. Melyikből van több db körtéből vagy tojásból?      
            //6. Melyik termékcsoportból van a legtöbb darab összesen
              */

            //1.
            Console.WriteLine("1. A körték minden adata:");
            var kortelista = lista.Where(k => k.nev == "körte");
            Console.WriteLine("Körték listája: ");
            foreach (var item in kortelista)
            {
                Console.WriteLine(item.nev + " " + item.db+" db");
            }
            int maximumkortedb = lista.Where(k => k.nev == "körte").OrderBy(k => k.db).Max(k => k.db);
            Console.WriteLine("A legtöbb körte: " + maximumkortedb);
            int minimumkortedb = lista.Where(k => k.nev == "körte").OrderBy(k => k.db).Min(k => k.db);
            Console.WriteLine("A legkevesebb körte: " + minimumkortedb);
            int korteteteldb = lista.Where(k => k.nev == "körte").OrderBy(k => k.db).Count();
            Console.WriteLine("Körte tétel a listán: " + korteteteldb + " db");
           
            //körték darabszáma
            int kortekszama = lista.Where(k => k.nev == "körte").Sum(k => k.db);
            Console.WriteLine("Körték száma összesen: " + kortekszama + " db");
            //körték száma átlagosan
            double kortekszamaatlagosan = lista.Where(k => k.nev == "körte").Average(k => k.db);
            Console.WriteLine("Körték száma átlagosan: " + kortekszamaatlagosan + " db");

            //2.
            Console.WriteLine("2. Az összes tétel Fordított ABC rendben:");
            var osszestetelforditott = lista.OrderByDescending(k => k.nev).ToList();
            foreach (var item in osszestetelforditott)
            {
                Console.WriteLine(item.nev + " " + item.db);
            }
            //3.
            Console.WriteLine("3. A tojások darabszám szerint csökkenő sorrendben (OrderByDescendig)");
            var tojasoklistadbforditva = lista.Where(k => k.nev == "tojás").OrderByDescending(k => k.db);
            foreach (var item in tojasoklistadbforditva)
            {
                Console.WriteLine(item.nev + " " + item.db);
            }
            //4.
            Console.WriteLine("4. Melyik a körték legelső eleme?");
            foreach (var item in lista)
            {
                if (item.nev == "körte")
                {
                    Console.WriteLine("Körték legelső eleme: "+item.nev +" "+item.db+" db");
                    break;
                }
            }
            //var elsokorte = kortelista.First();
            //Console.WriteLine(elsokorte.nev +" "+elsokorte.db+ " db");
            //5.
            Console.WriteLine("5. Melyikből van több db körtéből vagy tojásból? ");
            int tojasokszama = lista.Where(k => k.nev == "tojás").Sum(k => k.db);
            if(kortekszama > tojasokszama)
            {
                Console.WriteLine("Körtéből van több");
            }
            else if( kortekszama== tojasokszama)
            {
                Console.WriteLine("Ugyanannyi körte és tojás van");
            }
            else
            {
                Console.WriteLine("Tojásból van több");
            }

            //6.
            Console.WriteLine("6. Melyik termékcsoportból van a legtöbb darab összesen?");
            List<int> darabszamok = new List<int>();
            darabszamok.Add(almakszama);
            darabszamok.Add(kortekszama);
            darabszamok.Add(tojasokszama);
            int maxdb = darabszamok.Max();
            if(maxdb == almakszama)
            {
                Console.WriteLine("Almából van a legtöbb");
            }
            else if( maxdb == kortekszama)
            {
                Console.WriteLine("Körtéből van a legtöbb");
            }
            else if( maxdb == tojasokszama)
            {
                Console.WriteLine("Tojásból van a legtöbb");
            }
            else
            {
                Console.WriteLine("Nem lehet eldönteni");
            }
            //Norbi megoldása
            var legtobbtermekcsoport = lista.GroupBy(t => t.nev).Select(cs => new {termekcsoport = cs.Key, db = cs.Sum(cst => cst.db)}).OrderByDescending(k => k.db).First();
            Console.WriteLine("A legtöbb termék ebben a csoportban van: "+ legtobbtermekcsoport.termekcsoport +" "+legtobbtermekcsoport.db+" db");
            
            Console.ReadLine();


        }
    }
}