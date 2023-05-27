using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace raktarprogram
{
    public partial class Form2 : Form
    {
        //static List<Termek> JelenlegiTermekLista;
        public Form2()
        {
            InitializeComponent();
            List<Termek> Termekek = new List<Termek>();
            StreamReader sr = new StreamReader("termekek.txt");
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] darabok = sor.Split(';');
                Termek egyTermek = new Termek(darabok[0], darabok[1]);
                Termekek.Add(egyTermek);
            }
            sr.Close();
            List<Termek> RendezettLista = new List<Termek>(Termekek.OrderBy(k => k.cikkszam));
            //JelenlegiTermekLista = RendezettLista;

            termekTablazat.DataSource = RendezettLista;
            termekTablazat.Refresh();           
        }

        private void termekFelvitel_Click(object sender, EventArgs e)
        {
            string bekertCikkszam = ujCikkszam.Text;
            string bekertTermeknev = ujTermeknev.Text;
            List<Termek> Termekek = new List<Termek>();
            StreamReader sr = new StreamReader("termekek.txt");
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] darabok = sor.Split(';');
                Termek egyTermek = new Termek(darabok[0], darabok[1]);
                Termekek.Add(egyTermek);
            }
            sr.Close();
            
            foreach (var termek in Termekek)
            {
                if(Convert.ToInt32(bekertCikkszam) == termek.cikkszam )
                {
                    felvitelError.Visible = true;
                    break;
                }
                else 
                {
                    felvitelError.Visible = false;
                }
            }
            if(felvitelError.Visible == false)
            {
                Termek ujTermek = new Termek(bekertCikkszam, bekertTermeknev);
                Termekek.Add(ujTermek);
                StreamWriter sw = new StreamWriter("termekek.txt");
                foreach (var termek in Termekek)
                {
                    sw.WriteLine(termek.cikkszam + ";" + termek.termeknev);
                }
                sw.Close();
                List<Termek> ujRendezettLista = new List<Termek>(Termekek.OrderBy(k => k.cikkszam));
                termekTablazat.DataSource = ujRendezettLista;
                termekTablazat.Refresh();
            }
        }

        private void termekTorles_Click(object sender, EventArgs e)
        {
            string bekertCikkszam = torlendoCikkszam.Text;
            List<Termek> Termekek = new List<Termek>();
            StreamReader sr = new StreamReader("termekek.txt");
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] darabok = sor.Split(';');
                Termek egyTermek = new Termek(darabok[0], darabok[1]);
                Termekek.Add(egyTermek);
            }
            sr.Close();

            for (var i = 0;  i < Termekek.Count; i++)
            {
                if (Convert.ToInt32(bekertCikkszam) == Termekek[i].cikkszam)
                {
                    torlesError.Visible = false;
                    Termekek.RemoveAt(i);
                    StreamWriter sw = new StreamWriter("termekek.txt");
                    foreach (var termek in Termekek)
                    {
                        sw.WriteLine(termek.cikkszam + ";" + termek.termeknev);
                    }
                    sw.Close();

                    termekTablazat.DataSource = Termekek;
                    termekTablazat.Refresh();
                    break;
                }
                else
                {
                    torlesError.Visible = true;
                }
            }
            
            
        }

    }
}
