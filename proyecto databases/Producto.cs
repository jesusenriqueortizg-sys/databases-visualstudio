using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace proyecto_databases
{
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string categoria { get; set; }
        public int categoriaID { get; set; } 


        public Producto() { }


        public Producto(int id, string nombre, string descripcion, decimal Precio, int Stock,int categoriaID)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.Precio = Precio;
            this.Stock = Stock;
            this.categoriaID = categoriaID;
        }


    }
}