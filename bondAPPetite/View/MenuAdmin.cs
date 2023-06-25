using bondAPPetite.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bondAPPetite.View
{
    public partial class MenuAdmin : Form
    {

        private Usuario usuario;

        public MenuAdmin(Usuario usuario)
        {
            InitializeComponent();
            lblmensaje.Text = usuario.nombre;
            this.usuario = usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductosAdmin productosAdmin = new ProductosAdmin(this.usuario);
            productosAdmin.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void lblmensaje_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroUsuario registrarUsuario = new RegistroUsuario(this.usuario);
            registrarUsuario.Show();
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
                login.Show();
        }
    }
}
