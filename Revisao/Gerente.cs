using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    internal class Gerente: Funcionario
    {
        public override double CalcularSalario()
        {
            return base.CalcularSalario() + 1000;
        }
    }
}
