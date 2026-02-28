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
                string query = "INSERT INTO productos (nombre, descripcion, precio, stock, categoriaID) VALUES ('"+ producto.nombre + "', '" + producto.descripcion + "', "+ producto.Precio + ", " + producto.Stock + ", " + producto.categoriaID + ")";

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
                string query = "select *from Productos";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Producto producto = new Producto();
                    producto.id = reader.GetInt32(0);
                    producto.nombre = reader.GetString(1);
                    producto.descripcion = reader.GetString(2);
                    producto.Precio= reader.GetDecimal(3);
                    producto.Stock=reader.GetInt32(4);
                    producto.categoriaID = reader.GetInt32(5);
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
            string query = "UPDATE productos SET " +"nombre='" + producto.nombre + "', " +  "descripcion='" + producto.descripcion + "', " +    "precio=" + producto.Precio + ", " + "stock=" + producto.Stock + ", " +"categoriaID=" + producto.categoriaID + " " +"WHERE Id=" + producto.id;
            SqlCommand comando = new SqlCommand(query, conexion);

                result = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return result;
        }
        public static int EliminarProductos(int id)
        {
            int retorna = 0;

            using (SqlConnection conexion = BD_general.ObtenerConexion())
            {
                string query = "delete from productos where Id=" + id + " ";

                SqlCommand command = new SqlCommand(query, conexion);
                retorna = command.ExecuteNonQuery();

            }
            return retorna;
        }
    }
}
