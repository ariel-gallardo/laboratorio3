using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Usuario
/// </summary>
public class Usuario
{
    public String Nombre { get; set; }
    public String Alternativo { get; set; }
    public String Password { get; set; }
    public Persona Persona { get; set; }
    public Usuario() { }

    public Usuario(string nombre, string alternativo, string password, Persona persona)
    {
        Nombre = nombre;
        Alternativo = alternativo;
        Password = password;
        Persona = persona;
    }
}