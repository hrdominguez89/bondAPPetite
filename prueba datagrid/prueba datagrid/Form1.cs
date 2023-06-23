using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;


namespace prueba_datagrid
{
    public partial class Form1 : Form
    {
        DataGridView tbllista = new DataGridView();
        
        public int i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        //boton agregar sandwich
        private void button1_Click(object sender, EventArgs e)
        {
            string cantidad, producto, precio;


            cantidad = txtcantidad.Text;
            producto = lblSandwich.Text;
            precio = labelprecio.Text;
            tbllista.Rows.Add(i + "", cantidad, producto, precio);
            i = i + 1;
            limpiar();
            lblSandwich.Focus();

        }

        private void limpiar()
        {

            txtcantidad.Text = "";
            lblSandwich.Text = "";
            labelprecio.Text = "";

        }

        private void btniralista_Click(object sender, EventArgs e)
        {
            Lista_de_compras tbllista = new Lista_de_compras();
            tbllista.Show();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {


            string c, p;
            double v;
            c = txtcant.Text;
            p = "Milanesa";
            v = 550;
            tbllista.Rows.Add(i + "", c, p, v);
            i = i + 1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


}