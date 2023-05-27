using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tombkezeles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[10] {1,4,6,22,13,5,88,65,41,7};
            //szamok[2] = 12;
            int? index = null;
            int hossz = szamok.Length;
            for (int i = 0; i < hossz; i++)
            {
                if(szamok[i] == 5)
                {
                    index = i;
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine(index);
            Console.WriteLine();
            index = 0;
            int j = 0;
            foreach (int szam in szamok)
            {
                if(szam == 5)
                {
                    index = j;
                    break;
                }
                Console.WriteLine(j);
                j++;
            }
            Console.WriteLine(index + "\n");

            j=0;
            index = 0;
            while (j<10 && szamok[j] != 5)
            {
                Console.WriteLine(j);
                j++;
            }
            index = j;
            Console.WriteLine(index + "\n");

            j = 0;
            index = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j<10 && szamok[j] != 5);
            index = j;
            Console.WriteLine(index + "\n");

            if (szamok.Contains(5))
            {
                Console.WriteLine("van benne otos");
            }
            Console.WriteLine(szamok.Max());

            Console.Write("Kerem a nevet: ");
            string nev = Console.ReadLine();
            Console.WriteLine("Szia {0}!", nev);
            Console.WriteLine("**********");
            Console.Write("Kerem az elso szamot: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("Kerem a masodik szamot: ");
            int szam2 = int.Parse(Console.ReadLine());
            int osszeg = szam1 + szam2;
            Console.WriteLine("A ket szam osszege: {0}", osszeg);
            Console.WriteLine();
            Console.Write("Kerek egy szamot: ");
            int szam3;
            while (!int.TryParse(Console.ReadLine(), out szam3))
            {
                Console.WriteLine(szam3);
                Console.Write("Kerek egy SZAMOT: ");
            }
            Console.WriteLine("ez egy szam: {0}", szam3);
            Console.WriteLine();

            Console.Write("kérek egy tizedes törtet:");
            double d1 = double.Parse(Console.ReadLine());
            Console.WriteLine(d1);

            Console.ReadKey();
        }
    }
}
