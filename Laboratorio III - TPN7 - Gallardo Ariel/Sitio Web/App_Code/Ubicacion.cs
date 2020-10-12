using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Ubicacion
/// </summary>
public class Ubicacion
{
    public String Codigo { get; set; }
    public String Nombre { get; set; }
    public Ubicacion() { }

    public Ubicacion(string codigo, string nombre)
    {
        Codigo = codigo;
        Nombre = nombre;
    }
}