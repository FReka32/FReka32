using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verem
{
    class Verem
    {
        private int stack_pointer;
        private static List<int> veremlista = new List<int>();
        public int meret = 0;
        public void Push(int szam)
        {
            if (veremlista.Count < meret)
            {
                veremlista.Add(szam);
            }
            stack_pointer++;
        }
        public int Pop()
        {
            if (veremlista.Count > 0)
            {
                int last = veremlista[veremlista.Count - 1];
                veremlista.Remove(veremlista.Count - 1);
                stack_pointer--;
                return last;
            }
            else
            {
                return -1;
            }
        }
        public Verem(int meret)
        {
            this.meret = meret;
        }
        public List<int> Tartalom()
        {
            return veremlista.ToList();
        }
    }
}
