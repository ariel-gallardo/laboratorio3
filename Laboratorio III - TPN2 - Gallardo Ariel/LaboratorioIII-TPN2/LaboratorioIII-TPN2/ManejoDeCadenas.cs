using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratorioIII_TPN2
{
    class ManejoDeCadenas
    {
        public string CadenaA { get; set; }
        public string CadenaB { get; set; }

        public ManejoDeCadenas()
        {
            Console.Write("Cadena A: "); CadenaA = Console.ReadLine();
            Console.Write("Cadena B: "); CadenaB = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(CadenaA.Contains(CadenaA) ? "Cadena B se encuentra en la Cadena A" : "Cadena B no se encuentra en cadena A");
        }
    }
}
