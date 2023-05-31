using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.Core
{
    class AdicionalNoturno
    {
        public static double Calcular(double valorHoraNoturna, double horaNoturna)
        {
            return (valorHoraNoturna * horaNoturna) * 2;
        }
    }
}
