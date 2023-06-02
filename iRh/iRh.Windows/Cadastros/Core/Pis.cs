using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.Core
{
    class Pis
    {
        public static double Calcular(double salario, double mesesTrabalhado)
        {
            const double salarioMinimo = 1320.00;

            if(salario < salarioMinimo * 2)
            {
                var valorPis = (salarioMinimo / 12) * mesesTrabalhado;
                return valorPis;
            }
            else
            {
                return 0;
            }
        }
    }
}
