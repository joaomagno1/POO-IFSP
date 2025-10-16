using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class MeioTransporte
    {
        private string descricao;
        private int capacidade;

        public MeioTransporte()
        {

        }
        public MeioTransporte(string descricao, int capacidade)
        {
            this.descricao = descricao;
            this.capacidade = capacidade;
        }

        public string Descricao { get => descricao; set => descricao = value; }
        public int Capacidade { get => capacidade; set => capacidade = value; }
    }
}
