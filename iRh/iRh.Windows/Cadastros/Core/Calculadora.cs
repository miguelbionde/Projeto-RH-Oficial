using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.Core
{
    public static class Inss
    {
        const double Faixa01 = 1302.0;
        const double Faixa02 = 2571.29;
        const double Faixa03 = 3856.94;
        const double Faixa04 = 705.49;

        public static double Calcular(double salario)
        {
            
            double valorInss = 0;

            if(salario <= Faixa01)
            {
                valorInss = 0.075 * salario;
                return valorInss;
            }
            
            else if(salario <= Faixa02)
            {
                var desconto01 = CalculaFaixa1(salario);
                valorInss = 0.09 * (salario - Faixa01) + desconto01;
                return valorInss;
            }
            
            else if(salario <= Faixa03)
            {
                var desconto01 = CalculaFaixa1(salario);
                var desconto02 = CalculaFaixa2(salario);
                valorInss = 0.12 * (salario - Faixa02) + desconto01 + desconto02;
                return valorInss;
            }
            else if(salario <= Faixa04)
            {
                var desconto01 = CalculaFaixa1(salario);
                var desconto02 = CalculaFaixa2(salario);
                var desconto03 = CalculaFaixa3(salario);
                valorInss = 0.14 * (salario - Faixa03) + desconto01 + desconto02 + desconto03;
                return valorInss;
            }

            else if(salario > Faixa04)
            {
                valorInss = 877.24;
                return valorInss;
            }
            return 0;
        }

        private static double CalculaFaixa1(double salario)
        {
            return (0.075 * Faixa01);
        }

        private static double CalculaFaixa2(double salario)
        {
            return 0.09 * (Faixa01 - Faixa02);
        }

        private static double CalculaFaixa3(double salario)
        {
            return 0.12 * (Faixa03 - Faixa02);
        }

    }
}
