using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_databases
{
    public class Cliente
    {
        public int id { get; set; }
        public string NombreCompleto { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string direccion {  get; set; }


        public Cliente() { }


        public Cliente(int id, string nombreCompleto, string correoElectronico, string telefono, string direccion)
        {
            this.id = id;
            this.NombreCompleto = nombreCompleto;
            this.CorreoElectronico = correoElectronico;
            this.Telefono = telefono;
            this.direccion = direccion;
        }
    }
}
