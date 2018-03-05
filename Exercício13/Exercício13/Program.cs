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
            Console.WriteLine("Insira um número: ");
            im.qtd = Convert.ToInt32(Console.ReadLine());

            im.Imprima();
            Console.ReadKey();
        }
    }
}
