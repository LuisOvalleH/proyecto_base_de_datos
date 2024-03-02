using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion
{
    internal class Conexion
    {
        private MySqlConnection conexion;
        private string server = "localhost";
        private string database = "qnacho";
        private string user = "root";
        private string password = "ovalle82";
        private string cadenaConexion;

        public Conexion()
        {
            cadenaConexion = $"Server={server};Database={database};Uid={user};Pwd={password};SslMode=none;";
        }

        public MySqlConnection getConexion()

        {   
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }

            return conexion;

        }
    }
}
