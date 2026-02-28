using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_databases
{
    public class proveedor
    {
        public int id { get; set; }
        public string NombreProveedor { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }


        public proveedor() { }


        public proveedor(int id, string nombreCompleto, string correoElectronico, string telefono, string direccion)
        {
            this.id = id;
            this.NombreProveedor = NombreProveedor;
            this.CorreoElectronico = correoElectronico;
            this.Telefono = telefono;
        }
    }
}
