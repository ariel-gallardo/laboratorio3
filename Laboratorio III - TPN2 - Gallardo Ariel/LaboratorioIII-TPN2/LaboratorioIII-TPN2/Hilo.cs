using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LaboratorioIII_TPN2
{
    public class Hilo
    {

        public Hilo()
        {

        }
        public void ejecutarHiloCincoSeg()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("HILO EJECUTADO 5");
                Thread.Sleep(5000);
            }
            
            
        }

        public void ejecutarHiloDiezSeg()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("HILO EJECUTADO 10");
                Thread.Sleep(10000);
            }  
        }
    }
}
