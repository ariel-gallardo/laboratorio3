using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{//Ejercicio 2
    class Aleatorio
    {
        private int num, intento;
        public Aleatorio()
        {
            num = new Random().Next(0, 100);
            intento = 1;
            try
            {
                int adivinar = int.Parse(Console.ReadLine());
                while (true)
                {
                    if (adivinar == num)
                    {
                        Console.WriteLine("Le ha asertado al numero en el "+intento+" intento.");
                        break;
                    }
                    else if (adivinar > num)
                    {
                        Console.WriteLine("El numero es mas pequeño.");
                    }
                    else
                    {
                        Console.WriteLine("El numero es mas grande.");
                    }
                    intento++;
                }
                Console.ReadKey();
                Console.Clear();
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingresar un numero por favor.");
            }
        }
    }
}
