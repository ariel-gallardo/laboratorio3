using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LaboratorioIII_TPN2
{
    class TPN2
    {
        public static List<Figura> figuras { get; set; }
        static void Main(string[] args)
        {
            while (true)
            {
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.Write("Menu:\n1 - Fracciones\n2 - Manejo de Cadenas\n3 - C1-Array\n4 - C2-Array\n5 - Figuras\n 6- Hilos\nOpcion: ");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        try
                        {
                            Fraccion f = new Fraccion(2, 0);
                        }
                        catch (FraccionException fE)
                        {
                            Console.WriteLine(fE.Message);
                        }
                        Console.ReadLine();
                        break;
                    case 2:
                        ManejoDeCadenas manejoDeCadenas = new ManejoDeCadenas();
                        Console.ReadLine();
                        break;
                    case 3:
                        C1Array c1Array = new C1Array();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(c1Array);
                        Console.ReadLine();
                        break;
                    case 4:
                        C2Array c2Array = new C2Array();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(c2Array);
                        Console.ReadLine();
                        break;
                    case 5:
                        figuras = new List<Figura>();
                        figuras.Add(new Circulo());
                        figuras.Add(new Triangulo());
                        figuras.Add(new Rectangulo());
                        figuras.ForEach(delegate (Figura forma) {
                            forma.Dibujar();
                        });
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Presiona cualquier tecla...");
                        Console.ReadLine();
                        break;
                    case 6:
                        List<Thread> Hilos = new List<Thread>()
                        {
                            new Thread(new Hilo().ejecutarHiloCincoSeg),
                            new Thread(new Hilo().ejecutarHiloDiezSeg)
                        };
                        Hilos[0].Start();
                        Hilos[1].Start();
                        Console.WriteLine("Presiona cualquier tecla...");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Gracias por la visita");
                        Environment.Exit(0);
                        break;
                }
            }
           
        }
    }
}
