using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício10
{
    class Pesquisa
    {
        public double[] Salario = new double[4];
        public int[] Filhos = new int[4];

        public Double MediaSal() {
            double media = 0;
            double soma = 0;

            for (int i = 0; i < 4; i++)
            {
                soma = soma + Salario[i];
            }

            media = soma / 4;
            return media;
        }

        public int MediaFi() {
            int mediaf = 0;
            int soma = 0;

            for (int i = 0; i < 4; i++)
            {
                soma = soma + Filhos[i];
            }

            mediaf = soma / 4;
            return mediaf;
        }

        public Double Maior() {
            double maior = 0;

            for (int i = 0; i < 4; i++)
            {
                if (Salario[i] > maior)
                {
                    maior = Salario[i];
                }
            }


            return maior;
        }

        public Double Porcentagem() {
            double por = 0;
            int soma = 0;

            for (int i = 0; i < 4; i++)
            {
                if (Salario[i] < 150) {

                    soma++;
                }

            }
            por = (soma * 100) / 4;
            
            return por;
        }
    }
}
