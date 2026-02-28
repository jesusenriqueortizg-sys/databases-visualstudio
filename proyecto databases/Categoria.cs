using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_databases
{
    public class Categoria
    {
        public int id { get; set; }
        public string NombreCategoria { get; set; }


        public Categoria() { }


        public Categoria(int id, string NombreCategoria)
        {
            this.id = id;
            this.NombreCategoria = NombreCategoria;

        }
    }
}