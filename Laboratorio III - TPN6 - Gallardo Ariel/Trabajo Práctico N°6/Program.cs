using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Trabajo_Práctico_N_6
{
    class Program
    {
        public static Program _Program { get; set; }
        public static Conexion ConLista { get; set; }
        public static Conexion ConLibros { get; set; }
        public static List<Persona> Personas { get; set; }
        public static JsonURL.JsonURL JsonURL { get; set; }
        static void Main(string[] args)
        {
            _Program = new Program();
            Personas = new List<Persona>(new Persona[]{
                new Persona(1,"Alvarez","Jose",15927342, new List<Libro>(new Libro[]{
                    new Libro(1,"C++",1995,"Bruma"),
                    new Libro(2,"Java",2000,"Bruma"),
                    new Libro(3,"HTML5",2005,"Alba")
                })),
                new Persona(2,"Hernandez","Roque",23942321,new List<Libro>(new Libro[]{
                    new Libro(4,"PHP",2003,"Alba"),
                    new Libro(5,"JavaScript",2005,"Alba"),
                    new Libro(6,"Bootstrap",2010,"Alba")
                }))
            });
            CargarPersonasDB();
            LeerPersonasDB();
            CrearJSON("Personas");
            LeerJSONURL("https://randomuser.me/api/?results=10");
            if (JsonURL != null)
            {
                LeerAtribJSONURL();
            }
            Console.WriteLine("Presione Enter para Salir.");
            Console.ReadLine();
        }

        private static void CargarPersonasDB()
        {
            ConLista = new Conexion();
            Personas.ForEach(delegate(Persona _Persona) {
                ConLista.Consultar("INSERT INTO personas (id,apellido,nombre,dni) VALUES('" +_Persona.Id+"', '"+_Persona.Apellido+"', '"+_Persona.Nombre+"', '"+_Persona.Dni+ "') ON DUPLICATE KEY UPDATE id = VALUES(id),apellido = VALUES(apellido),nombre = VALUES(nombre),dni = VALUES(dni)");
                CargarLibrosPersonaDB(_Persona);
            });
        }

        private static void CargarLibrosPersonaDB(Persona _Persona)
        {
            ConLibros = new Conexion();
            _Persona.Libros.ForEach(delegate (Libro _Libro) {
                ConLibros.Consultar("INSERT INTO libros (id,nombre,anioPublicacion,editorial,persona_id) VALUES('" +_Libro.Id+"', '"+_Libro.Nombre+"', '"+_Libro.AnioPublicacion+"', '"+_Libro.Editorial+"', '"+_Persona.Id+ "') ON DUPLICATE KEY UPDATE id = VALUES(id),nombre = VALUES(nombre),anioPublicacion = VALUES(anioPublicacion),editorial = VALUES(editorial),persona_id = VALUES(persona_id)");
            });
        }

        private static void LeerPersonasDB()
        {
            if(Personas.Count > 0)
            {
                Personas.Clear();
            }

            ConLista.Consultar("SELECT * FROM Personas");
            ConLista.MySqlDataReader = ConLista.MySqlCommand.ExecuteReader();
            if (ConLista.MySqlDataReader != null)
            {
                while (ConLista.MySqlDataReader.Read())
                {
                    Personas.Add(
                        new Persona(
                            long.Parse(ConLista.MySqlDataReader.GetString("id")),
                            ConLista.MySqlDataReader.GetString("apellido"),
                            ConLista.MySqlDataReader.GetString("nombre"),
                            long.Parse(ConLista.MySqlDataReader.GetString("dni")),
                            LeerLibrosDB(ConLista.MySqlDataReader.GetString("id"))
                        ));
                }
            }
        }
        private static List<Libro> LeerLibrosDB(String id)
        {
            ConLibros.Consultar("SELECT * FROM Libros WHERE persona_id = '"+id+"'");
            List<Libro> tempLibros = new List<Libro>();
            ConLibros.MySqlDataReader = ConLibros.MySqlCommand.ExecuteReader();
            if (ConLibros.MySqlDataReader != null)
            {
                while (ConLibros.MySqlDataReader.Read())
                {
                    tempLibros.Add(new Libro(long.Parse(ConLibros.MySqlDataReader.GetString("id")), ConLibros.MySqlDataReader.GetString("nombre"), ConLibros.MySqlDataReader.GetInt32("anioPublicacion"), ConLibros.MySqlDataReader.GetString("editorial")));
                }
                return tempLibros;
            }
            return null;
        }

        private static void CrearJSON(String nombre)
        {
            File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + nombre + ".json", JsonConvert.SerializeObject(Personas.ToArray(), Formatting.Indented));
        }

        private static void LeerJSONURL(String url)
        {
            var webRequest = WebRequest.Create(url);  
                String archivoJSON;
                using (StreamReader streamReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
                {
                    archivoJSON = streamReader.ReadToEnd();
                }
                if (archivoJSON != null)
                {
                    JsonURL = JsonConvert.DeserializeObject<JsonURL.JsonURL>(archivoJSON);
                }
        }

        private static void LeerAtribJSONURL()
        {
            JsonURL.results.ForEach(delegate (JsonURL.Result _Result) {
                Console.WriteLine("User\n****\n"+
                    "\tFirstName: " + _Result.name.first + "\n" +
                    "\t LastName: " + _Result.name.last + "\n" +
                    "\t UserName: " + _Result.login.username + "\n" +
                    "\t Password: " + _Result.login.password + "\n");
            });
        }
    }
}
