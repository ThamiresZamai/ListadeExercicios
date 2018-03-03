using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício3
{
    class Valorfinal
    {
        public Decimal Fabrica { get; set; }


        public Decimal ValorConsumidor() {

            Decimal valortotal = Fabrica + (Fabrica * 0.28m) + (Fabrica * 0.45m);

            return valortotal;
        }
    }
}
