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

        public static List<Cliente> PresentarRegistro()
        {
            List<Cliente> Lista = new List<Cliente>();
            using (SqlConnection conexion = BD_general.ObtenerConexion())
            {
                string query = "select *from clientes";
                SqlCommand comando = new SqlCommand(query,conexion);

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.id = reader.GetInt32(0);
                    cliente.NombreCompleto = reader.GetString(1);
                    cliente.CorreoElectronico = reader.GetString(2);
                    cliente.direccion = reader.GetString(3);
                    cliente.Telefono = reader.GetString(4);
                    Lista.Add(cliente);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static int ModificarCliente(Cliente cliente)
        {
            int result = 0;
            using (SqlConnection conexion = BD_general.ObtenerConexion())
            {
                string query = "UPDATE clientes SET " + "nombre='" + cliente.NombreCompleto + "', " +     "telefono='" + cliente.Telefono + "', " +  "correo='" + cliente.CorreoElectronico + "', " +   "direccion='" + cliente.direccion + "' " + "WHERE id=" + cliente.id;
                SqlCommand comando = new SqlCommand(query,conexion);

                result = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return result;
        }


    }
}
