using bondAPPetite.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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

        internal List<Producto> getProductos(string filtro)
        {
            string q = "SELECT * FROM Productos";
            SqlDataReader mReader = null;
            try
            {
                
                if(filtro != "")
                {
                    q += "WHERE " +
                        "id LIKE '%" + filtro + "%' OR " +
                        "nombre LIKE '%" + filtro + "%' OR " +
                        "precio LIKE '%" + filtro + "%' OR " +
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
                        mProducto.id = int.Parse(dt.Rows[i][0].ToString());
                        mProducto.nombre = dt.Rows[i][1].ToString();
                        mProducto.descripcion = dt.Rows[i][2].ToString();
                        mProducto.cateogiria_id = int.Parse(dt.Rows[i][3].ToString());
                        mProducto.precio = float.Parse(dt.Rows[i][4].ToString());
                        //mProducto.imagen = (byte[])mReader.GetValue(5);
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
