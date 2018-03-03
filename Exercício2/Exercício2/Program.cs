using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            Votos v = new Votos();
            int total = 0;

            Console.WriteLine("Digite o total de eleitores: ");
            v.Total = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o total de votos Brancos: ");
            v.Brancos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o total de votos nulos: ");
            v.Nulos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o total de votos válidos: ");
            v.Validos = Convert.ToInt32(Console.ReadLine());

            total = v.Brancos + v.Nulos + v.Validos;

            if (total > v.Total)
            {
                Console.WriteLine("Erro ao inserir os valores! Votos superiores ao total de eleitores ");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else {
                Console.WriteLine(v.Porcentvotos());
                Console.ReadKey();
            }
            
        }
    }
}
