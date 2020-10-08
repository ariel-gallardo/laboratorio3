using System;

namespace LaboratorioIII_TPN2
{
    class Fraccion 
    {
        public int Numerador { get; set; }
        public int Denominador { get; set; }

        public override string ToString()
        {
            return Numerador+"/"+Denominador;
        }

        public Fraccion() {
            Numerador = 1;
            Denominador = 1;
        }

        public Fraccion(int numerador, int denominador) {
            Numerador = numerador;
            Denominador = denominador;
            if(Numerador == 0 || Denominador == 0)
            {
                throw new FraccionException(this);
            }
        }


    }
}
