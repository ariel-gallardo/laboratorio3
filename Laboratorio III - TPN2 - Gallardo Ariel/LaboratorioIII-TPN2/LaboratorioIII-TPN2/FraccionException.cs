using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratorioIII_TPN2
{
    class FraccionException : Exception
    {
        public Fraccion F { get; set; }
        public FraccionException(Fraccion f) : base(f.Numerador == 0 && f.Denominador == 0 ? "Numerador y Denominador no puede ser 0" : (f.Numerador == 0 ? "Numerador no puede ser 0" : "Denominador no puede ser 0")) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
