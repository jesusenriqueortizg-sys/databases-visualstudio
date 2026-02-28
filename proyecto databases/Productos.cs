using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            using (SqlConnection conexion = BD_general.ObtenerConexion())
            {
                string query = "SELECT categoriaId FROM Categorias";

                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboCat.DataSource = dt;
                comboCat.DisplayMember = "categoriaId";
                comboCat.ValueMember = "categoriaId";

            }
            using (SqlConnection conexion = BD_general.ObtenerConexion())
            {
                string query = "SELECT categoriaId FROM Categorias";

                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "categoriaId";
                comboBox2.ValueMember = "categoriaId";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.nombre = TxtNombre.Text;
            producto.descripcion = TxtDesc.Text;
            producto.Precio = Convert.ToDecimal(TxtPrecio.Text);
            producto.Stock = Convert.ToInt32(TxtStock.Text);
            producto.categoriaID = Convert.ToInt32(comboCat.SelectedValue);

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox7.Text);
            int resultado = ProductosDAl.EliminarProductos(id);
            if (resultado > 0)
            {
                MessageBox.Show("Eliminado con exito");
            }
            else
            {
                MessageBox.Show("error al eliminarse");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.nombre = textBox6.Text;
            producto.descripcion = textBox10.Text;
            producto.Precio = Convert.ToDecimal(textBox5.Text);
            producto.Stock = Convert.ToInt32(textBox6.Text);
            producto.id = Convert.ToInt32(textBox11.Text);
            producto.categoriaID=Convert.ToInt32(comboBox2.Text):
            int result = ProductosDAl.ModificarProductos(producto);
            MessageBox.Show("Actualizado correctamente");

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
