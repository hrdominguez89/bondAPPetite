using bondAPPetite.Entity;
using bondAPPetite.Entity.Carrito;
using bondAPPetite.Entity.Categoria;
using bondAPPetite.Entity.Producto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bondAPPetite.View
{
    public partial class ProductoCliente : Form
    {
        private List<Producto> mProductos;
        private ProductoConsultas mProductoConsultas;
        private CategoriaConsulta mCategoriaConsulta;
        private CarritoConsulta mCarritoConsulta = new CarritoConsulta();

        private Carrito mCarrito;


        private Producto mProducto;
        private Categoria mCategoria;

        private Usuario usuario;

        public ProductoCliente(Usuario usuario,int categoria_id)
        {
            InitializeComponent();
            this.usuario = usuario;
            mProductos = new List<Producto>();
            mProductoConsultas = new ProductoConsultas();
            mCategoriaConsulta = new CategoriaConsulta();
            mCategoria = mCategoriaConsulta.getCategoriaById(categoria_id);
            labelTituloTipoProducto.Text = mCategoria.descripcion;
            cargarProductos(mCategoria.id);
        }

        private void ProductoCliente_Load(object sender, EventArgs e)
        {

        }

        private void cargarProductos(int categoria_id,string filtro = "")
        {
            //dgv= data grid view
            dgvProductos.Rows.Clear();
            dgvProductos.Refresh();
            mProductos.Clear();
            mProductos = mProductoConsultas.getProductosByCategoria(filtro,categoria_id);

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

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuCliente menuCliente = new MenuCliente(this.usuario);
            menuCliente.Show();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
            textId.Text = Convert.ToString(fila.Cells["id"].Value);
            textNombre.Text = Convert.ToString(fila.Cells["nombre"].Value);
            textPrecio.Text = Convert.ToString(fila.Cells["precio"].Value);
            textDescripcion.Text = Convert.ToString(fila.Cells["descripcion"].Value);
            textCantidad.Text = "1";


            MemoryStream memoryStream = new MemoryStream();

            Bitmap bitmap = (Bitmap)dgvProductos.CurrentRow.Cells["imagen"].Value;
            bitmap.Save(memoryStream, ImageFormat.Png);
            pbImagen.Image = Image.FromStream(memoryStream);
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarProductos(this.mCategoria.id, textBuscar.Text.Trim());
        }

        private void buttonAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }

            agregarProductosAlCarrito();


            if (mCarritoConsulta.agregarAlCarrito(mCarrito))
            {
                MessageBox.Show("Producto agregado al carrito");
                limpiarCampos();
            }
        }

        private void limpiarCampos()
        {

            textNombre.Text = "";
            textPrecio.Text = "";
            textDescripcion.Text = "";
            textId.Text = "";
            textCantidad.Text = "";
        }

        private void agregarProductosAlCarrito()
        {
            mCarrito = new Carrito();
            mCarrito.producto_id = getIdIfExist();
            mCarrito.producto_nombre = textNombre.Text.Trim();
            mCarrito.precio = float.Parse(textPrecio.Text.Trim());
            mCarrito.cantidad = int.Parse(textCantidad.Text.Trim());
            mCarrito.estado_id = 1;
            mCarrito.cliente_id = this.usuario.id;
    }

        private int getIdIfExist()
        {
            if (!textId.Text.Trim().Equals(""))
            {
                if (int.TryParse(textId.Text.Trim(), out int id))
                {
                    return id;
                }

            }
            return -1;
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
    }
}
