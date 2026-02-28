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
            dgvClientes.DataSource = clientesDAL.PresentarRegistro();
        }
        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.NombreCompleto = TxtNombre.Text;
            cliente.CorreoElectronico = TxtCorreo.Text;
            cliente.direccion = TxtDireccion.Text;
            cliente.Telefono = TxtTelefono.Text;

            int result = clientesDAL.AgregarCliente(cliente);

            if (result > 0)
            {
                MessageBox.Show("Exito al guardar");

            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
            CargarDatos();




        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            TxtID.Text = Convert.ToString(dgvClientes.CurrentRow.Cells["Id"].Value);
            TxtNombreActualizar.Text = Convert.ToString(dgvClientes.CurrentRow.Cells["NombreCompleto"].Value);
            TxtCorreoActualizar.Text = Convert.ToString(dgvClientes.CurrentRow.Cells["direccion"].Value);
            TxtTelefonoActualizar.Text = Convert.ToString(dgvClientes.CurrentRow.Cells["Telefono"].Value);
            TxtDireccionActualizar.Text = Convert.ToString(dgvClientes.CurrentRow.Cells["CorreoElectronico"].Value);
        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {
            TxtID.Enabled = false;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.NombreCompleto = TxtNombreActualizar.Text;
            cliente.CorreoElectronico = TxtCorreoActualizar.Text;
            cliente.direccion = TxtDireccionActualizar.Text;
            cliente.Telefono = TxtTelefonoActualizar.Text;
            cliente.id = Convert.ToInt32(TxtID.Text);
            int result = clientesDAL.ModificarCliente(cliente);
            MessageBox.Show("Actualizado correctamente");

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtID.Text);
            int resultado = clientesDAL.EliminarCliente(id);
            if (resultado > 0)
            {
                MessageBox.Show("Eliminado con exito");
            }
            else
            {
                MessageBox.Show("error al eliminarse");
            }
        }
    }
}
