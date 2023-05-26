using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace haromszogekCLI
{
    public class Program
    {
        //lista elem a beolvasott háromszögek tárolásához.
        static List<Haromszog> hszLista = new List<Haromszog>();
        //lista elem a beolvasott derékszögű háromszögek tárolásához.
        static List<Haromszog> dhszLista = new List<Haromszog>();
        static void Main(string[] args)
        {
            //haromszogek2.csv file beolvasása.
            StreamReader sr = new StreamReader("haromszogek2.csv");
            //ciklus a beolvasott file feldogozására.
            while(!sr.EndOfStream)
            {
                //egy sor kiválasztása feldolgozásra.
                string line = sr.ReadLine();
                //sor feldolgozása: 
                 //1. szöveges sor elemeinek szöveges tömbbe szétdarabolása space karakter szerint elválasztva.
                string[] oldalak = line.Split(' '); 
                 //háromszög leendő oldalainak értékadása.
                int a = Int32.Parse(oldalak[0]);
                int b = Int32.Parse(oldalak[1]);
                int c = Int32.Parse(oldalak[2]);
                 //a c oldal értékcseréje, külön változó nélkül, ha nem az lenne a legnagyobb.
                if (a > b && a > c)
                {
                    a = a + c;
                    c = a - c;
                    a = a - c;
                }
                else if (b > a && b > c)
                {
                    b = b + c;
                    c = b - c;
                    b = b - c;
                }
                 //új háromszög létrehozása
                Haromszog hsz = new Haromszog(a, b, c);
                 //háromszög hozzáadása listához későbbi műveletek elvégézésének céljából.
                hszLista.Add(hsz);
            }
            //Ciklus az elkészült háromszögek listájának megjelenítéséhez, elemek kiírása konzolra. 
            //Derékszögő háromszögek listájának feltöltése érték alapon, függvénnyel ellenőrizve.
            for (int i = 0; i < hszLista.Count; i++)
            {
                if (DerekszoguE(hszLista[i].a, hszLista[i].b, hszLista[i].c))
                {
                    Console.WriteLine($"a: {hszLista[i].a} b:{hszLista[i].b} c:{hszLista[i].c}");
                    dhszLista.Add(hszLista[i]);
                }  
            }
            //Legnagyobb terülteű derékszögű háromszög meghatározása és kiírása konzolra.
            Haromszog legnagyobbDhsz = dhszLista[0];
            for (int i = 0; i < dhszLista.Count; i++)
            {
                if (dhszLista[i].terulet > legnagyobbDhsz.terulet)
                {
                    legnagyobbDhsz = dhszLista[i];
                }
            }
            Console.WriteLine($"A legnagyobb területű derékszögő háromszög adatai:\na: {legnagyobbDhsz.a} b:{legnagyobbDhsz.b} c:{legnagyobbDhsz.c}");
            Console.ReadKey();
        }
        // függvény annak a megvizsgálásához, hogy egy adott háromszög derékszögű-e a Pithagorasz-tétel alapján.  
        public static bool DerekszoguE (int a, int b, int c)
        {
            if(a * a + b * b == c * c)
            {
                return true;
            }
            return false;
        }
    }
}
