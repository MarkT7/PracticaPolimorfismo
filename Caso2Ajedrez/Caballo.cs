using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo.Caso2Ajedrez
{
    public class Caballo:PiezaAjedrez
    {
        public override string Mover()
        {
            return "El caballo se mueve en L";
        }
    }
}
