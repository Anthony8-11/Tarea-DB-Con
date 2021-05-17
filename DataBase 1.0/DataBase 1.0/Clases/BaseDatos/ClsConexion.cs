using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataBase.Clases.BaseDatos
{
    class ClsConexion
    {

        public DataTable consultaTablaDirecta(String sqll)
        {

            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-9ITQKIPO;Initial Catalog=dbprogra;Integrated Security=True");

            conexion.Open();
            SqlDataReader dr;
            SqlCommand comm = new SqlCommand(sqll, conexion);
            dr = comm.ExecuteReader();

            var dataTable = new DataTable();
            dataTable.Load(dr);
            conexion.Close();
            return dataTable;
        }


    }
}
