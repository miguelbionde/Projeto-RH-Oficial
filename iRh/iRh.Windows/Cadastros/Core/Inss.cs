using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.Core
{
    public static class Inss
    {
        const double faixa01 = 1302.0;
        const double faixa02 = 2571.29;
        const double faixa03 = 3856.94;
        const double faixa04 = 7507.49;

        public static double Calcular(double salario)
        {
            
            double valorInss = 0;

            if(salario <= faixa01)
            {
                valorInss = 0.075 * salario;
                return valorInss;
            }
            
            else if(salario <= faixa02)
            {
                var desconto01 = CalculaFaixa1(salario);
                valorInss = 0.09 * (salario - faixa01) + desconto01;
                return valorInss;
            }
            
            else if(salario <= faixa03)
            {
                var desconto01 = CalculaFaixa1(salario);
                var desconto02 = CalculaFaixa2(salario);
                valorInss = 0.12 * (salario - faixa02) + desconto01 + desconto02;
                return valorInss;
            }
            else if(salario <= faixa04)
            {
                var desconto01 = CalculaFaixa1(salario);
                var desconto02 = CalculaFaixa2(salario);
                var desconto03 = CalculaFaixa3(salario);
                valorInss = 0.14 * (salario - faixa03) + desconto01 + desconto02 + desconto03;
                return valorInss;
            }

            else if(salario > faixa04)
            {
                valorInss = 877.24;
                return valorInss;
            }
            return 0;
        }

        private static double CalculaFaixa1(double salario)
        {
            return (0.075 * faixa01);
        }

        private static double CalculaFaixa2(double salario)
        {
            return 0.09 * (faixa02 - faixa01);
        }

        private static double CalculaFaixa3(double salario)
        {
            return 0.12 * (faixa03 - faixa02);
        }

    }
}
