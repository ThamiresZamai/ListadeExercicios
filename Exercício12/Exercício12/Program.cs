using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício12
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[10];
            Soma so = new Soma();

            Console.WriteLine("Informe 10 numeros: ");
            for (int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("A soma dos 10 números são: " + so.Somar(num));
            Console.ReadKey();
        }
    }
}
