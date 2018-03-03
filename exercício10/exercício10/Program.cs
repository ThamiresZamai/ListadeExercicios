using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício10
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesquisa pes = new Pesquisa();
            Console.WriteLine("Informe o salário: ");
            for (int i = 0; i < 4; i++)
            {
                pes.Salario[3] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Informe a quantidade de filhos: ");
            for (int i = 0; i < 4; i++)
            {
                pes.Filhos[3] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Média de salário da população: " + pes.MediaSal());
            Console.WriteLine("Média do número de filhos: " + pes.MediaFi());
            Console.WriteLine("Maior salário dos habitantes: " + pes.Maior());
            Console.WriteLine("Percentual de pessoas com salário menor que R$ 150,00: " + pes.Porcentagem());
            Console.ReadKey();
        }
    }
}
