using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.Core
{
    class Irrf
    {
        const double Faixa01 = 1903.98;
        const double Faixa02 = 2826.65;
        const double Faixa03 = 3751.06;
        const double Faixa04 = 4664.68;
        public static double Calcular(double salario)
        {
            var salarioIrrf = salario - Inss.Calcular(salario);
            var impostoDeRenda = 0.0;

            if(salarioIrrf <= Faixa01)
            {
                impostoDeRenda = 0;
            }
            if(salarioIrrf <= Faixa02)
            {
                impostoDeRenda = (salarioIrrf - Faixa01) * 0.075;
            }
            if(salarioIrrf <= Faixa03)
            {

            }
        }

        private static double CalculaFaixa1(double salarioIrrf)
        {
            return (Faixa01 - Faixa02) * 0.075; 
        }
    }
}
