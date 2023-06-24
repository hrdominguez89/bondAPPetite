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
using bondAPPetite;
using bondAPPetite.DAL;
using bondAPPetite.View;
using bondAPPetite.Entity;
using Microsoft.Win32;




//Login
namespace bondAPPetite.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private ConnectionDB con = new ConnectionDB();

        public void loguear(string email, string password)
        {
            try
            {
                //Abro conexión
                this.con.abrir();
                //escribo la consulta
                SqlCommand cmd = new SqlCommand("Select top(1) email, rol_id,nombre FROM Usuario WHERE email = @email and password = @password", this.con.connectionSql);
                //Agrrego los parametros de busqueda
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("password", password);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();

                    if (dt.Rows[0][1].ToString() == "1")
                    {
                        //new UsuarioAdmin(dt.Rows[0][0].ToString()).Show();
                       MenuCliente menuCliente = new MenuCliente(new Usuario(dt.Rows[0][2].ToString(), dt.Rows[0][0].ToString(), Roles.Cliente));
                        menuCliente.Show();
                        menuCliente.StartPosition = FormStartPosition.Manual;
                        menuCliente.Location = this.Location;
                        menuCliente.Show();
                    }

                    else if (dt.Rows[0][1].ToString() == "2")//
                    {
                        new MenuAdmin(new Usuario(dt.Rows[0][2].ToString(), dt.Rows[0][0].ToString(), Roles.Admin)).Show();
                    }

                }
                else
                {
                    MessageBox.Show("Email y/o contraseña incorrecta");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.StartPosition = FormStartPosition.Manual;
            register.Location = this.Location;
            register.Size = this.Size;
            register.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loguear(this.textBox3.Text, this.textBox1.Text);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


    }
}

