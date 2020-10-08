using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Trabajo_Práctico_N_5
{
    class EmpleadosXML
    {
        public List<Empleado> Empleados { get; set; }

        public EmpleadosXML()
        {
        }

        public EmpleadosXML(List<Empleado> Empleados)
        {
            this.Empleados = Empleados;
        }

        private void agregar(Empleado empleado, XElement xlistado)
        {
            xlistado.Add(new XElement("empleado", new XElement[] {
                new XElement("id",empleado.Id),
                new XElement("nombreCompleto",empleado.Nombre + ", " + empleado.Apellido),
                new XElement("cuil",empleado.Cuil),
                new XElement("sector", new XAttribute[]{
                    new XAttribute("denominacion",empleado.Sector.Denominacion),
                    new XAttribute("id",empleado.Sector.Id),
                    new XAttribute("valorSemaforo",empleado.Sector.valorSemaforo),
                    new XAttribute("colorSemaforo",empleado.Sector.colorSemaforo)
                }),
                new XElement("cupoAsignado",empleado.CupoAsignado),
                new XElement("cupoConsumido",empleado.CupoConsumido)
            }));
        }

        public void crear()
        {
            XElement XEmpleados = new XElement("empleados"),
            XListado = new XElement("listado");

            Empleados.ForEach(delegate (Empleado empleado)
            {
                agregar(empleado, XListado);
            });

            XEmpleados.Add(XListado);
            XEmpleados.Add(new XElement("subsectores", 5));
            XEmpleados.Add(new XElement("totalCupoAsignadoSector", 4217.21));
            XEmpleados.Add(new XElement("totalCupoConsumidoSector", 1405.88));
            XEmpleados.Add(new XElement("valorDial", 33.34));

            XDocument xDocument = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"), XEmpleados);
            xDocument.Save("cXML_Empleados.xml");
        }

        public void leer(String archivo)
        {
            try
            {
                XmlReader xmlReader = XmlReader.Create(System.IO.Directory.GetCurrentDirectory() + "\\" + archivo);
                if(xmlReader != null)
                {
                    if(Empleados == null)
                    {
                        Empleados = new List<Empleado>();
                    }
                    else
                    {
                        Empleados.Clear();
                    }
                    
                }
                while (xmlReader.Read())
                {
                    if (xmlReader.IsStartElement())
                    {
                        switch (xmlReader.Name)
                        {
                            case "empleado":
                                if (xmlReader.Read()) { Empleados.Add(new Empleado()); }
                                break;
                            case "id":
                                if (xmlReader.Read()) { Empleados[Empleados.Count - 1].Id = long.Parse(xmlReader.Value); }
                                break;
                            case "nombreCompleto":
                                if (xmlReader.Read()) {
                                    Empleados[Empleados.Count - 1].Apellido = xmlReader.Value.Split(',')[0].Trim();
                                    Empleados[Empleados.Count - 1].Nombre = xmlReader.Value.Split(',')[1].Trim();
                                }
                                break;
                            case "cuil":
                                if (xmlReader.Read()) { Empleados[Empleados.Count - 1].Cuil = long.Parse(xmlReader.Value); }
                                break;
                            case "sector":
                                //if (xmlReader.Read()) { }
                                Empleados[Empleados.Count - 1].Sector = new Sector(long.Parse(xmlReader["id"]), xmlReader["denominacion"], Double.Parse(xmlReader["valorSemaforo"]), xmlReader["colorSemaforo"]);
                                break;
                            case "cupoAsignado":
                                if (xmlReader.Read()) { Empleados[Empleados.Count - 1].CupoAsignado = Double.Parse(xmlReader.Value.ToString()); }
                                break;
                            case "cupoConsumido":
                                if (xmlReader.Read()) { Empleados[Empleados.Count - 1].CupoConsumido = Double.Parse(xmlReader.Value); }
                                break;
                        }
                    }
                }
                xmlReader.Close();
            }catch(Exception e)
            {
                Console.WriteLine(System.IO.Directory.GetCurrentDirectory() + "\\" + archivo);
                Console.WriteLine(e.Message);
            }
        }

        public override string ToString()
        {
            String empleadosText = "";
            if (Empleados != null)
            {
                empleadosText += "Empleados XML Lectura\n---------------------\n";
                Empleados.ForEach(delegate (Empleado empleado) { empleadosText+=(empleado + "\n"); });
            }
            return empleadosText;
        }
    }
}
