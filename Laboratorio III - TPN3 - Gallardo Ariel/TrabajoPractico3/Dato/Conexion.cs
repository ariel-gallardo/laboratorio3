using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrabajoPractico3.Dato
{
    abstract class Conexion
    {
        protected MySqlConnection mySqlConnection;
        protected MySqlCommand mySqlCommand;
        protected MySqlDataReader mySqlDataReader;
        protected Conexion()
        {
            mySqlConnection = new MySqlConnection("Server=localhost;user=root;password=root;database=world");
            try
            {
                mySqlConnection.Open();
            }catch(MySqlException sE)
            {
                System.Windows.Forms.MessageBox.Show("Error en la conexion");
                Environment.Exit(-1);
            }
            
        }

        protected void Consultar(String consulta)
        {
            mySqlCommand = new MySqlCommand(consulta, mySqlConnection);
        }

        ~Conexion()
        {
            mySqlConnection.Close();
        }

        public abstract void CargarTODO();
    }
}
