using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício6
{
    class Program
    {
        static void Main(string[] args)
        {
            Salário sal = new Salário();

            Console.WriteLine("Insira o salário: ");
            sal.Salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o valor das vendas: ");
            sal.Valorvendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Salário final: "+sal.CalculoVendas());
            Console.ReadKey();
        }
    }
}
