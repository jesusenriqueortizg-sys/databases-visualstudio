using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_databases
{
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }
        public string categoria { get; set; }


        public Producto() { }


        public Producto(int id, string nombre, string descripcion, int Precio, int Stock, string categoria)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.Precio = Precio;
            this.Stock = Stock;
            this.categoria = categoria;
        }
    }
}