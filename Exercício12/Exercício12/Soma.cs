using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício12
{
    class Soma
    {
        

        public Double Somar(double[] num) {
            double soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += num[i];
            }

            return soma;
        }

    }
}
