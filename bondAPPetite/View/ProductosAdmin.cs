﻿using System;
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
using bondAPPetite.Entity.Producto;

namespace bondAPPetite.View
{
    public partial class ProductosAdmin : Form
    {

        private List<Producto> mProductos;
        private ProductoConsultas mProductoConsultas;

        public ProductosAdmin()
        {
            InitializeComponent();
            mProductos = new List<Producto>();
            mProductoConsultas = new ProductoConsultas();
            cargarProductos();
        }

        private void cargarProductos(string filtro = "")
        {
            //dgv= data grid view
            dgvProductos.Rows.Clear();
            dgvProductos.Refresh();
            mProductos.Clear();
            mProductos = mProductoConsultas.getProductos(filtro);
            
            for(int i = 0; i < mProductos.Count; i++)
            {
                dgvProductos.RowTemplate.Height = 50;
                dgvProductos.Rows.Add(
                    mProductos[i].id,
                    mProductos[i].cateogiria_id,
                    mProductos[i].nombre,
                    mProductos[i].precio,
                    mProductos[i].descripcion
                    //Image.FromStream(new MemoryStream(mProductos[i].imagen))
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
                MessageBox.Show("Ingrese el Precio");
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

            /*
            if (mProductoConsultas.agregarProducto(mProducto))
            {
                MessageBox.Show("Producto agregado");
                cargarProductos();
            }*/
        }

        private void cargarDatosProducto()
        {
            /*mProducto.nombre = textNombre.Text.Trim();
            mProducto.precio = float.Parse(textPrecio.Text.Trim());
            mProducto.descripcion = textDescripcion.Text.Trim();
            mProducto.imagen = ImageToByteArray(pictureBoxProducto.Image);*/
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
    }
}