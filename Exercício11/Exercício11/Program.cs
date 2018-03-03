using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício11
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperatura tem = new Temperatura();
            Console.WriteLine("Informe 5 temperaturas: ");
            for (int i = 0; i < 5; i++)
            {
                tem.Temp[4] = Convert.ToInt32(Console.ReadLine());
                
            }

            Console.WriteLine("Menor temperatura: " + tem.Menor());
            Console.WriteLine("Maior temperatura: "+ tem.Maior());
            Console.WriteLine("Média das temperaturas: "+ tem.Media());
            Console.ReadKey();
        }
    }
}
