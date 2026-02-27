using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.IO.Pipes;

namespace proyecto_databases
{
    public partial class Clientes : Form
    {

        public Clientes()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarDatos()
        {

        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.NombreCompleto =TxtNombre.Text;
            cliente.CorreoElectronico =TxtCorreo.Text;
            cliente.direccion = TxtDireccion.Text;
            cliente.Telefono = TxtTelefono.Text;

            int result = clientesDAL.AgregarCliente(cliente);

            if (result > 0)
            {
                MessageBox.Show("Exito al guardas");

            }
            else
            {
                MessageBox.Show("Error al guardar");
            }

        }
    }
}
