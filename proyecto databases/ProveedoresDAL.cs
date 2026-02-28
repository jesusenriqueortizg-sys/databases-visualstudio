using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace proyecto_databases
{
    public class ProveedoresDAL
    {
        public static int AgregarProveedor(proveedor Proveedor)
        {
            int retorna = 0;

            using (SqlConnection conexion = BD_general.ObtenerConexion())
            {
                string query = "insert into Proveedores (NombreProveedor, CorreoElectronico, Telefono) values('" + Proveedor.NombreProveedor + "','" + Proveedor.CorreoElectronico + "','" + Proveedor.Telefono + "')";

                SqlCommand command = new SqlCommand(query, conexion);
                retorna = command.ExecuteNonQuery();

            }
            return retorna;

        }

        public static List<proveedor> PresentarRegistro()
        {
            List<proveedor> Lista = new List<proveedor>();
            using (SqlConnection conexion = BD_general.ObtenerConexion())
            {
                string query = "select *from Proveedores";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    proveedor Proveedor = new proveedor();
                    Proveedor.id = reader.GetInt32(0);
                    Proveedor.NombreProveedor = reader.GetString(1);
                    Proveedor.CorreoElectronico = reader.GetString(2);
                    Proveedor.Telefono = reader.GetString(3);
                    Lista.Add(Proveedor);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static int ModificarProveedor(proveedor Proveedor)
        {
            int result = 0;
            using (SqlConnection conexion = BD_general.ObtenerConexion())
            {
                string query = "UPDATE Proveedores SET " + "NombreProveedor='" + Proveedor.NombreProveedor + "', " + "telefono='" + Proveedor.Telefono + "', " + "CorreoElectronico='" + Proveedor.CorreoElectronico + "' " + "WHERE ProveedorID=" + Proveedor.id;
                SqlCommand comando = new SqlCommand(query, conexion);

                result = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return result;
        }
        public static int EliminarProveedor(int id)
        {
            int retorna = 0;

            using (SqlConnection conexion = BD_general.ObtenerConexion())
            {
                string query = "delete from clientes where ProovedorID =" + id + " ";

                SqlCommand command = new SqlCommand(query, conexion);
                retorna = command.ExecuteNonQuery();

            }
            return retorna;

        }
    }
}