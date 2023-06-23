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
    public partial class MenuCliente : Form
    {
        public MenuCliente(Usuario usuario)
        {
            InitializeComponent();
            lblmensaje.Text = usuario.nombre;
        }
    }
}
