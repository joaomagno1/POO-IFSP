using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    internal class Programador : Funcionario
    {
        public override double CalcularSalario()
        {
            return base.CalcularSalario() * 1.20;
        }
    }
}
