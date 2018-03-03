using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício7
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo cal = new Calculo();
            Console.WriteLine("Informe 3 numeros diferentes: ");

            for (int i = 0; i < 3; i++)
            {
                cal.numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            

            Console.WriteLine("O maior número é: " + cal.Maior());
            Console.WriteLine("O menor número é: " + cal.Menor());
            Console.ReadKey();
        }
    }
}
