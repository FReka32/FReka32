using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IrasOlvasas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Record> lista = new List<Record>();
            StreamReader sr = new StreamReader("Students.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string beSor = sr.ReadLine();
                string [] mezok = beSor.Split(';');
                Record egyRecord = new Record();
                Record masikRecord = new Record(mezok[0], long.Parse(mezok[1]), mezok[2], mezok[3]);
                /*egyRecord.nev = mezok[0];
                egyRecord.oktAzon = long.Parse(mezok[1]);
                egyRecord.osztaly = mezok[2];
                egyRecord.megJ = mezok[3];*/
                //Console.WriteLine("sdfsdfsdf");
                lista.Add(masikRecord);
            }
            sr.Close();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
