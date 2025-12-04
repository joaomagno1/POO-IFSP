using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    internal class Funcionario
    {
        string cargo, nome;
        double salarioBase;

        public string Cargo { get => cargo; set => cargo = value; }
        public string Nome { get => nome; set => nome = value; }
        public double SalarioBase { get => salarioBase; set => salarioBase = value; }

        public virtual double CalcularSalario()
        {
            return salarioBase;
        }
    }
}
