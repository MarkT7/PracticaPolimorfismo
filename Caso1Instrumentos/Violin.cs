using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo.Caso1Instrumentos
{
    public class Violin : InstrumentoMusical
    {
        public override string Afinar()
        {
            return "Afinando violín";
        }
    }
}
