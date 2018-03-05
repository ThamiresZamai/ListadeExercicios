using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício14
{
    class Calculo
    {
        public String Media() {

            double soma = 0;
            double media = 0;
            for (int i = 15; i <= 100; i++)
            {
                soma = soma + i;
            }

            media = soma / 85;

            return "A média dos numeros de 15 a 100 é: " +media;
        }
    }
}
