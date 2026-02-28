using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_databases
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.nombre = TxtNombre.Text;
            producto.descripcion = TxtDesc.Text;
            producto.Precio = Convert.ToInt32(TxtPrecio.Text);
            producto.Stock = Convert.ToInt32(TxtStock.Text);

            int result = ProductosDAl.AgregarProducto(producto);

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
        private void CargarDatos()
        {
            dataGridView1.DataSource = ProductosDAl.PresentarRegistro();
        }
    }
}
