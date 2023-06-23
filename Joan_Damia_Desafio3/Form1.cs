using CRUD_Winform.Modelos;
using Joan_Damia_Desafio3.Repository;
using System.Windows.Forms;

namespace Joan_Damia_Desafio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Producto> productos = ADO_metodos_sql.ObtenerProductos();
            dataGridView1.DataSource = productos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<ProductoVendido> productosVendidos = ADO_metodos_sql.ObtenerProductosVendidos();
            dataGridView1.DataSource = productosVendidos;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = ADO_metodos_sql.ObtenerUsuarios();
            dataGridView1.DataSource = usuarios;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Venta> ventas = ADO_metodos_sql.ObtenerVentas();
            dataGridView1.DataSource = ventas;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            Usuario usuario = ADO_metodos_sql.IniciarSesion(nombreUsuario, contraseña);

            if (usuario != null)
            {
                MessageBox.Show("Usuario Correcto");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}