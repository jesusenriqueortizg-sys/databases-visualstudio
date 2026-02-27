using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace proyecto_databases
{
    public class clientesDAL
    {
        public static int AgregarCliente(Cliente cliente)
        {
            int retorna = 0;

            using (SqlConnection conexion = BD_general.ObtenerConexion())
            {
                string query = "insert into Clientes (NombreCompleto, CorreoElectronico, Telefono, Direccion) values('"+ cliente.NombreCompleto + "','"+ cliente.CorreoElectronico + "','"  + cliente.Telefono + "','"  + cliente.direccion + "')";

                SqlCommand command = new SqlCommand(query,conexion);
                retorna = command.ExecuteNonQuery();

            }
            return retorna;

        }
    }
}
