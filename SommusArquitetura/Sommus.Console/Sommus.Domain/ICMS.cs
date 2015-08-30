using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommus.Domain
{
    public static class ICMS
    {
        public static double CalculaICMS(double valorTotal)
        {
            return valorTotal * 0.08;
        }
    }
}
