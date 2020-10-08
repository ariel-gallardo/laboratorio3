using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratorioIII_TPN2
{
    class C2Array
    {
        private char[] intArray { get; set; }
        public C2Array()
        {
            Console.Write("Numeros separados de coma: ");
            string[] strArr = Console.ReadLine().Split(",");
            intArray = new char[strArr.Length];

            for(int x = 0; x < strArr.Length; x++)
            {
                intArray[x] = char.Parse(strArr[x]);
            }
        }

        public override string ToString()
        {
            return new String(intArray);
        }
    }
}
