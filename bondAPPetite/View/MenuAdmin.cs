﻿using bondAPPetite.Entity;
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
        public MenuAdmin(Usuario usuario)
        {
            InitializeComponent();
            labelName.Text = usuario.nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductosAdmin productosAdmin = new ProductosAdmin();
            productosAdmin.Show();
        }
    }
}
