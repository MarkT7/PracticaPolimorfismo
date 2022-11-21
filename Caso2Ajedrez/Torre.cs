using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo.Caso2Ajedrez
{
    public class Torre:PiezaAjedrez
    {
        public override string Mover()
        {
            return "La torre se mueve horizontal y verticalmente";
        }

    }
}
