using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Conexion
/// </summary>
public class Conexion
{
    public MySqlConnection MySqlConnection { get; set; }
    public MySqlCommand MySqlCommand { get; set; }
    public MySqlDataReader MySqlDataReader { get; set; }
    public Conexion()
    {
        MySqlConnection = new MySqlConnection("data source = localhost; username = root; password = root");

        Consultar(
                "CREATE DATABASE IF NOT EXISTS prog3_net;" +
                "USE prog3_net;" +
                "CREATE TABLE IF NOT EXISTS ubicaciones(" +
                "codigo varchar(6) NOT NULL PRIMARY KEY," +
                "nombre varchar(50)" +
                ");" +
                "INSERT INTO ubicaciones (codigo,nombre) VALUES ('ARG', 'ARGENTINA'), ('CLE', 'CHILE'), ('URG', 'URUGUAY') ON DUPLICATE KEY UPDATE codigo = VALUES(codigo), nombre = VALUES(nombre);" +
                "CREATE TABLE IF NOT EXISTS personas(" +
                "id bigint NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                "apellido varchar(50) NOT NULL," +
                "nombre varchar(50) NOT NULL," +
                "telefono varchar(15) NOT NULL," +
                "ubicacion_codigo varchar(3) NOT NULL,"+
                "FOREIGN KEY (ubicacion_codigo) REFERENCES ubicaciones(codigo)"+
                ");" +
                "CREATE TABLE IF NOT EXISTS usuarios(" +
                "id bigint NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                "nombre varchar(50)," +
                "alternativo varchar(50)," +
                "password varchar(100)," +
                "persona_id bigint NOT NULL,"+
                "FOREIGN KEY (persona_id) REFERENCES personas(id)"+
                ");"
                );
    }

    public void Consultar(String consulta)
    {
        if (MySqlConnection.State.ToString() == "Open")
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