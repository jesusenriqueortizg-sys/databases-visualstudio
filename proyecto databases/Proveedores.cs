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

namespace proyecto_databases
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {
            dgvProveedores.DataSource = ProveedoresDAL.PresentarRegistro();
        }


        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {

            proveedor Proveedor = new proveedor();
            Proveedor.NombreProveedor = TxtNombre.Text;
            Proveedor.CorreoElectronico = TxtCorreo.Text;
            Proveedor.Telefono = TxtTelefono.Text;

            int result = ProveedoresDAL.AgregarProveedor(Proveedor);

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

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            proveedor Proveedor = new proveedor();
            Proveedor.NombreProveedor = TxtProveedorActualizar.Text;
            Proveedor.CorreoElectronico = TxtCorreoActualizar.Text;
            Proveedor.Telefono = TxtTelefonoActualizar.Text;
            Proveedor.id = Convert.ToInt32(TxtIDActualizar.Text);
            int result = ProveedoresDAL.ModificarProveedor(Proveedor);
            MessageBox.Show("Actualizado correctamente");
        }

        private void dgvProveedores_SelectionChanged(object sender, EventArgs e)
        {
            TxtID.Text = Convert.ToString(dgvProveedores.CurrentRow.Cells["Id"].Value);
            TxtProveedorActualizar.Text = Convert.ToString(dgvProveedores.CurrentRow.Cells["NombreCompleto"].Value);
            TxtCorreoActualizar.Text = Convert.ToString(dgvProveedores.CurrentRow.Cells["direccion"].Value);
            TxtTelefonoActualizar.Text = Convert.ToString(dgvProveedores.CurrentRow.Cells["Telefono"].Value);
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtID.Text);
            int resultado = ProveedoresDAL.EliminarProveedor(id);
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
