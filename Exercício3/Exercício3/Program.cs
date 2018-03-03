using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício3
{
    class Program
    {
        static void Main(string[] args)
        {
            Valorfinal vf = new Valorfinal();

            Console.WriteLine("Insira o valor de fábrica do automóvel");
            vf.Fabrica = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Porcentagem do distribuidor 28% e impostos 45%");
            Console.WriteLine("Valor total: " + vf.ValorConsumidor());
            Console.ReadKey();
        }
    }
}
