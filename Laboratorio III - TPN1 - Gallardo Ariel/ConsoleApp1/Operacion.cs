using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //Ejercicio 4
    class Operacion
    {
        private double a, b;
        public Operacion()
        {
            Console.WriteLine("Ingresar dos numeros decimales");
            Console.Write("A: "); a = double.Parse(Console.ReadLine());
            Console.Write("B: "); b = double.Parse(Console.ReadLine());
            Console.WriteLine(ToString());
        }

        public double suma() { return a + b; }
        public double resta() { return a - b; }
        public double multiplicacion() { return a * b; }
        public double division() { return a / b; }
        public double modulo() { return a % b; }

        public override string ToString()
        {
            try
            {
            opcion:
                Console.Clear();
                Console.Write("\na- Suma\n" +
                "b - Resta\n" +
                "c - Multiplicación\n" +
                "d - División\n" +
                "e - Modulo\nOpcion: ");

                switch (char.Parse(Console.ReadLine()))
                {
                    case 'a':
                        return ("Suma - resultado: " + suma());
                    case 'b':
                        return ("Resta - resultado: " + resta());
                    case 'c':
                        return ("Multiplicacion - resultado: " + multiplicacion());
                    case 'd':
                        return ("Division - resultado: " + division());
                    case 'e':
                        return ("Modulo - resultado: " + modulo());
                    default:
                        goto opcion;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Por favor reintentar");
                Console.ReadKey();
                Console.Clear();
            }
            return "Error";
        }
    }
}
