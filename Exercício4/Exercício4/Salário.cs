using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício4
{
    class Salário
    {
        public Decimal Salario { get; set; }
        public Decimal Comicarro { get; set; }
        public Decimal Vendas { get; set; }
        public Decimal CarroVendido { get; set; }


        public Decimal SalarioFuncionario()
        {
            decimal total = 0;

            total = Salario + (CarroVendido * Comicarro) + (Vendas * 0.05);

            return total;
        }


    }


}
