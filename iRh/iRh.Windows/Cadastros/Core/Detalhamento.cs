using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.Core
{
    class Detalhamento
    {
        public static double ResultadoAdicionais(double valorHora, double horaExtra, double adicionalNoturno, double horaTrabalhada)
        {
            var salario = valorHora * horaTrabalhada;
            var resultadoHoraExtra = HoraExtra.Calcular(valorHora, horaExtra);
            var resultadoPericulosidade = Periculosidade.Calcular(salario);
            var resultadoAdicionalNoturno = AdicionalNoturno.Calcular(valorHora, adicionalNoturno);
            return resultadoAdicionalNoturno + resultadoHoraExtra + resultadoPericulosidade;
        }
    }
}
