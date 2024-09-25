using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beolvasas
{
    internal class Emerek
    {
        string kerNev, vezNev;
        int IDelso, Eletkor;

        public Emerek(string kerNev, string vezNev, int iDelso, int eletkor)
        {
            this.kerNev = kerNev;
            this.vezNev = vezNev;
            IDelso = iDelso;
            Eletkor = eletkor;
        }

        public string KerNev { get => kerNev; set => kerNev = value; }
        public string VezNev { get => vezNev; set => vezNev = value; }
        public int IDelso1 { get => IDelso; set => IDelso = value; }
        public int Eletkor1 { get => Eletkor; set => Eletkor = value; }
        
    }
}
