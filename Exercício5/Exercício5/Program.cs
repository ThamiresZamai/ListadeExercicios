using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados d = new Dados();

            Console.WriteLine("Insira o nome: ");
            d.Nome = Console.ReadLine();

            Console.WriteLine("Insira a altura: ");
            d.altura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("insira o sexo: M/1 ou F/2");
            d.Sexo = Convert.ToInt32(Console.ReadLine());

            switch (d.Sexo)
            {

                case 1:
                    Console.WriteLine("O peso ideal é: " + ((72.7m * d.altura)-58));
                    break;
                case 2:
                    Console.WriteLine("O peso ideal é: " + ((62.1m * d.altura)-44.7m));
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;

            }
            Console.ReadKey();

        }
    }
}
