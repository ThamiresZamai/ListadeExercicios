using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício11
{
    class Temperatura
    {
        public int[] Temp = new int[5];


        public int Maior() {
            int maior = 0;

            for (int i = 0; i < 5; i++)
            {
                if (Temp[i] > maior)
                {
                    maior = Temp[i];
                }
            }

            return maior;
        }

        public int Menor()
        {
            int menor = 10000;

            for (int i = 0; i < 5; i++)
            {
                if (Temp[i] < menor)
                {
                    menor = Temp[i];
                }
            }

            return menor;
        }

        public Double Media() {

            int soma = 0;
            for (int i = 0; i < 5; i++)
            {
                soma = soma + Temp[i];
            }

            return soma / 5;
        }
    }
}
