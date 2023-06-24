using bondAPPetite.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bondAPPetite.Entity.Categoria
{
    internal class CategoriaConsulta
    {
        private ConnectionDB connectionDB;

        private List<Categoria> mCategorias = new List<Categoria>();

        private Categoria mCategoria = new Categoria();

        public CategoriaConsulta()
        {
            connectionDB = new ConnectionDB();
        }

        internal List<Categoria> getCategorias()
        {
            string q = "SELECT * FROM Categoria";
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
                        Categoria mCategoria = new Categoria();
                        mCategoria.id = int.Parse(dt.Rows[i]["id"].ToString());
                        mCategoria.descripcion = dt.Rows[i]["descripcion"].ToString();
                        mCategorias.Add(mCategoria);
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }

            return mCategorias;
        }

        internal Categoria getCategoriaById(int categoria_id)
        {
            string q = "SELECT * FROM Categoria where id = "+ categoria_id;
            try
            {
                connectionDB.abrir();
                SqlCommand sqlCommand = new SqlCommand(q, connectionDB.connectionSql);
                SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                        this.mCategoria.id = int.Parse(dt.Rows[0]["id"].ToString());
                        this.mCategoria.descripcion = dt.Rows[0]["descripcion"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Hubo un error: " + ex.Message);
            }

            return this.mCategoria;
        }
    }
}
