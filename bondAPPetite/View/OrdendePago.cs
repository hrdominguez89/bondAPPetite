using bondAPPetite.Entity;
using bondAPPetite.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bondAPPetite
{
    public partial class OrdendePago : Form
    {
        private Usuario usuario;
        public OrdendePago(Usuario usuario)
        {
            InitializeComponent();
            lblmensaje.Text = usuario.nombre;
            this.usuario = usuario;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OrdendePago_Load(object sender, EventArgs e)
        {

        }

        private void lblmensaje_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuCliente menuCliente = new MenuCliente(this.usuario);
            menuCliente.Show();
        }
    }
}
