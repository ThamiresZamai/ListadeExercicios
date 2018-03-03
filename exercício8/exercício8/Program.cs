using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício8
{
    class Program
    {
        static void Main(string[] args)
        {
            triangulo tri = new triangulo();

            Console.WriteLine("Informe 3 valores para saber se corresponde a um triângulo");
            Console.WriteLine("Valor de A: ");
            tri.A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor de B: ");
            tri.B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor de C: ");
            tri.C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(tri.Triangulo());
            Console.ReadKey();
        }
    }
}
