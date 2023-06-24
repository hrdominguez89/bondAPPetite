using bondAPPetite.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace bondAPPetite.Entity.Producto
{
    internal class ProductoConsultas
    {
        private ConnectionDB connectionDB;

        private List<Producto> mProductos = new List<Producto>();

        public ProductoConsultas()
        {
            connectionDB = new ConnectionDB();
        }

        internal bool agregarProducto(Producto mProducto)
        {
            string q = "INSERT INTO Productos (nombre, descripcion, categoria_id,precio,imagen) VALUES (@nombre,@descripcion,@categoria_id,@precio,@imagen)";
            SqlCommand sqlCommand = new SqlCommand(q, connectionDB.connectionSql);
            sqlCommand.Parameters.AddWithValue("nombre", mProducto.nombre);
            sqlCommand.Parameters.AddWithValue("descripcion", mProducto.descripcion);
            sqlCommand.Parameters.AddWithValue("categoria_id", mProducto.categoria_id);
            sqlCommand.Parameters.AddWithValue("precio", mProducto.precio);
            sqlCommand.Parameters.AddWithValue("imagen", mProducto.imagen);
            //Ejecuto la query
            return sqlCommand.ExecuteNonQuery()>0;
        }

        internal List<Producto> getProductos(string filtro)
        {
            string q = "SELECT * FROM Productos";
            try
            {
                
                if(filtro != "")
                {
                    q += " WHERE " +
                        "id LIKE '%" + filtro + "%' OR " +
                        "nombre LIKE '%" + filtro + "%' OR " +
                        "descripcion LIKE '%" + filtro + "%';";
                }
                connectionDB.abrir();
                SqlCommand sqlCommand = new SqlCommand(q, connectionDB.connectionSql);
                SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count >= 1)
                {

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Producto mProducto = new Producto();
                        mProducto.id = int.Parse(dt.Rows[i]["id"].ToString());
                        mProducto.nombre = dt.Rows[i]["nombre"].ToString();
                        mProducto.descripcion = dt.Rows[i]["descripcion"].ToString();
                        mProducto.categoria_id = int.Parse(dt.Rows[i]["categoria_id"].ToString());
                        mProducto.precio = float.Parse(dt.Rows[i]["precio"].ToString());
                        mProducto.imagen = (byte[])dt.Rows[i]["imagen"];
                        mProductos.Add(mProducto);
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }

            return mProductos;
        }
    }
}
