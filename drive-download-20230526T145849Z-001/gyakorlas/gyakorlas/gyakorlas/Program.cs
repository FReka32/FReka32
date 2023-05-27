using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Írj programot ami beolvassa a felhasználó nevét, majd köszön neki, a nevén szólítva őt!
            Console.WriteLine("1.Írj programot ami beolvassa a felhasználó nevét, majd köszön neki, a nevén szólítva őt!");
            Console.Write("Nevet kérek: ");
            string nev = Console.ReadLine();
            Console.WriteLine("Szia {0}!", nev);
            Console.WriteLine();
            /*2.Állítsa elő a következő alakzatot!
            **********
            oooooooooo
             */
            Console.WriteLine("2.Állítsa elő a következő alakzatot!\r\n**********\r\noooooooooo");
            int i = 0;
            string alakzat = "";
            while (i<21)
            {
                if (i < 10)
                {
                    alakzat += "*";
                }
                else if (i==10)
                {
                    alakzat += "\n";
                }
                else
                {
                    alakzat += "o";
                }
                i++;
            }
            
            Console.WriteLine(alakzat);
            Console.WriteLine();
            /*3.Állítsa elő a következő alakzatot!
            *o*o*o*o*o
            *o*o*o*o*o */
            Console.WriteLine("3.Állítsa elő a következő alakzatot!\r\n*o*o*o*o*o\r\n*o*o*o*o*o");
            i = 0;
            alakzat = "";
            while (i < 11)
            {
                if(i == 5)
                {
                    alakzat += "\n";
                }
                else
                {
                    alakzat += "*o";
                }
                i++;
            }
            Console.WriteLine(alakzat);
            Console.WriteLine();
            //4.Kérjen be két egész számot a felhasználótól, és írja ki a két szám összegét!
            Console.WriteLine("4.Kérjen be két egész számot a felhasználótól, és írja ki a két szám összegét!");
            int szam1;
            int szam2;
            double eredmeny;
            Console.Write("Kérem az első számot: ");
            szam1 = int.Parse(Console.ReadLine());
            Console.Write("Kérem a második számot: ");
            szam2 = int.Parse(Console.ReadLine());
            eredmeny=szam1+szam2;
            Console.WriteLine("A két szám összege: {0}", eredmeny);
            Console.WriteLine();
            //5.Kérjen be három egész számot a felhasználótól, és írja ki a három szám összegét!
            Console.WriteLine("5.Kérjen be három egész számot a felhasználótól, és írja ki a három szám összegét!");
            int szam3;
            Console.Write("Kérem az első számot: ");
            szam1 = int.Parse(Console.ReadLine());
            Console.Write("Kérem a második számot: ");
            szam2 = int.Parse(Console.ReadLine());
            Console.Write("Kérem a harmadik számot: ");
            szam3 = int.Parse(Console.ReadLine());
            eredmeny = szam1 + szam2 + szam3;
            Console.WriteLine("A három szám összege: {0}", eredmeny);
            Console.WriteLine();
            //6.Kérjen be két egész számot a felhasználótól, és írja ki a két szám különbségét!
            Console.WriteLine("6.Kérjen be két egész számot a felhasználótól, és írja ki a két szám különbségét!");
            Console.Write("Kérem az első számot: ");
            szam1 = int.Parse(Console.ReadLine());
            Console.Write("Kérem a második számot: ");
            szam2 = int.Parse(Console.ReadLine());
            eredmeny = szam1 - szam2;
            Console.WriteLine("A két szám különbsége: {0}", eredmeny);
            Console.WriteLine();
            //7.Kérjen be két egész számot a felhasználótól, és írja ki a két szám szorzatát!
            Console.WriteLine("7.Kérjen be két egész számot a felhasználótól, és írja ki a két szám szorzatát!");
            Console.Write("Kérem az első számot: ");
            szam1 = int.Parse(Console.ReadLine());
            Console.Write("Kérem a második számot: ");
            szam2 = int.Parse(Console.ReadLine());
            eredmeny = szam1 * szam2;
            Console.WriteLine("A két szám szorzata: {0}", eredmeny);
            Console.WriteLine();
            //8.Kérjen be két egész számot a felhasználótól, és írja ki a két szám hányadosát, a tizedes tört értékeket is megjelenítve!
            Console.WriteLine("8.Kérjen be két egész számot a felhasználótól, és írja ki a két szám hányadosát, a tizedes tört értékeket is megjelenítve!");
            Console.Write("Kérem az első számot: ");
            szam1 = int.Parse(Console.ReadLine());
            Console.Write("Kérem a második számot: ");
            szam2 = int.Parse(Console.ReadLine());
            eredmeny = (double)szam1 / szam2;
            Console.WriteLine("A két szám hányadosa: {0}", eredmeny);
            Console.WriteLine();
            //9.Írjon programot, mely elszámol 0 - tól 1000 - ig!
            Console.WriteLine("9.Írjon programot, mely elszámol 0 - tól 1000 - ig!");
            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i<=1000);
            Console.WriteLine();
            //10.Írjon programot, mely elszámol 100 - tól 800 - ig!
            Console.WriteLine("10.Írjon programot, mely elszámol 100 - tól 800 - ig!");
            i = 100;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 800);
            Console.WriteLine();
            //11.Írjon programot, mely kiírja a képernyőre az első tíz természetes számot!
            //pozitív egész számok: 1-10
            Console.WriteLine("10.Írjon programot, mely kiírja a képernyőre az első tíz természetes számot!");
            i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
            Console.WriteLine();
            //12.Alakítsa át az előző programot úgy, hogy az csak a páros számokat írja a képernyőre!
            Console.WriteLine("12.Alakítsa át az előző programot úgy, hogy az csak a páros számokat írja a képernyőre!");
            i = 0;
            do
            {
                if (i % 2 == 0 && i != 0)
                {
                    Console.WriteLine(i);
                }
                i+=2;
            } while (i <= 10);
            Console.WriteLine();
            //13.Írjon programot, mely kiírja a képernyőre a hárommal osztható számokat 100 - ig!
            Console.WriteLine("13.Írjon programot, mely kiírja a képernyőre a hárommal osztható számokat 100 - ig");
            i = 0;
            do
            {
                if (i % 3 == 0 && i!=0)
                {
                    Console.WriteLine(i);
                }
                i+=3;
            } while (i <= 100);
            Console.WriteLine();
            //14.Írj programot, ami beolvas egy számot, majd kiírja a kétszeresét!
            Console.WriteLine("14.Írj programot, ami beolvas egy számot, majd kiírja a kétszeresét!");
            Console.Write("Kérem a duplázandó számot: ");
            double duplazando = double.Parse(Console.ReadLine());
            eredmeny = duplazando*2;
            Console.WriteLine("A szám kétszerese: {0}", eredmeny);
            Console.WriteLine();
            //15.Írjon programot ami kiírja a képernyőre az első 5 egész szám összegét!
            Console.WriteLine("15.Írjon programot ami kiírja a képernyőre az első 5 egész szám összegét!");
            i = 1;
            eredmeny = 0;
            do
            {
                eredmeny += i;
                i++ ;
            } while (i < 6);
            double masikEredmeny = ((5+1)*5)/ 2;
            Console.WriteLine("Az első 5 egész szám összege: {0}",eredmeny);
            Console.WriteLine("Az első 5 egész szám összege: {0}", masikEredmeny);
            /*
            Készítsen programot, mely kiírja 1-10-ig a számok négyzetét.
            Készítsen programot, mely kiírja 1-től a számok négyzetét, amig az kisebb mint 1000.
            Írjon programot, mely kiírja a képernyőre a páros számokat 1-től 100-ig.
            Olvass be két számot, írd ki a négyzetüket!
            Írjon programot, mely kiírja a képernyőre a páros számokat 50-től 10-ig.
            Olvasd be egy négyzet oldalát, írd ki a kerületét, területét!
            Olvasd be egy téglalap oldalait, írd ki a kerületét, területét!
            Írjon programot, mely kiírja az első 10 db páros szám összegét a képernyőre!
            Írjon programot, mely kiírja a képernyőre a páratlan számokat 80-tól 20-ig.
            Készítsen programot, mely beolvas 3 db számot a billentyűzetről, majd meghatározza a számok átlagát.
            Írjon programot, mely kiírja a képernyőre a páratlan számokat 1-től 90-ig.
            Írjon programot, mely kiírja a képernyőre a páratlan számokat 60-tól 15-ig.
            Írjon programot, mely kiírja a képernyőre a páros számokat 70-tól 25-ig.
            Írj programot, mely beolvas egy pozitív egész számot, és kiírja az egész számokat egymás alá a képernyőre eddig a számig!
            Írj programot, mely beolvas két egész számot, és kiírja a képernyőre a nagyobbikat!
            Írj programot, mely beolvas három egész számot, és kiírja a képernyőre a legkisebbet!
            Írj programot, ami beolvassa a háromszög oldalainak hosszát, és megmondja, hogy ilyen oldalakkal szerkeszthető-e háromszög!
            Írj programot, mely beolvassa a másodfokú egyenlet együtthatóit, és kiírja, hogy az egyenletnek van-e megoldása!
            Írj programot, mely beolvassa egy derékszögű háromszög két befogóját, és megadja az átfogójának a hosszát! Az átfogót 2 tizedesjeggyel add meg!
            Írjon programot, mely kiírja a képernyőre a 1-10 ig a számok reciprokát!
            1---1
            2---0.5
            3---0.333
            írj programot, mely beolvassa a hatvány alapját és a kitevőt, és kiírja a hatványértéket!
            Írj programot, ami csak pozitív számot hajlandó beolvasni.
            írj programot, mely bekér két számot és eldönti mennyi a távolságuk a számegyenesen!
            írj programot, mely bekér két számot és kiszámolja mennyi az átlaguk!
            írj programot, mely addig kér számokat a billentyűzetről amig összegük kisebb mint 100!
            Írj programot, mely addig olvas be számokat a billentyűzetről, ameddig azok kisebbek, mint tíz. Írja ki ezek után a beolvasott számok összegét!
            Állítson elő 0-tól 100-ig véletlen számot és írja ki a képernyőre!
            Állítson elő 10-tól 50-ig véletlen számot és írja ki a képernyőre!
            Állítson elő 132-tól 147-ig véletlen számot és írja ki a képernyőre!
            Állítson elő 132-tól 148-ig véletlen számot, ami páros, és írja ki a képernyőre!
            írj programot, melyben addig dobunk kockával amig nem sikerül 6-ost dobni. A dobásokat jelenítsd meg!
            Írj programot, mely eldönti egy számról, hogy prímszám-e!
            írj programot, mely bekér két szót és kiírja amelyik rövidebb!
            írj programot, mely bekér két szót és összehasonlítja őket, hogy azonosak-e!
            írj programot, mely bekér két szót és kiírja amelyik hosszabb!
            írj programot, mely bekér két szót és kiírja az azonos karaktereket!
            írj programot, mely bekér két szót és kiírja az azonos karaktereket, de mindegyiket csak egyszer!
            írj programot, mely bekér két 100 nál nagyobb számot és kiírja a legnagyobb közös osztóját!
            írj programot, mely bekér két 100 nál kisebb számot és kiírja a legkisebb közös többszörösét!
            írj programot, mely kiírja a primszámokat 1-től 100-ig!
            Írj programot, ami kiírja a kisbetűket, és melléjük az ASCII kódjukat!
            írj programot, mely bekér egy zárójelekből álló jelsorozatot, és eldönti, hogy a kifejezés helyes-e!
            pl.:()()((())(()---Nem helyes!
            írj programot, mely bekér kétfajta zárójelekből álló jelsorozatot, és eldönti, hogy a kifejezés helyes-e!
            pl.:{)()(}(()){{}(()}}---Nem helyes!
            Kérj be három szót és tedd őket ABC rendbe!
            Kérj be négy szót és tedd őket fordított ABC rendbe!
            Kérj be két szót, vagy szöveget és döntsd el anagramma-e!
            anagramma: Géza kék az ég
            Írj programot, ami beolvassa a kör sugarát és kiírja a kör kerületét, területét!
            K=2*r*pi
            T=r*r*pi
            Írj programot, ami beolvassa egy háromszög három oldalát és az oldalhoz tartozó magasságát és kiírja a kerületét, területét!
            K=a+b+c
            T=a*m/2
            Írj programot, ami beolvas két számot, majd kiírja az összegüket, különbségüket, szorzatukat, hányadosukat, ha lehet!
            Kérjünk be egy természetes számot (a), majd rajzoljunk ki a képernyőre egy háromszöget csillagokból (*). A háromszög a sornyi csillagból álljon!
            Például a=4-re:
            *
            **
            ***
            ****
            Kérjünk be két természetes számot (M,N), majd rajzoljunk ki a képernyőre egy MxN méretű téglalapot csillag (*) jelekből úgy, hogy a téglalap belseje üres legyen.
            Például M=8 és N=4-re:
            ********
            *         *
            *         *
            ********
            Olvass be 5 számot, majd írd ki a páratlanok darabszámát!
            Írj programot, mely beolvas két pozitív egész számot, és kiírja a számtani és mértani közepüket! A gyökvonáshoz használd a Math.Sqrt() függvényt!
            Olvass be egy szót, és írd ki a betűit egy sorba, egymástól szóközzel elválasztva!
            Tabu: olvass be egy szót és a tabu betűt, amit nem szabad kiírni. Írd ki a szót a tabu betű nélkül.
            Olvass be egy szót, és írd ki a minden második betűjét egymás alá!
            Olvass be egy szót, és írd ki a képernyőre egymás alá a karaktereinek ASCII kódját!
            Olvass be egy szót, és írd ki a betűit fordított sorrendben!
            Olvass be egy mondatot, és írd ki a szavait egymás alá. (A szavakat egymástól a szóköz karakter választja el.)
            Olvass be egy szót, és írd ki a betűit fordított sorrendben, csupa nagy betűvel!
            Olvass be egy mondatot, és írd ki a szavait egymás alá úgy, hogy a szavak első betűje nagybetűs legyen!
            Olvassunk be egész számokat egy tömbbe (a darabszámot is kérje be a program), majd kérjünk be egy egész számot, és mondjuk meg, hogy hányszor szerepel a tömbben.
            Írj egy programot, mely szöveg file beolvasása sorá n megállapítja melyik karakter hányszor fordult elő a file-ban!
            Olvassuk be egy tömbbe az osztály tanulóinak keresztneveit (a darabszámot is kérje be a program). Mondjuk meg, hogy egy adott keresztnevű tanulóból hány jár az osztályba (a keresett nevet is kérje be a program).
            Olvassunk be egész számokat egy tömbbe (a darabszámot is kérje be a program), majd adjuk meg a legkisebb és a legnagyobb szám különbségét!
            Olvassunk be egész számokat egy tömbbe (a darabszámot is kérje be a program), majd írjuk ki a számokat nagyság szerint növekvő sorrendben.(buborékos rendezés)
            Írj egy programot, amely egy N elemet tartalmazó tö mbről megmondja, hogy a szomszédos elemek között mekkora legnagyobb különbség!
            Írj egy programot, amely egy N elemet tartalmazó tö mbről megmondja, hogy melyik két eleme között legkisebb a különbség!
            Írj egy eljárást, mely paraméterként megkapja az éj fél óta eltelt másodpercek számát, és kiírja az időpontot óra:perc:másodperc formában!
            Írj egy eljárást, mely egy paraméterként kapott öss zegről eldönti, hogy a különböző érmékből (1, 2, 5, 10, 20, 50, 100, 200) hány darab szükséges ahhoz, hogy összértékük ennyi legyen, de lehető legkevesebb érmét használjunk fel !
            Írj egy eljárást, mely egy paraméterként kapott egé sz számot kettes számrendszerbeli számmá konvertálva ír ki!
            Írj egy programot, mely beolvas egy 16-os számrends zerbeli számot tartalmazó sztringet és kiírtja a számot 10-es számrendszerben!
            Írj egy programot, mely mindaddig beolvas egy egész értéket a billentyűzetről, amíg a felhasználó egy öttel osztható páratlan számot nem ír be!
            Írj egy programot, mely egy file tartalmát fordítot t sorrendben a képernyőre írja!
            Írj egy programot, mely egy N db valós számot tartalmazó tömb elemeiről megmondja, hogy hány olyan eleme van, megy az értékek átlagától maximum 10-zel tér el!
            Írj egy programot, mely egy N db valós számot tarta lmazó tömb elemeiről megmondja, hogy mennyi az összegük!
            Írj egy programot, mely egy valós tömb elemei közül meghatározza mekkora a legnagyobb érték!
            Írj egy programot, mely egy valós tömb elemei közül meghatározza mekkora a második legnagyobb érték!
            Írj egy programot, mely egy N elemű tömbről megmond ja, hogy melyik 3 elem összege a legkisebb!
            Írj egy programot, mely egy N elemű tömbről megmond ja, hány páros szám található benne!
            Írj egy programot, mely egy N elemű tömbről megmond ja, hány páratlan szám található benne!
            Írj egy programot, mely egy N elemű tömbről megmond ja, melyik a legkisebb eleme, és hol található!
            Írj egy programot, mely egy N elemű tömbről megmond ja, melyik a legnagyobb eleme, és hol található!
            Írj egy függvényt, ami megállapítja egy számról, hogy páros-e!
            Írj egy függvényt, ami megállapítja három számról, hogy növekvő sorrendben vannak!
            a<b<c
            Írj egy függvényt, ami megállapítja három számról, hogy csökkenő sorrendben vannak!
            a>b>c
            Írj egy függvényt, ami egy kapott szám négyzetét adja vissza!
            Írj egy függvényt, ami a két bemenő paraméter összegével tér vissza!
            Írj egy függvényt, mely paraméterként megkapja két pont (X,Y) koordinátáit és visszaadja a két pont távolságát!
            Írj egy függvényt, ami megkap egy bájtot és visszaadja a tizes számrendszerbeli értékét!
            (pl:100011001=153)
            Írj egy függvényt, mely paraméterként kap egy sztringet és meghatározza, hogy a sztring formailag lehet-e egy magyar email cím! (forma: valaki@valami.hu ; és csak betű, számjegy, kukac(@), aláhúzás(_) és pont(.) karaktereket tarta lmaz)
            Írj programot ami kiírja a képernyőre, hogy "Hajrá Irinyi!"
            Írj egy programot a hétvégére ami szabadtéri, és pihenj egy kicsit! Sok sikert a nehezebb feladatokhoz!
             */
            Console.ReadKey();
        }
    }
}
