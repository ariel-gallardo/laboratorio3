using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Bucle bucle = new Bucle();
            Aleatorio aleatorio = new Aleatorio();
            Paridad paridad = new Paridad();
            Operacion operacion = new Operacion();
            Recursion recursion = new Recursion();

            /*
                Explique y ejemplifique los métodos para el manejo de cadenas en C#, Lenght,
                Contains, IndexOf, Remove, Replace, Substring, Append, ToUpper, ToLower
            */
            string palabra1 = "Hello";
            string palabra2 = "World";

            Console.WriteLine("Length calcula el total de caracteres de un string ej. palabra1 'Hello': " + palabra1.Length + " caracteres");
            Console.WriteLine("Contains determina si se encuentra un caracter en un string ej. palabra1 'Hello' contiene 'l' " + palabra1.Contains('l'));
            Console.WriteLine("IndexOf demuestra la posicion de un caracter en un string, ej. palabra1 donde se encuentra la primera 'l' "+palabra1.IndexOf('l'));

            palabra1.Remove(2);
            Console.WriteLine("Remove, permite eliminar el contenido desde una posicion hasta el final: ej. Hello -> 'lo' eliminado." + palabra1);

            palabra1.Replace('l', 'z');
            Console.WriteLine("Replace tiene la utilidad de remplazar todos los caracteres seleccionados por unos nuevos, cambiamos las 'l' por 'z': " + palabra1);

            Console.WriteLine("AppEnd no se encuentra en la version actual de MS VS CODE 2016, pero tiene la utilidad de agregar elementos o palabras al final.");

            palabra1 = palabra1.ToUpper();
            Console.WriteLine("ToUpper tiene la utilidad de convertir a mayusculas un string");

            palabra1 = palabra1.ToLower();
            Console.WriteLine("ToUpper tiene la utilidad de convertir a minusculas un string");

        }
    }
}
