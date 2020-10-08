using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{//Ejercicio 1
    class Bucle
    {
        private int num;
        public Bucle()
        {
            try
            {
                num = 0;
                Console.Write("Opciones:\n1)For\n2)While\n3)DoWhile\nEleccion: ");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        for(num = 1; limite(); num++)
                        {
                            ver();
                        }
                        break;
                    case 2:
                        while (limite())
                        {
                            ver();
                            num++;
                        }
                        break;
                    case 3:
                        do
                        {
                            num++;
                            ver();
                        } while (limite());
                        break;
                }
            }catch(FormatException e)
            {
                Console.WriteLine("Debe ser un numero la opcion.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void ver()
        {
            if (condicion())
            {
                Console.WriteLine(ToString());
            }
        }

        public override string ToString()
        {
            return "Numero " + num + "\n";
        }

        private bool condicion()
        {
            return num % 2 == 0 || num % 5 == 0;
        }

        private bool limite()
        {
            return num > 0 && num <= 100;
        }
    }
}
