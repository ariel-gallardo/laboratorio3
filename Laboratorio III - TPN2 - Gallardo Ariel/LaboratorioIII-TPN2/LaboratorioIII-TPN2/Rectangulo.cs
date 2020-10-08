using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratorioIII_TPN2
{
    class Rectangulo : Figura
    {
        public override void Dibujar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Dibujar();
        }

        public override string ToString()
        {
            return base.ToString() + "Rectangulo ▬";
        }
    }
}
