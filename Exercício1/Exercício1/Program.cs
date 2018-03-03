using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
            Idade id = new Idade();

            Console.WriteLine("Digite Sua Idade em:");
            Console.WriteLine("Dias: ");
            id.Dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Meses: ");
            id.Mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Anos: ");
            id.Ano = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A sua idade em dias é: " + id.Calculo());
            Console.ReadKey();
        }
    }
}
