using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício4
{
    class Program
    {
        static void Main(string[] args)
        {
            Salário sal = new Salário();
            Console.WriteLine("Insira o salário fixo: ");
            sal.Salario = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insira o número de carros vendidos: ");
            sal.CarroVendido = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insira o valor total das vendas: ");
            sal.Vendas = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insira o valor por carro vendido: ");
            sal.Comicarro = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Salário do funcionário: " + sal.SalarioFuncionario());
            Console.ReadKey();
        }
    }
}
