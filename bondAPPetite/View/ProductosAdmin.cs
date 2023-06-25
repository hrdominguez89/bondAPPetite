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
using bondAPPetite.Entity;

namespace bondAPPetite.View
{
    public partial class ProductosAdmin : Form
    {

        private List<Producto> mProductos;
        private ProductoConsultas mProductoConsultas;
        private Producto mProducto;
        private Usuario usuario;

        public ProductosAdmin(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
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
            mProducto.id = getIdIfExist();
            mProducto.categoria_id = (int)comboCategoria.SelectedValue;
            mProducto.nombre = textNombre.Text.Trim();
            mProducto.precio = float.Parse(textPrecio.Text.Trim());
            mProducto.descripcion = textDescripcion.Text.Trim();
            mProducto.imagen = ImageToByteArray(pbImagen.Image);
        }

        private int getIdIfExist()
        {
            if (!textId.Text.Trim().Equals(""))
            {
                if(int.TryParse(textId.Text.Trim(), out int id))
                {
                    return id;
                }

            }
            return -1;
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
            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
            textId.Text = Convert.ToString(fila.Cells["id"].Value);
            textNombre.Text = Convert.ToString(fila.Cells["nombre"].Value);
            textPrecio.Text = Convert.ToString(fila.Cells["precio"].Value);
            textDescripcion.Text = Convert.ToString(fila.Cells["descripcion"].Value);


            MemoryStream memoryStream = new MemoryStream();

            Bitmap bitmap = (Bitmap)dgvProductos.CurrentRow.Cells["imagen"].Value;
            bitmap.Save(memoryStream, ImageFormat.Png);
            pbImagen.Image = Image.FromStream(memoryStream);

            int categoriaId;
            if (int.TryParse(Convert.ToString(fila.Cells["categoria"].Value), out categoriaId))
            {
                comboCategoria.SelectedValue = categoriaId;
            }

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

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarProductos(textBuscar.Text.Trim());
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }

            cargarDatosProducto();


            if (mProductoConsultas.modificarProducto(mProducto))
            {
                MessageBox.Show("Producto modificado");
                cargarProductos();
                limpiarCampos();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void textPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCategoria_Click(object sender, EventArgs e)
        {

        }

        private void labelDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void labelPrecio_Click(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void textId_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbImagen_Click(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdmin menuAdmin = new MenuAdmin(usuario);
            menuAdmin.Show();
        }
    }
}
