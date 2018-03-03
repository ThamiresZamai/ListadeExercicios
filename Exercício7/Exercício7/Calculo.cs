using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício7
{
    class Calculo
    {
        
        public int[] numeros = new int[3];
        int menor = 10;
        int maior = 0;

        public int Maior()
        {

            for (int i = 0; i < 3; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            }

            return maior;
        }

        public int Menor() {

            for (int i = 0; i < 3; i++)
            {
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            return menor;
        }
    }
}
