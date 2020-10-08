using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratorioIII_TPN2
{
    class Circulo : Figura
    {
        public override void Dibujar()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Dibujar();
        }

        public override string ToString()
        {
            return base.ToString() + "Circulo O";
        }
    }
}
