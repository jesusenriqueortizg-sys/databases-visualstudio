namespace proyecto_databases
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            Productos Productos = new Productos();
            Productos.MdiParent = this;
            Productos.Show();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer=true;
            Clientes clientes = new Clientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            Proveedores proveedores = new Proveedores();
            proveedores.MdiParent = this;
            proveedores.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            Categorias categorias = new Categorias();
            categorias.MdiParent = this;
            categorias.Show();
        }
    }
}
