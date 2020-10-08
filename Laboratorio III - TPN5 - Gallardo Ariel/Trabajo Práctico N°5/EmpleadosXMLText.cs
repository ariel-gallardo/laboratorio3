using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Trabajo_Práctico_N_5
{
    class EmpleadosXMLText
    {
        public List<Empleado> Empleados { get; set; }

        public EmpleadosXMLText()
        {
            
        }
        public EmpleadosXMLText(List<Empleado> Empleados)
        {
            this.Empleados = Empleados;
        }

        private void agregar(Empleado empleado, XmlTextWriter xmlTextWriter)
        {
            xmlTextWriter.WriteStartElement("empleado");
            xmlTextWriter.WriteElementString("id", empleado.Id.ToString());
            xmlTextWriter.WriteElementString("nombreCompleto", empleado.Nombre + ", " + empleado.Apellido);
            xmlTextWriter.WriteElementString("cuil", empleado.Cuil.ToString());
            xmlTextWriter.WriteStartElement("sector");
            xmlTextWriter.WriteAttributeString("denominacion", empleado.Sector.Denominacion);
            xmlTextWriter.WriteAttributeString("id", empleado.Sector.Id.ToString());
            xmlTextWriter.WriteAttributeString("valorSemaforo", empleado.Sector.valorSemaforo.ToString());
            xmlTextWriter.WriteAttributeString("colorSemaforo", empleado.Sector.colorSemaforo.ToString());
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteElementString("cupoAsignado", empleado.CupoAsignado.ToString());
            xmlTextWriter.WriteElementString("cupoConsumido", empleado.CupoConsumido.ToString());
            xmlTextWriter.WriteEndElement();
        }

        public void crear()
        {
            XmlTextWriter xmlTextWriter = new XmlTextWriter("cXMLTextWriter_Empleados.xml", Encoding.UTF8); //Para tomar los acentos
            xmlTextWriter.Formatting = Formatting.Indented; //Para alinear todo el contenido automaticamente
            xmlTextWriter.WriteStartDocument();

            xmlTextWriter.WriteStartElement("empleados");
            xmlTextWriter.WriteStartElement("listado");
            Empleados.ForEach(delegate (Empleado empleado)
            {
                agregar(empleado, xmlTextWriter);
            });
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteElementString("subsectores", "5");
            xmlTextWriter.WriteElementString("totalCupoAsignadoSector", "4217.21");
            xmlTextWriter.WriteElementString("totalCupoConsumidoSector", "1405.88");
            xmlTextWriter.WriteElementString("valorDial", "33.34");
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndDocument();
            xmlTextWriter.Close();
        }

        public void leer(String archivo)
        {
            XmlTextReader xmlTextReader;
            xmlTextReader = new XmlTextReader(System.IO.Directory.GetCurrentDirectory() + "\\" + archivo);
            
            if(xmlTextReader != null)
            {
                if (Empleados == null)
                {
                    Empleados = new List<Empleado>();
                }
                else
                {
                    Empleados.Clear();
                }
            }
            while(xmlTextReader.Read())
            {
                if (xmlTextReader.IsStartElement())
                {
                    switch (xmlTextReader.Name)
                    {
                        case "empleado":
                            Empleados.Add(new Empleado());
                            break;
                        case "id":
                            Empleados[Empleados.Count - 1].Id = xmlTextReader.ReadElementContentAsLong();
                            break;
                        case "nombreCompleto":
                            String[] nombreCompleto = xmlTextReader.ReadString().Split(',');
                                Empleados[Empleados.Count - 1].Apellido = nombreCompleto[0].Trim();
                                Empleados[Empleados.Count - 1].Nombre = nombreCompleto[1].Trim();
                            break;
                        case "cuil":
                                Empleados[Empleados.Count - 1].Cuil = xmlTextReader.ReadElementContentAsLong();
                            break;
                        case "sector":
                            //if (xmlReader.Read()) { }
                            Empleados[Empleados.Count - 1].Sector = new Sector(long.Parse(xmlTextReader["id"]), xmlTextReader["denominacion"], Double.Parse(xmlTextReader["valorSemaforo"]), xmlTextReader["colorSemaforo"]);
                            break;
                        case "cupoAsignado":
                            Empleados[Empleados.Count - 1].CupoAsignado = Double.Parse(xmlTextReader.ReadString());
                            break;
                        case "cupoConsumido":
                            Empleados[Empleados.Count - 1].CupoConsumido = Double.Parse(xmlTextReader.ReadString());
                            break;
                    }
                }
            }
            xmlTextReader.Close();
        }

        public override string ToString()
        {
            String empleadosText = "";
            if (Empleados != null)
            {
                empleadosText += "Empleados XMLText Lectura\n-------------------------\n";
                Empleados.ForEach(delegate (Empleado empleado) { empleadosText += (empleado + "\n"); });
            }
            return empleadosText;
        }
    }
}
