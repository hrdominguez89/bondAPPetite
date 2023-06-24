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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;



namespace prueba_datagrid
{
    public partial class Lista_de_compras : Form
    {
        int i = 1;
        int tipoDePago_id = 1;
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=bondAPPetite;Integrated Security=True");


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

            //Llamamos al método para sumar el total de la lista
            Sumacolumna();

        }

        //Método que suma el total de la lista de compras
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
            string c, p;
            decimal v;
            c = txtcant.Text;
            p = "Milanesa";
            decimal cantidad = Convert.ToDecimal(c);
            v = (cantidad * 550);
            tbllista.Rows.Add(i + "", c, p, v);
            i = i + 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        //boton de comprar
        private void button5_Click(object sender, EventArgs e)
        {
            //Llamamos al método para sumar el total de la lista apretando el boton comprar

            Sumacolumna();
        }

        //botón ir al pago
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand Iralpago = new SqlCommand("Insert Into Ordenes values (@cliente_id, @fecha, @total, @tipoDePago_id, @estado_id)", con);
            SqlCommand Iralpago2 = new SqlCommand("Insert Into Ordenes_Productos values (@orden_id, @producto_id, @cantidad)", con);
            con.Open();
            float total = Convert.ToSingle(labelsumar.Text);
            int cliente = 1;
            try
            {
                foreach (DataGridViewRow row in tbllista.Rows)
                {
                    Iralpago.Parameters.Clear();
                    Iralpago.Parameters.AddWithValue("@cliente_id", cliente);
                    Iralpago.Parameters.AddWithValue("@fecha", DateTime.Now);
                    Iralpago.Parameters.AddWithValue("@total", total);
                    Iralpago.Parameters.AddWithValue("@tipoDePago_id", 1);
                    Iralpago.Parameters.AddWithValue("@estado_id", 1);
                    Iralpago.Parameters.Clear();
                    Iralpago2.Parameters.AddWithValue("@orden_id", 1);
                    Iralpago2.Parameters.AddWithValue("@producto_id", 1);
                    Iralpago2.Parameters.AddWithValue("@cantidad", Convert.ToString(row.Cells["Cantidad"].Value));

                    Iralpago.ExecuteNonQuery();
                    Iralpago2.ExecuteNonQuery();

                    MessageBox.Show("Datos agregados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void textBoxmedio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxmedio.Text == "Efectivo")
                {
                    tipoDePago_id = 1;
                }
                else if (textBoxmedio.Text == "Tarjeta De Credito")
                {
                    tipoDePago_id = 2;
                }
                else if (textBoxmedio.Text == "Tarjeta De Debito")
                {
                    tipoDePago_id = 3;
                }

            }
            catch
            {
                MessageBox.Show("Ingrese un medio de pago valido: Efectivo,Tarjeta De Credito o Tarjeta De Debito");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Botón imprimir 
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = "Factura.pdf ";
            guardar.ShowDialog();

            string paginahtml_texto = Properties.Resources.Facturapdf.ToString();

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    //lo guarda en un archivo de memoria (stream)
                    PdfWriter writer = PdfWriter.GetInstance(pdfdoc,stream);
                    pdfdoc.Open();
                    pdfdoc.Add(new Phrase(""));
                    //para que pueda leer el html e insertar en el pdf
                    using (StringReader sr = new StringReader(paginahtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer,pdfdoc,sr);

                    }

                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }
    }
}