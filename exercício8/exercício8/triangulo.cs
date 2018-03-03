using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício8
{
    class triangulo
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public String Triangulo() {

            if ((B + C) > A)
            {
                return "Os (B + C) > A  são de um triângulo!";
            }
            if ((A + C) > B)
            {
                return "Os (A + C) > B  são de um triângulo!";
            }
            if ((A + B) > C)
            {
                return "Os (A + B) > C  são de um triângulo!";
            }
            else

            return "Os valores não formam um triângulo";
        }
    }
}
