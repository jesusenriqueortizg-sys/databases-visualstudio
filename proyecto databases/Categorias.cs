using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Identity.Client;

namespace proyecto_databases
{
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
            CargarDatos();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.NombreCategoria = TxtCategoria.Text;


            int result = CategoriaDAL.AgregarCategoria(categoria);

            if (result > 0)
            {
                MessageBox.Show("Exito al guardar");

            }
            else
            {
                MessageBox.Show("Error al guardar");
            }



        }
        private void CargarDatos()
        {
            dataGridView1.DataSource = CategoriaDAL.PresentarRegistro();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Categoria categoria= new Categoria();
            categoria.NombreCategoria = TxtCategoriaActualizar.Text;
            categoria.id = Convert.ToInt32(TxtIDActualizar.Text);
            int result = CategoriaDAL.ModificarCategoria(categoria);
            MessageBox.Show("Actualizado correctamente");
        }
    }
}
