using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Carro: MeioTransporte
    {
        private double quilometragem;

        public double Quilometragem { get => quilometragem; set => quilometragem = value; }

        public Carro()
        {

        }

        public Carro(string descricao, int capacidade, double quilometragem) : base(descricao, capacidade)
        {
            this.quilometragem = quilometragem;
        }
    }
}
