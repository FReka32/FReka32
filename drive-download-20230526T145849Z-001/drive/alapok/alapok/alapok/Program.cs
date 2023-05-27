using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alapok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //egész számok
            byte bajt1; //0-255 elojel nelkuli
            byte bajt2 = 45;
            sbyte sbajt1 = -128; //-128 - +127 elojeles
            short sort1 = 32739; //-32768 - +32767; 2 bajt elojeles
            short sort2 = short.MinValue;
            ushort usort1 = ushort.MaxValue; //65535  2 bajt elojel nelkuli
            int int1 = int.MinValue; // 4 bajt elojeles -2147483648 - 2147483647
            uint uint1 = uint.MaxValue; // 4 bajt elojel nelkuli
            long long1 = long.MinValue; // 8 bajt elojeles
            ulong ulong1 = ulong.MaxValue; // 8 bajt elojel nelkul
            Console.WriteLine("{0} {1}", sort2, usort1);
            Console.WriteLine($"{int1} {long1} {ulong1}");

            //valós számok
            float float1 = 12.45f; // 4 bajtos elojeles (csak elojeles szamokat tarol minden valos tipus)
            double double1 = 23221656.556456; //8 bajtos elojeles - 64 bites
            decimal decimal1 = 332423423443.1231213m; //16 bajtos elojeles - 128 bites
            Console.WriteLine(float1);
            Console.WriteLine(decimal1);


            byte b1 = 12;
            byte b2 = 45;
            byte b3 = (byte)(b1 + b2);
            Console.WriteLine(b3);

            int i1 = int.MaxValue;
            int i2 = int.MaxValue;
            long i3 = (long)i1 + i2;
            Console.WriteLine(i3);

            //logikai valtozo
            bool? logikai1 = true;
            bool logikai2 = false;
            bool? logikai3 = null;
            if (logikai1 == null)
            {

            }
            //szoveges valtozo
            string szoveg = "alma";
            Console.WriteLine(szoveg[0]);

            //karakteres valtozo
            char karakter = '\'';
            Console.WriteLine(karakter);
            int a = 50;
            Console.WriteLine(a<<2);
            Console.WriteLine(a>>1);

            int b = 51;
            int c = 202;
            Console.WriteLine(b&c);
            Console.WriteLine(c|b);
            Console.WriteLine(b^c);
            if (b < c)
            {
                Console.WriteLine("kisebb");
            }
            else
            {
                Console.WriteLine("nagyobb");
            }
            switch (szoveg)
            {
                case "alma":
                    {
                        Console.WriteLine(szoveg + "fa");
                        break;
                    }
                case "körte":
                    {
                        Console.WriteLine("körte");
                        break;
                    }
                default:
                    break;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            int j = 0;
            while (j<10)
            {
                Console.WriteLine(j);
                j++;
            }
            
            do
            {
                Console.WriteLine(j);
                j--;
            } while (j>0);
            foreach (char betu in szoveg)
            {
                Console.WriteLine(betu);
            }
            int e1 = 10;
            int e2 = 3;
            Console.WriteLine(e1/e2);//div egeszresz
            Console.WriteLine(e1%e2);//mod maradek
            int e3 = 11;
            if (e3%2 == 0 )
            {
                Console.WriteLine("Paros");
            }
            else
            {
                Console.WriteLine("Paratlan");
            }
            Console.WriteLine(Math.Pow(e3,2));
            Console.ReadKey();
        }
    }
}
