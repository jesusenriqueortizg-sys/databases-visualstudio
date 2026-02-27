using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace proyecto_databases
{
    internal class BD_general
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=tarea;Data Source=JESUS-PC-GAMER;TrustServerCertificate=True;");
            conexion.Open();
            return conexion;
        }
    }
}
