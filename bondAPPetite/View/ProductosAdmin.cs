using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bondAPPetite.Entity.Categoria;
using bondAPPetite.DAL;
using bondAPPetite.Entity.Producto;

namespace bondAPPetite.View
{
    public partial class ProductosAdmin : Form
    {

        private List<Producto> mProductos;
        private ProductoConsultas mProductoConsultas;
        private Producto mProducto;

        public ProductosAdmin()
        {
            InitializeComponent();
            mProductos = new List<Producto>();
            mProductoConsultas = new ProductoConsultas();
            listarCategorias();
            cargarProductos();
        }

        private void listarCategorias()
        {
            comboCategoria.DataSource = new CategoriaConsulta().getCategorias();
            comboCategoria.ValueMember = "id";
            comboCategoria.DisplayMember = "descripcion";
        }

        private void cargarProductos(string filtro = "")
        {
            //dgv= data grid view
            dgvProductos.Rows.Clear();
            dgvProductos.Refresh();
            mProductos.Clear();
            mProductos = mProductoConsultas.getProductos(filtro);

            for (int i = 0; i < mProductos.Count; i++)
            {
                dgvProductos.RowTemplate.Height = 50;
                dgvProductos.Rows.Add(
                    mProductos[i].id,
                    mProductos[i].categoria_id,
                    mProductos[i].nombre,
                    mProductos[i].precio,
                    mProductos[i].descripcion,
                    mProductos[i].imagen != null ? Image.FromStream(new MemoryStream(mProductos[i].imagen)) : null
                );
            }
        }

        private bool datosCorrectos()
        {

            //Validaciones de que exista 
            if (textNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el nombre");
                return false;
            }

            if (textPrecio.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Precio");
                return false;
            }

            if (textDescripcion.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la descripción");
                return false;
            }

            if (!float.TryParse(textPrecio.Text.Trim(), out float precio))
            {
                MessageBox.Show("El formato indicado no es valido");
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }

            cargarDatosProducto();

            
            if (mProductoConsultas.agregarProducto(mProducto))
            {
                MessageBox.Show("Producto agregado");
                cargarProductos();
                limpiarCampos();
            }
        }

        private void limpiarCampos()
        {

            textNombre.Text = "";
            textPrecio.Text = "";
            textDescripcion.Text = "";
        }

        private void cargarDatosProducto()
        {
            mProducto = new Producto();
            mProducto.categoria_id = (int)comboCategoria.SelectedValue;
            mProducto.nombre = textNombre.Text.Trim();
            mProducto.precio = float.Parse(textPrecio.Text.Trim());
            mProducto.descripcion = textDescripcion.Text.Trim();
            mProducto.imagen = ImageToByteArray(pbImagen.Image);
        }

        private byte[] ImageToByteArray(Image image)
        {
            if(image == null)
                return null;

            MemoryStream mMemoryStream = new MemoryStream();
            image.Save(mMemoryStream, ImageFormat.Png);
            return mMemoryStream.ToArray();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar= new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes|*.jpg; *.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "seleccionar imagen";

            if(ofdSeleccionar.ShowDialog() == DialogResult.OK) 
            {
                pbImagen.Image = Image.FromFile(ofdSeleccionar.FileName);
            }

        }

        private void ProductosAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            cargarProductos(textBuscar.Text.Trim());
        }

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pbImagen.Image.Save(ms, ImageFormat.Jpeg);
            byte[] abytes= ms.ToArray();

            


        }
    }
}
