using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.Core
{
    class Irrf
    {
        const double faixa01 = 1903.98;
        const double faixa02 = 2826.65;
        const double faixa03 = 3751.06;
        const double faixa04 = 4664.68;
        public static double Calcular(double salario)
        {
            var salarioIrrf = salario - Inss.Calcular(salario);
            var impostoDeRenda = 0.0;

            if(salarioIrrf <= faixa01)
            {
                impostoDeRenda = 0;
                return impostoDeRenda;
            }
            if(salarioIrrf <= faixa02)
            {
                impostoDeRenda = (salarioIrrf - faixa01) * 0.075;
                return impostoDeRenda;
            }
            if(salarioIrrf <= faixa03)
            {
                impostoDeRenda = (salarioIrrf - faixa02) * 0.15 + CalculaFaixa1(salarioIrrf);
                return impostoDeRenda;
            }
            if(salarioIrrf <= faixa04)
            {
                impostoDeRenda = (salarioIrrf - faixa03) * 0.225 + CalculaFaixa1(salarioIrrf) + CalculaFaixa2(salarioIrrf);
                return impostoDeRenda;
            }
            else
            {
                impostoDeRenda = (salarioIrrf - faixa04) * 0.275 + CalculaFaixa1(salarioIrrf) + CalculaFaixa2(salarioIrrf) + CalculaFaixa3(salarioIrrf);
                return impostoDeRenda;
            }
        }

        private static double CalculaFaixa1(double salarioIrrf)
        {
            return (faixa02 - faixa01) * 0.075; 
        }

        private static double CalculaFaixa2(double salarioIrrf)
        {
            return (faixa03 - faixa02) * 0.15;
        }

        private static double CalculaFaixa3(double salarioIrrf)
        {
            return (faixa04 - faixa03) * 0.225;
        }
    }
}
