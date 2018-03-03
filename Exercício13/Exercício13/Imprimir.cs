using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício13
{
    class Imprimir
    {
        public int qtd { get; set; }
        public double[] num = new double[qtd];

        public String Imprima() {

            for (int i = 0; i <= qtd; i++)
            {
                return "Numero: ["+i+"]";
            }
            
        }
    }
}
