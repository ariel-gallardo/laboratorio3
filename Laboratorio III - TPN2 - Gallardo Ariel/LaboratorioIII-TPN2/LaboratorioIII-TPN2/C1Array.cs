using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratorioIII_TPN2
{
    class C1Array
    {
        public int Fila { get; set; }
        public int Columna { get; set; }

        public string SArray { get; set; }
        public C1Array()
        {
            Console.Write("Filas: "); Fila = int.Parse(Console.ReadLine());
            Console.Write("Columnas: "); Columna = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            for (int y = 0; y < Fila; y++)
            {
                for (int x = 0; x < Columna; x++)
                {
                    if (y == Fila - 1 && x == Columna - 1)
                    {
                        SArray += "X";
                    }
                    else
                    {
                        SArray += "0";
                    }
                }
                if (y != Fila - 1)
                {
                    SArray += "\n";
                }
            }
            return SArray;
        }
    }
}
