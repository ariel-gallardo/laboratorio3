using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratorioIII_TPN2
{
    class Triangulo : Figura
    {
        public override void Dibujar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Dibujar();
        }

        public override string ToString()
        {
            return base.ToString()+ "Triangulo ▲";
        }
    }
}
