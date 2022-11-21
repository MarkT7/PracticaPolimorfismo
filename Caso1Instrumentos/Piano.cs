using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo.Caso1Instrumentos
{
    public class Piano : InstrumentoMusical
    {
        public override string Afinar()
        {
            return "Afinando piano!";
        }
    }
}
