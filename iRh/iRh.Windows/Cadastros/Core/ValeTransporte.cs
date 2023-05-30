using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.Core
{
    public static class ValeTransporte
    {
        public static double Calcular(double salario)
        {
            var descontoValeTransporte = 0.0;
            descontoValeTransporte = salario * 0.06;
            return descontoValeTransporte;
        }

        public static double ValeaPena(double salario, double valorPassagem, double diasUsados, double passagemPorDia)
        {
            var valeaPena = valorPassagem * diasUsados * passagemPorDia;
            if (valeaPena > Calcular(salario))
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
       
        
    }
}
