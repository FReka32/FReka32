using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veletlen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int vsz = rnd.Next(1, 7);
            Console.WriteLine(vsz);
            Console.ReadKey();
        }
    }
}
