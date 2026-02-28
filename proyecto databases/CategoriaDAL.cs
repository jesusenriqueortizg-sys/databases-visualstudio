using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace proyecto_databases
{
    public class CategoriaDAL
    {
        public static int AgregarCategoria(Categoria categoria)
        {
            int retorna = 0;

            using (SqlConnection conexion = BD_general.ObtenerConexion())
            {
                string query = "insert into Categorias (Nombrecategoria) values('" + categoria.NombreCategoria + "')";

                SqlCommand command = new SqlCommand(query, conexion);
                retorna = command.ExecuteNonQuery();

            }
            return retorna;

        }

        public static List<Categoria> PresentarRegistro()
        {
            List<Categoria> Lista = new List<Categoria>();
            using (SqlConnection conexion = BD_general.ObtenerConexion())
            {
                string query = "select *from categorias";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.id = reader.GetInt32(0);
                    categoria.NombreCategoria = reader.GetString(1);
                    Lista.Add(categoria);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static int ModificarCategoria(Categoria categoria)
        {
            int result = 0;
            using (SqlConnection conexion = BD_general.ObtenerConexion())
            {
                string query = "UPDATE Categorias SET "+ "Nombrecategoria='" + categoria.NombreCategoria + "' "+ "WHERE CategoriaId=" + categoria.id;
                SqlCommand comando = new SqlCommand(query, conexion);

                result = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return result;
        }
        public static int EliminarCategoria(int id)
        {
            int retorna = 0;

            using (SqlConnection conexion = BD_general.ObtenerConexion())
            {
                string query = "delete from Categorias where ProovedorId =" + id + " ";

                SqlCommand command = new SqlCommand(query, conexion);
                retorna = command.ExecuteNonQuery();

            }
            return retorna;

        }
    }
}