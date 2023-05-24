using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.Core
{
    public static class Fgts
    {
        public static double Calcular(double salario)
        {
            var valorFgts = 0.0;
            valorFgts = salario * 0.08;
            return valorFgts;

        }

    }
}
