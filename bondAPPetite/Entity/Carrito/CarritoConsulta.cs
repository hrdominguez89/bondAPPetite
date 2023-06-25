using bondAPPetite.DAL;
using bondAPPetite.Entity.Categoria;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bondAPPetite.Entity.Carrito
{

    internal class CarritoConsulta
    {
        private ConnectionDB connectionDB;
        private Carrito carrito;
        private List<Carrito> lCarrito = new List<Carrito>();

        public CarritoConsulta()
        {
            connectionDB = new ConnectionDB();
        }

        internal List<Carrito> getCarrito(int cliente_id)
        {
            string q = "SELECT * FROM Carrito where cliente_id = "+ cliente_id;
            try
            {
                connectionDB.abrir();
                SqlCommand sqlCommand = new SqlCommand(q, connectionDB.connectionSql);
                SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count >= 1)
                {

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Carrito carrito = new Carrito();
                        carrito.id = int.Parse(dt.Rows[i]["id"].ToString());
                        carrito.producto_id = int.Parse(dt.Rows[i]["producto_id"].ToString());
                        carrito.producto_nombre = dt.Rows[i]["producto_nombre"].ToString();
                        carrito.cantidad = int.Parse(dt.Rows[i]["cantidad"].ToString());
                        carrito.precio = float.Parse(dt.Rows[i]["precio"].ToString());
                        carrito.estado_id = int.Parse(dt.Rows[i]["cantidad"].ToString());
                        carrito.cliente_id = int.Parse(dt.Rows[i]["cliente_id"].ToString());
                        lCarrito.Add(carrito);
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }

            return lCarrito;
        }

        internal bool agregarAlCarrito(Carrito carrito)
        {
            connectionDB.abrir();
            string q = "INSERT INTO Carrito (producto_id, cantidad, precio,estado_id,cliente_id,producto_nombre) VALUES (@producto_id, @cantidad, @precio,@estado_id,@cliente_id,@producto_nombre)";
            SqlCommand sqlCommand = new SqlCommand(q, connectionDB.connectionSql);
            sqlCommand.Parameters.AddWithValue("producto_id", carrito.producto_id);
            sqlCommand.Parameters.AddWithValue("cantidad", carrito.cantidad);
            sqlCommand.Parameters.AddWithValue("precio", carrito.precio);
            sqlCommand.Parameters.AddWithValue("estado_id", carrito.estado_id);
            sqlCommand.Parameters.AddWithValue("cliente_id", carrito.cliente_id);
            sqlCommand.Parameters.AddWithValue("producto_nombre", carrito.producto_nombre);

            //Ejecuto la query
            return sqlCommand.ExecuteNonQuery() > 0;
        }
    }
}
