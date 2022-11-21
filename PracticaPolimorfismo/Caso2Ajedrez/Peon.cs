using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo.Caso2Ajedrez
{
    public class Peon:PiezaAjedrez
    {
        public override string Mover()
        {
            return "El peon avanza de a 1 casillero";
        }
    }
}
