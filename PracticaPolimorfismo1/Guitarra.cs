using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaPolimorfismo1
{
    public class Guitarra:InstrumentoMusical
    {
        public void Afinar()
        {
            MessageBox.Show("Afinando Guitarra");
        }
    }
}
