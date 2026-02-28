using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace proyecto_databases
{
    public class ProductosDAl 
    {
        public static int AgregarProducto(Producto producto)
        {
            int retorna = 0;

            using (SqlConnection conexion = BD_general.ObtenerConexion())
            {
                string query = "insert into productos (nombre) values('" + producto.nombre + "')";

                SqlCommand command = new SqlCommand(query, conexion);
                retorna = command.ExecuteNonQuery();

            }
            return retorna;

        }

        public static List<Producto> PresentarRegistro()
        {
            List<Producto> Lista = new List<Producto>();
            using (SqlConnection conexion = BD_general.ObtenerConexion())
            {
                string query = "select *from categorias";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Producto producto = new Producto();
                    producto.id = reader.GetInt32(0);
                    producto.nombre = reader.GetString(1);
                    Lista.Add(producto);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static int ModificarProductos(Producto producto)
        {
            int result = 0;
            using (SqlConnection conexion = BD_general.ObtenerConexion())
            {
            string query = "UPDATE productos SET " +"nombre='" + producto.nombre + "', " +  "descripcion='" + producto.descripcion + "', " +    "precio=" + producto.Precio + ", " + "stock=" + producto.Stock + ", " +"categoriaID=" + producto.categoria + " " +"WHERE Id=" + producto.id;
            SqlCommand comando = new SqlCommand(query, conexion);

                result = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return result;
        }
        public static int EliminarCliente(int id)
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
