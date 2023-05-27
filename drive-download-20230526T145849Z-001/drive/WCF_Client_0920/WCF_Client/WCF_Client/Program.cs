using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF_Client.ServiceReference1;

namespace WCF_Client
{
    internal class Program
    {
        public static ServiceReference1.Service1Client client;
        static void Main(string[] args)
        {
            client=new ServiceReference1.Service1Client();
            Galamb egyGalamb = client.EgyGalambGetCS();
            Console.WriteLine(egyGalamb.Nev);
            client.EgyGalambPostCS();
            Console.ReadKey();

        }
    }
}
