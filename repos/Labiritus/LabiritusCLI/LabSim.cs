using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabiritusCLI
{
    internal class LabSim
    {
        private List<string> Adatsorok;
        private char[,] Lab;

        public bool KeresesKesz { get; set; }
        public int KijaratOszlopIndex { get; private set; }
        public int KijaratSorIndex { get; private set; }
        public bool NincsMegoldas { get; set; }
        public int OszlopokSzama { get; private set; }
        public int SorokSzama { get; private set; }

        private void BeolvasAdatsorok(string forras) 
        {
            StreamReader reader = new StreamReader(forras);
            while (!reader.EndOfStream)
            {
                this.Adatsorok.Add(reader.ReadLine());
            }
            reader.Close();
        }
        private void FeltoltLab() 
        {
            for (int i = 0; i < this.SorokSzama; i++)
            {
                for (int j = 0; j < this.OszlopokSzama; j++)
                {
                    this.Lab[i, j] = this.Adatsorok[i][j];
                }

            }
        }
        public void KiirLab() 
        {
            for (int i = 0; i < this.SorokSzama; i++)
            {
                for (int j = 0; j < this.OszlopokSzama; j++)
                {
                    Console.Write(this.Lab[i, j]);
                }
                Console.WriteLine();

            }
        }
        public void Utkereses() 
        {
            this.KeresesKesz = false;
            this.NincsMegoldas = false;
            int r = 1;
            int c = 0;
            while (!this.KeresesKesz && !this.NincsMegoldas)
            {
                Lab[r, c] = 'O';
                if (Lab[r,c+1]== ' ')
                {
                    c++;
                }
                else if (Lab[r+1,c]== ' ')
                {
                    r++;
                }
                else
                {
                    Lab[r, c] = '-';
                    if (Lab[r,c-1] == 'O')
                    {
                        c--;
                    }
                    else
                    {
                        r--;
                    }

                }
                this.KeresesKesz = (r == this.KijaratSorIndex && c == this.KijaratOszlopIndex);
                if(this.KeresesKesz)
                {
                    Lab[r, c] = 'O';
                }
                this.NincsMegoldas = (r == 1 && c == 0);
                KiirLab();
                System.Threading.Thread.Sleep(500);
                if(!KeresesKesz && !NincsMegoldas)
                {
                    Console.SetCursorPosition(0,0);
                    //Console.Clear();
                }
            }
        }
        public LabSim(string forras) 
        {
            this.Adatsorok = new List<string>();
            BeolvasAdatsorok(forras);
            this.SorokSzama = this.Adatsorok.Count;
            this.OszlopokSzama = this.Adatsorok[0].Length;
            this.KijaratSorIndex = this.SorokSzama - 2;
            this.KijaratOszlopIndex = this.OszlopokSzama - 1;
            this.Lab = new char[this.SorokSzama,this.OszlopokSzama];
            FeltoltLab();
        }
    }
}
