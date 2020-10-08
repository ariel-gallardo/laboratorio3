using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratorioIII_TPN2
{
    class Figura
    {
        public virtual void Dibujar()
        {
            Console.WriteLine("Dibuja "+ToString());
        }

        public override string ToString()
        {
            return "Figura: ";
        }
    }
}
