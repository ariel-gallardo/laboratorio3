using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{//Ejercicio 3
    class Paridad
    {
        private int num;
        public Paridad()
        {
            num = 0;
            while (true)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    Console.WriteLine( esPar(num) ? "Es Par" : "Es Impar");
                    if(num == 0)
                    {
                        break;
                    }
                }catch(FormatException e)
                {
                    Console.WriteLine("Debe ingresar un numero");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        public bool esPar(int num)
        {
            return num % 2 == 0;
        }
    }
}
