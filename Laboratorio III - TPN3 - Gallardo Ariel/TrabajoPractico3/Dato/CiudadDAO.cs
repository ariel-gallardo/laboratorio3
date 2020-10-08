using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico3.Modelo;

namespace TrabajoPractico3.Dato
{
    class CiudadDAO : Conexion
    {
        public override void CargarTODO()
        {
            Consultar("SELECT city.name as Ciudad, city.population as Poblacion, country.name as Pais FROM city LEFT JOIN country ON city.countrycode = country.code");
            mySqlDataReader = mySqlCommand.ExecuteReader();
            Ciudad.Ciudades = new List<Ciudad>();
            while (mySqlDataReader.Read())
            {
                Ciudad.Ciudades.Add(
                    new Ciudad(
                        mySqlDataReader.GetString("Ciudad"),
                        long.Parse(mySqlDataReader.GetString("Poblacion")),
                        Pais.Paises[mySqlDataReader.GetString("Pais")]
                    ));
            }
        }

        public void BuscarCiudad(String _Ciudad, String Poblacion, String _Pais)
        {
            Consultar("SELECT city.name as Ciudad, city.population as Poblacion, country.name as Pais FROM city LEFT JOIN country ON city.countrycode = country.code WHERE "
                + (_Ciudad != String.Empty ? "city.name = '" + _Ciudad + "' " +
                (Poblacion != String.Empty || _Pais != String.Empty ? "AND " : "")
                : "")
                + (Poblacion != String.Empty ? "city.population <= " + Poblacion + " " +
                (_Pais != String.Empty ? "AND " : "")
                : "")
                + (_Pais != String.Empty ? "country.name = '" + _Pais + "'" : "")
                );


            mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                Ciudad.Ciudades.Add(
                    new Ciudad(
                        mySqlDataReader.GetString("Ciudad"),
                        long.Parse(mySqlDataReader.GetString("Poblacion")),
                        Pais.Paises[mySqlDataReader.GetString("Pais")]
                    ));
            }
        }

        public void Actualizar(Ciudad ciudad, String codViejo)
        {
            Consultar("UPDATE city SET name = '"+ciudad.Nombre+"', population = '"+ciudad.Poblacion+"', countrycode = '"+ciudad.Pais.Codigo+"' WHERE name = '"+ciudad.Nombre+"' AND countrycode = '"+codViejo+"'");
            mySqlCommand.ExecuteNonQuery();
        }

        public void Crear(Ciudad ciudad)
        {
            Consultar("INSERT INTO city (name, population, countrycode) VALUES ('" + ciudad.Nombre + "', '" + ciudad.Poblacion + "', '" + ciudad.Pais.Codigo + "')");
            mySqlCommand.ExecuteNonQuery();
        }

        public void Eliminar(Ciudad ciudad)
        {
            Consultar("DELETE FROM city WHERE name = '" + ciudad.Nombre + "' AND countrycode = '" + ciudad.Pais.Codigo + "'");
            mySqlCommand.ExecuteNonQuery();
        }
    }
}
