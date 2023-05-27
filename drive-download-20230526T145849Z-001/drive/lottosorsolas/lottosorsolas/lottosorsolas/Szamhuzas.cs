using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottosorsolas
{
    class Szamhuzas
    {

        
        public static bool szamhuzasKesz = false;
        public static Exception kivetel = null;
        public static string kimeno = "";
        public static void szamhuzas()
        {
            int minErtek = Program.userSzamai.Min();
            int maxErtek = Program.userSzamai.Max();
            //Console.WriteLine($"A legkisebb szám: {minErtek}");
            //Console.WriteLine($"A legnagyobb szám: {maxErtek}");
            //Console.WriteLine();
            try
            {
                int index = 1;
                foreach (int szam in Program.userSzamai)
                {
                    int? huzottErtek = null;
                    while (huzottErtek != szam)
                    {
                        Random random = new Random();
                        huzottErtek = random.Next(minErtek, maxErtek);
                        //Console.WriteLine($"jelenlegi húzott érték: {huzottErtek}");
                        //Console.WriteLine($"jelenlegi szam: {szam}");
                    }
                    if (huzottErtek == szam)
                    {
                        kimeno += $"Megvan az {index}. szám: {huzottErtek}\n";
                        index++;
                    }
                }
                szamhuzasKesz = true;
            }
            catch(Exception e)
            {
                kivetel = e;
            }
            
            
        }
    }
}
