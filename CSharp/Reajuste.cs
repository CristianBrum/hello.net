using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal interface IReajuste
    {
        double Reajuste();
    }
    class ReajusteFuncionario : IReajuste
    {
        public string? nomeFuncionario;
        public double salarioFuncionario;

        public double Reajuste()
        {
            salarioFuncionario *= 1.50;

            return salarioFuncionario;
        }
    }
}
