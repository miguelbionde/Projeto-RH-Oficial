using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.Core
{
    class Detalhamento
    {
        public static double ResultadoAdicionais(double valorHora, double horaExtra, double adicionalNoturno, double horaTrabalhada, double resultadoPericulosidade)
        {
            var salario = valorHora * horaTrabalhada;
            var resultadoHoraExtra = HoraExtra.Calcular(valorHora, horaExtra);
            var resultadoAdicionalNoturno = AdicionalNoturno.Calcular(valorHora, adicionalNoturno);
            return resultadoAdicionalNoturno + resultadoHoraExtra + resultadoPericulosidade;
        }

        public static double ResultadoDescontos(double salarioBruto, double resultadoValeTransporte)
        {
            
            var inss = Inss.Calcular(salarioBruto);
            var irrf = Irrf.Calcular(salarioBruto);
            return inss + irrf + resultadoValeTransporte;
        }

        public static double ResultadoSalarioLiquido(double salarioBruto, double totalAdicionais, double totalDescontos)
        {
            return salarioBruto + totalAdicionais - totalDescontos;
        }
    }
}
