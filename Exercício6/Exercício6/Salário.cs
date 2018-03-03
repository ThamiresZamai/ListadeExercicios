using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício6
{
    class Salário
    {
        public double Salario { get; set; }
        public double Valorvendas { get; set; }

        public Double CalculoVendas() {
            double total1 = 0;
            double total2 = 0;
            double total3 = 0;
            double totalFinal = 0;

            if (Valorvendas <= 1500)
            {
                total1 = (Valorvendas + (Valorvendas * 0.3));

            }
            else if (Valorvendas > 1500) {
                total2 = (Valorvendas - 1500);
                total3 = (total2 + (total2 * 0.5));
            }
            totalFinal = total1 + total3;
            return totalFinal;
        }
    }
}
