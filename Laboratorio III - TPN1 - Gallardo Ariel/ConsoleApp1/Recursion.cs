using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Recursion
    {
        private static long numeroActual;
        private Recursion recursion;
        public Recursion()
        {
            while (true)
            {
                numeroActual = long.Parse(Console.ReadLine());
                if(numeroActual > 1)
                {
                    recursion = new Recursion(numeroActual * numeroActual);
                }
                else
                {
                    Console.WriteLine("Debe ingresar un numero > 1");
                    break;
                }
            }
        }

        public Recursion(long numero)
        {
            try
            {
                Console.WriteLine(numeroActual);
            }catch(FormatException e)
            {
                Console.WriteLine("El valor maximo ha sido alcanzado");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            
        }
    }
}
