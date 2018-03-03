using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício9
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto pro = new Produto();

            Console.WriteLine("Informe o código do produto: ");
            for (int i = 0; i < 15; i++)
            {
                pro.codigo[14] = Convert.ToDouble(Console.ReadLine());
            }
           

            Console.WriteLine("Informe o preço do produto: ");
            for (int i = 0; i < 15; i++)
            {
                pro.preço[14] = Convert.ToDouble(Console.ReadLine());
            }
            

            Console.WriteLine("O valor do maior preço é: " + pro.Maior());
            Console.WriteLine("A média aritmética dos preços são: " + pro.Media());
            Console.ReadKey();
        }
    }
}
