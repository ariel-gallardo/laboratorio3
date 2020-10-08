using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Trabajo_Práctico_N_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Empleado> listado = new List<Empleado>()
            {
                new Empleado(4884,"Rodriguez","Victor",20103180326,new Sector(137,"Gerencia Recursos Humanos",130.13,"VERDE"),1837.15,658.02),
                new Empleado(1225,"Sanchez","Juan Ignacio",20271265817,new Sector(44,"Gerencia Operativa",130.13,"ROJO"),750.87,625.46)
            };

            EmpleadosXML empleadosXML = new EmpleadosXML(listado);
            EmpleadosXMLText empleadosXMLText = new EmpleadosXMLText(listado);

            // A
            empleadosXML.crear();
            // B 
            empleadosXMLText.crear();
            // C
            empleadosXML.leer("cXML_Empleados.xml");
            Console.WriteLine(empleadosXML);
            // D
            empleadosXMLText.leer("cXMLTextWriter_Empleados.xml");
            Console.WriteLine(empleadosXMLText);

            Console.WriteLine("Presione una tecla para salir.");
            Console.ReadLine();
        }
    }


}
