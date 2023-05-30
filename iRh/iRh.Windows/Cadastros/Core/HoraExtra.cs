using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.Core
{
    class HoraExtra
    {
        public static double Calcular(double valorHoraExtra, double horaExtra)
        {
            return (valorHoraExtra * horaExtra) * 1.5;
        }
    }
}
