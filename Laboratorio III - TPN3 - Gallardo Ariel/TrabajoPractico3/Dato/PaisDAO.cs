using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico3.Modelo;

namespace TrabajoPractico3.Dato
{
    class PaisDAO : Conexion
    {
        public override void CargarTODO()
        {
            Consultar("SELECT code, name, population FROM country");
            mySqlDataReader = mySqlCommand.ExecuteReader();
            Pais.Paises = new Dictionary<String, Pais>();
            while (mySqlDataReader.Read())
            {
                Pais.Paises.Add(mySqlDataReader.GetString("name"),
                    new Pais(
                        mySqlDataReader.GetString("code"),
                        mySqlDataReader.GetString("name"),
                        long.Parse(mySqlDataReader.GetString("population"))
                    ));
            }
        }
    }
}
