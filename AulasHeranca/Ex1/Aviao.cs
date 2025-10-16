using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Aviao: MeioTransporte
    {
        private int horas;

        public int Horas { get => horas; set => horas = value; }

        public Aviao() { }
        public Aviao(int horas)
        {
            this.horas = horas;
        }
    }
}
