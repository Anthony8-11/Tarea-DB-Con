using DataBase.Clases.BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_1._0
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Elige una base de datos: ");
            Console.WriteLine("1. Sql");
            Console.WriteLine("2. Mysql");

            int opcion = Int32.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    cnSql();
                    break;

                case 2:
                    cnMysql();
                    break;

            }


        }



        static void cnSql()
        {
            ClsConexion cn = new ClsConexion();

            DataTable dt = cn.consultaTablaDirecta("SELECT *  FROM [tb_alumnos]");

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine(dr[1]);


            }

            Console.ReadKey();
        }


        static void cnMysql()
        {
            ClsConexionMy cn = new ClsConexionMy();

            DataTable dt = cn.consultaTablaDirecta("SELECT * FROM dbprogra.tb_alumnos;");

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine(dr[1]);
            }
            Console.ReadKey();
        }
    }
}
