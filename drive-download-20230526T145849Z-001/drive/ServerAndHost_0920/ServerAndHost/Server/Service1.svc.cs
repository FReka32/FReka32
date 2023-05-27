using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Server
{
    public class Service1 : IService1
    {
        public static List<Galamb> galambokLista = new List<Galamb>();
        Random random = new Random();
        public Galamb EgyGalambGet()
        {
            Galamb egyGalamb = new Galamb();
            egyGalamb.ID = 1;
            egyGalamb.Nev = "Gizi";
            egyGalamb.Gazda = "Backend Elek";
            egyGalamb.Eletkor = 2;
            egyGalamb.Fajta = "Vad";
            egyGalamb.Nem = false; //fiú
            egyGalamb.LabakSzama = 2;
            return egyGalamb;
        }
        public Galamb EgyGalambGetCS()
        {
            return EgyGalambGet();
        }
        public Galamb EgyGalambPost()
        {
            Galamb egyGalamb = new Galamb();
            egyGalamb.ID = random.Next(1, 1001);
            egyGalamb.Nev = "Jani";
            egyGalamb.Gazda = "Tóth Oszkár";
            egyGalamb.Eletkor = 3;
            egyGalamb.Fajta = "Örvös";
            egyGalamb.Nem = true; //lány
            egyGalamb.LabakSzama = 1;
            galambokLista.Add(egyGalamb);
            return egyGalamb;
        }
        public Galamb EgyGalambPostCS()
        {
            return EgyGalambPost();
        }
        public List<Galamb> GalambLista()
        {
            return galambokLista;
        }
    }
}
