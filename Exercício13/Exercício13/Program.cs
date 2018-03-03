using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício13
{
    class Program
    {
        static void Main(string[] args)
        {
            Imprimir im = new Imprimir();
            Console.WriteLine("Insira a quantidade de números a serem inseridos: ");
            im.qtd = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira as numeros: ");
            for (int i = 0; i < im.num; i++)
            {
                im.num[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine(im.Imprima());
        }
    }
}
