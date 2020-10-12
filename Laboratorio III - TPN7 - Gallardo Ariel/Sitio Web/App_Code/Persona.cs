using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Persona
/// </summary>
public class Persona
{
    public String Nombre { get; set; }
    public String Apellido { get; set; }
    public String FechaNacimiento { get; set; }
    public String Sexo { get; set; }

    public String Telefono { get; set; }
    public Ubicacion Ubicacion { get; set; }
    public Persona() { }

    public Persona(string nombre, string apellido, string fechaNacimiento, string sexo, String telefono, Ubicacion ubicacion)
    {
        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = fechaNacimiento;
        Sexo = sexo;
        Telefono = telefono;
        Ubicacion = ubicacion;
    }
}