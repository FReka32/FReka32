using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabiritusCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LabSim labirintus = new LabSim("Lab1.txt");
            labirintus.KiirLab();
            Console.Clear();
            Console.CursorVisible= false;   
            labirintus.Utkereses();
            Console.ReadKey();
        }
    }
}
