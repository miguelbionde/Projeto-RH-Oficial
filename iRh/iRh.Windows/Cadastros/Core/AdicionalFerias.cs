using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.Core
{
    class AdicionalFerias
    {
        public static double Calcular(double salario)
        {
            var salarioFerias = (salario / 3) + salario;
            var irrf = Irrf.Calcular(salario);
            var inss = Inss.Calcular(salario);
            var valorFerias = salarioFerias - (irrf + inss);
            return valorFerias;

        }
    }
}
