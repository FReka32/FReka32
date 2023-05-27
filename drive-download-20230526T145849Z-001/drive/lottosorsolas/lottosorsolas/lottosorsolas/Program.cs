using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace lottosorsolas
{
    class Program
    {
        public static int lotto = 5;
        public static List<int> userSzamai = new List<int>();
        static void Main(string[] args)
        {
            for (int i = 0; i < lotto; i++)
            {
                Console.WriteLine($"Kérjük adja meg az {i+1}. számot!");
                userSzamai.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Az ön számai:");
            
            foreach (int szam in userSzamai)
            {
                Console.Write(szam + " ");
            }
            Console.WriteLine();
            //Szamhuzas.userSzamai = szamok;
            //Console.WriteLine();
            Thread t = new Thread(Szamhuzas.szamhuzas);
            t.Start();
            // 
            // csinalunk valami hasznosat 
            // amig a masik szal szamol 
            Console.WriteLine("Kérjük adja meg a nevét!");
            string username = Console.ReadLine();
            Console.WriteLine($"Üdv, {username}");
            // varunk a szal kesz allapotra 
            t.Join();
            
            // majd kiirjuk az eredmenyt 
            if (Szamhuzas.szamhuzasKesz)
            {
                Console.WriteLine(Szamhuzas.kimeno);
            }
            else
            {
                Console.Write("A szál kivétel miatt állt le");
                Console.WriteLine(Szamhuzas.kivetel.Message);
            }
            // <enter> leutesere varakozas 
            Console.ReadLine();
        }
    }
}
