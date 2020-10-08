using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoN_4
{
    class Conexion
    {
        public MySqlConnection MySqlConnection { get; set; }
        public MySqlCommand MySqlCommand { get; set; }
        public MySqlDataReader MySqlDataReader { get; set; }

        public Conexion() //Sirve para traer datos
        {
            try
            {
                MySqlConnection = new MySqlConnection("data source = localhost;username=root;password=root;database=utn");
                MySqlCommand = new MySqlCommand
                {
                    Connection = MySqlConnection
                };
            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Se produjo un error" + e.Message);
            }
        }
        public Conexion(String consulta) //Sirve para actualizar, eliminar, crear
        {
            try
            {
                MySqlConnection = new MySqlConnection("data source = localhost;username=root;password=root;database=utn");
                MySqlConnection.Open();
                MySqlCommand = new MySqlCommand(consulta, MySqlConnection,MySqlConnection.BeginTransaction());
                MySqlCommand.ExecuteNonQuery();
                MySqlCommand.Transaction.Commit();
            }
            catch(Exception e)
            {
                MySqlCommand.Transaction.Rollback();
            }
        }

        public List<String> ObtenerFilas(String tabla, long limINF, long limSUP)
        {
            List<String> tempLista = new List<String>();
            MySqlConnection.Open();
            MySqlCommand.CommandText = "SELECT * FROM " + tabla + " LIMIT " + limINF + ", " + limSUP;
            MySqlDataReader = MySqlCommand.ExecuteReader();
            while (MySqlDataReader.Read())
            {
                String fila = String.Empty;
                for (int i = 0; i < MySqlDataReader.FieldCount; i++)
                {
                    fila += MySqlDataReader.GetString(i);
                    if(i != MySqlDataReader.FieldCount - 1)
                    {
                        fila += "\t";
                    }
                }
                tempLista.Add(fila);
            }
            return tempLista;
        }

        public String ObtenerNombreColumnas(String tabla)
        {
            MySqlConnection.Open();
            MySqlCommand.CommandText = "SELECT * FROM " + tabla + " LIMIT 1";
            MySqlDataReader = MySqlCommand.ExecuteReader();
            string nombreColumnas = "";
            while (MySqlDataReader.Read())
            {
                for (int i = 0; i < MySqlDataReader.FieldCount; i++)
                {
                    nombreColumnas += MySqlDataReader.GetName(i);
                    if (i != MySqlDataReader.FieldCount - 1)
                    {
                        nombreColumnas += "\t";
                    }
                }
            } 
            return nombreColumnas;
        }

        public long ObtenerCantidadRegistro(String tabla)
        {
            MySqlConnection.Open();
            MySqlCommand.CommandText = "SELECT count(*) FROM " + tabla;
            MySqlDataReader = MySqlCommand.ExecuteReader();
            while (MySqlDataReader.Read())
            {
                return long.Parse(MySqlDataReader.GetString(0));
            }
            return 0L;
        }

        public Boolean existeRegistro(String tabla, long id)
        {
            MySqlConnection.Open();
            MySqlCommand.CommandText = "SELECT count(*) FROM " + tabla + " WHERE id = "+id;
            MySqlDataReader = MySqlCommand.ExecuteReader();
            while (MySqlDataReader.Read())
            {
                return true;
            }
            return false;
        }

        ~Conexion()
        {
            MySqlConnection.Close();
        }
    }
}
