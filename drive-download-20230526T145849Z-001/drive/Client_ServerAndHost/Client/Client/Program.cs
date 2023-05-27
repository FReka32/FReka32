using Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Client
{
    internal class Program
    {
        public static ServiceReference1.Service1Client client;

        public static List<Galamb> GalambLista()
        {
            List<Galamb> lista = new List<Galamb>();
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            client.Encoding = Encoding.UTF8;
            string result = client.DownloadString("http://localhost:3000/GalambLista");
            lista = JsonConvert.DeserializeObject<List<Galamb>>(result);
            return lista;
        }

        static void Main(string[] args)
        {
            client = new ServiceReference1.Service1Client();
            Galamb egyGalamb = new Galamb();
            egyGalamb = client.EgyGalambGetCS();
            Console.WriteLine($"ID:{egyGalamb.ID}\nNév: {egyGalamb.Nev}\nGazda: {egyGalamb.Gazda}\nFajta: {egyGalamb.Fajta}\nLábak száma: {egyGalamb.LabakSzama}\nNeme: {egyGalamb.Nem}\nÉletkor: {egyGalamb.Eletkor}\n");
            Galamb masikGalamb = new Galamb();
            masikGalamb.ID = 4;
            masikGalamb.Nev = "Jenő";
            masikGalamb.Gazda = "Tóth Oszkár";
            masikGalamb.Fajta = "Házi";
            masikGalamb.LabakSzama = 1;
            masikGalamb.Nem = false;
            masikGalamb.Eletkor = 5;
            for (int i = 3; i < 31; i++)
            {
                masikGalamb.ID = i;
                client.GalambPostCS(masikGalamb);
            }
            //SOAP
            List<Galamb> galambList = new List<Galamb>(client.GalambListaCS());

            masikGalamb.ID = 30;
            masikGalamb.Nev = "Gatyás";
            Console.WriteLine(client.GalambPutCS(masikGalamb));
            Console.WriteLine(client.GalambDeleteCS(3));
            Galamb harmincas = new Galamb();
            int keresettId = 30;
            harmincas = client.GalambGetIDCS(keresettId);
            if(harmincas != null)
            {
                Console.WriteLine($"ID:{harmincas.ID}\nNév: {harmincas.Nev}\nGazda: {harmincas.Gazda}\nFajta: {harmincas.Fajta}\nLábak száma: {harmincas.LabakSzama}\nNeme: {harmincas.Nem}\nÉletkor: {harmincas.Eletkor}\n");
            }
            else
            {
                Console.WriteLine($"Nincs a listában {keresettId} ID-vel rendelkező  galamb");
            }
            //HTTP protokoll
            List<Galamb> GalambListHTTP = new List<Galamb>(GalambLista());
            Console.ReadKey();
        }
    }
}
