using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Práctico_N_6
{
    public class Conexion
    {
        public MySqlConnection MySqlConnection { get; set; }
        public MySqlCommand MySqlCommand { get; set; }
        public MySqlDataReader MySqlDataReader { get; set; }
        public Conexion()
        {
            MySqlConnection = new MySqlConnection("data source = localhost; username = root; password = root");
            
            Consultar(
                    "CREATE DATABASE IF NOT EXISTS prog3_json;" +
                    "USE prog3_json;" +
                    "CREATE TABLE IF NOT EXISTS personas(" +
                    "id bigint NOT NULL PRIMARY KEY," +
                    "apellido varchar(50)," +
                    "nombre varchar(50)," +
                    "dni bigint NOT NULL" +
                    ");" +
                    "CREATE TABLE IF NOT EXISTS libros(" +
                    "id bigint NOT NULL PRIMARY KEY," +
                    "nombre varchar(50)," +
                    "anioPublicacion year," +
                    "editorial varchar(50)," +
                    "persona_id bigint," +
                    "FOREIGN KEY (persona_id) REFERENCES personas(id)" +
                    ");"
                    );
        }

        public void Consultar(String consulta)
        {   
            if(MySqlConnection.State.ToString() == "Open")
            {
                MySqlConnection.Close();
                MySqlConnection.Open();
            }
            else
            {
                MySqlConnection.Open();
            }

            MySqlCommand = new MySqlCommand(consulta, MySqlConnection)
            {
                Transaction = MySqlConnection.BeginTransaction()
            };
            try
            {
                MySqlCommand.ExecuteNonQuery();
                MySqlCommand.Transaction.Commit();
                Console.WriteLine(consulta + '\n');
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                MySqlCommand.Transaction.Rollback();
            }
        }
    }
}
