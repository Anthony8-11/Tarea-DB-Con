using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataBase.Clases.BaseDatos
{
    class ClsConexionMy
    {


        public DataTable consultaTablaDirecta(String sqll)
        {

            MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=dbprogra; Uid=root; Pwd=password");

            conexion.Open();
            MySqlDataReader dr;
            MySqlCommand comm = new MySqlCommand(sqll, conexion);
            dr = comm.ExecuteReader();

            var dataTable = new DataTable();
            dataTable.Load(dr);
            conexion.Close();
            return dataTable;
        }

    }
}
