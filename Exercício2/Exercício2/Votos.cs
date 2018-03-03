using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2
{
    class Votos
    {
        public int Total { get; set; }
        public int Brancos { get; set; }
        public int Nulos { get; set; }
        public int Validos { get; set; }

        public String Porcentvotos() {

            Decimal porBranco =(Brancos*100)/Total;
            Decimal porNulos =(Nulos*100)/Total;
            Decimal porValidos = (Validos*100)/Total;

            return "Porcentagem de votos brancos: " + porBranco + "%, votos nulos: " + porNulos + "% e votos válidos: "+porValidos+"%";
        }
    }
}
