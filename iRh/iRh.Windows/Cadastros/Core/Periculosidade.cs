using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.Core
{
    class Periculosidade
    {
        public static double Calcular(double salario)
        {
            var adicionalPericulosidade = salario * 0.3;
            return adicionalPericulosidade;
        }
    }
}
