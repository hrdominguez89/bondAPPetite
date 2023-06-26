using bondAPPetite.Entity;
using bondAPPetite.Entity.Carrito;
using bondAPPetite.Entity.Producto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bondAPPetite.View
{
    public partial class MenuCliente : Form
    {

        private List<Carrito> lCarrito;
        private CarritoConsulta mCarritoConsulta;

        private float totalCarrito;

        private Usuario usuario;

        public MenuCliente(Usuario usuario)
        {
            InitializeComponent();
            lblmensaje.Text = usuario.nombre;
            this.usuario = usuario;

            lCarrito = new List<Carrito>();
            mCarritoConsulta = new CarritoConsulta();
            cargarCarrito(this.usuario.id);

        }

        private void cargarCarrito(int usuario_id, string filtro = "")
        {
            //dgv= data grid view
            dgvProductos.Rows.Clear();
            dgvProductos.Refresh();
            lCarrito.Clear();
            lCarrito = mCarritoConsulta.getCarrito(usuario_id);
            this.totalCarrito = 0;
            for (int i = 0; i < lCarrito.Count; i++)
            {
                dgvProductos.RowTemplate.Height = 50;
                dgvProductos.Rows.Add(
                    lCarrito[i].producto_nombre,
                    lCarrito[i].cantidad,
                    "$ " +lCarrito[i].precio,
                    "$ " + lCarrito[i].precio * lCarrito[i].cantidad
                );
                this.totalCarrito = this.totalCarrito + (lCarrito[i].precio * lCarrito[i].cantidad);
            }
            labelValorTotal.Text ="$ " + this.totalCarrito.ToString();


        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {//Cafeteria
            this.Hide();
            ProductoCliente productoCliente = new ProductoCliente(this.usuario, 3);
            productoCliente.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {//Bebida
            this.Hide();
            ProductoCliente productoCliente = new ProductoCliente(this.usuario, 2);
            productoCliente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {//Minutas
            this.Hide();
            ProductoCliente productoCliente = new ProductoCliente(this.usuario, 1);
            productoCliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {//Postres
            this.Hide();
            ProductoCliente productoCliente = new ProductoCliente(this.usuario, 4);
            productoCliente.Show();
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void MenuCliente_Load(object sender, EventArgs e)
        {

        }

        private void lblmensaje_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdendePago ordendePago = new OrdendePago(this.usuario);
            ordendePago.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
