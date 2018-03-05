using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício13
{
    public class Imprimir
    {
        public double qtd { get; set; }

        public void Imprima()
        {
            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Número: [" + 
                    i + "]=" + (i + 1));
            }
        }
    }
}
