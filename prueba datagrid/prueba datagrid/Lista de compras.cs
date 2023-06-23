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
    public partial class Lista_de_compras : Form
    {
        int i = 1;

        public Lista_de_compras()
        {
            InitializeComponent();
        }

        //Boton salir
        public void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //datagrid
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Botón borrar elemento
        public void btnborrarelemento_Click(object sender, EventArgs e)
        {

        }

        private void Lista_de_compras_Load(object sender, EventArgs e)
        {

            //Llamamos al método para sumar el Total
            Sumacolumna();

        }

        public void Sumacolumna()
        {
            decimal Total = 0;
            foreach (DataGridViewRow row in tbllista.Rows)
            {
                Total += Convert.ToDecimal(row.Cells["Precio"].Value);

            }

            labelsumar.Text = Total.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string c,p;
            decimal v;
            c = txtcant.Text;
            p = "Milanesa";
            decimal cantidad = Convert.ToDecimal(c);
            v = (cantidad*550);
            tbllista.Rows.Add(i + "", c, p, v);
            i = i + 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        //boton de comprar
        private void button5_Click(object sender, EventArgs e)
        {
            Sumacolumna();
        }
    }
}
