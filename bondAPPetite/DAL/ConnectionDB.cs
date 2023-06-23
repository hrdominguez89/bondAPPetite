using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bondAPPetite.DAL
{
    public class ConnectionDB
    {
        public SqlConnection connectionSql;
        //SqlCommand commandQuerySql;
        //SqlDataReader dataReaderSql;

        public ConnectionDB()
        {
            //Hago la conexión
            this.connectionSql = new SqlConnection("Data Source=.;Initial Catalog=bondAPPetite;Integrated Security=True");
        }

        public void abrir()
        {
            try
            {   //si no esta abierta la conexion la abro
                if(this.connectionSql.State == ConnectionState.Closed)
                this.connectionSql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conectó con la base de datos: " + ex.ToString());
            }
        }

        public void cerrar()
        {  //si no esta cerrada la conexion la cierro
            if (this.connectionSql.State == ConnectionState.Open)
            this.connectionSql.Close();
        }
    }
}
