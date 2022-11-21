using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaPolimorfismo1
{
    internal class Violin:InstrumentoMusical
    {
        public void Afinar()
        {
            MessageBox.Show("Afinando Violin");
        }
    }
}
