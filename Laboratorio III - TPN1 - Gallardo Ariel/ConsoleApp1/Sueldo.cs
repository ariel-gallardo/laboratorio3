using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{//Ejercicio 5
    class Sueldo
    {
        private readonly TimeSpan ocho, veinte;
        private TimeSpan ingreso, egreso;
        public Sueldo()
        {
            
            ocho = new TimeSpan(8, 0, 0);
            veinte = new TimeSpan(20, 0, 0);

            try
            {
                Console.WriteLine("\n Entrada");
                ingreso = new TimeSpan(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()),0); 
                Console.WriteLine("\n Salida");
                egreso = new TimeSpan(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), 0);
            } catch (FormatException e)
            {
                Console.WriteLine("Ingrese un formato de hora correctamente.");
                Console.ReadKey();
                Console.Clear();
            }

            if((isDiurno() && egreso - ingreso <= ocho) || (!isDiurno() && egreso - ingreso <= veinte))
            {
                if (isDiurno())
                {
                    Console.WriteLine("Hoy cobro: "+egreso.TotalHours * 10+"$ARS");
                }
                else
                {
                    Console.WriteLine("Hoy cobro: " + (egreso.TotalHours * 10 + egreso.TotalHours * 10 *0.50) + "$ARS");
                }
            }
            else
            {
                Console.WriteLine("No puede trabajar mas de ocho horas");
            }

        }


        public Boolean isDiurno()
        {
            return ingreso >= ocho && egreso <= veinte;
        }

    
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
