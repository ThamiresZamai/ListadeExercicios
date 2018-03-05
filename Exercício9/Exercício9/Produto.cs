using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício9
{
    class Produto
    {
        public double[] preço = new double [15];
        public double[] codigo = new double[15];

        public Double Maior() {

            double maior = 0;

            for (int i = 0; i < 15; i++)
            {
                if (preço[i] > maior)
                {
                    maior = preço[i];
                }
                
            }

            return maior;
        }

        public Double Media() {

            double media = 0;
            double soma = 0;

            for (int i = 0; i < 15; i++)
            {
                soma = soma + preço[i];
            }
            media = soma / 15;

            return media;
        }
    }
}
