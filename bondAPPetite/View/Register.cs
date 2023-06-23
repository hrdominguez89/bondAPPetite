using bondAPPetite.DAL;
using bondAPPetite.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bondAPPetite.View
{
    public partial class Register : Form
    {

        private ConnectionDB con = new ConnectionDB();

        public Register()
        {
            InitializeComponent();
        }

        //Boton login
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        //Boton registrar
        private void button1_Click(object sender, EventArgs e)
        {
            this.registerUser(this.textBoxNombre.Text, this.textBoxEmail.Text, this.textBoxPassword.Text, this.textBoxTelefono.Text, this.textBoxDni.Text,Roles.Cliente);
        }

        public void registerUser(string nombre,string email,string password, string telefono, string dni, Roles rol_id)
        {
            try
            {
                //Abro conexión
                this.con.abrir();
                //escribo la consulta
                SqlCommand cmd = new SqlCommand("Select top(1) id FROM Usuario WHERE email = @email OR dni = @dni", this.con.connectionSql);
                //Agrrego los parametros de busqueda
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("dni", dni);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    //si existe cuenta arrojo exception 
                    throw new Exception("Su cuenta ya se encuentra registrada");
                }

                Usuario usuario = new Usuario(nombre,email,rol_id);

               //Genero query para insert usuario
                cmd = new SqlCommand("INSERT INTO Usuario (nombre,email,password,rol_id,fechaDeRegistro,activo,telefono,dni) VALUES (@nombre,@email,@password,@rol_id,@fechaDeRegistro,@activo,@telefono,@dni)", this.con.connectionSql);
                //Agrego parametros
                cmd.Parameters.AddWithValue("nombre", usuario.nombre);
                cmd.Parameters.AddWithValue("email", usuario.email);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Parameters.AddWithValue("rol_id", usuario.rol_id);
                cmd.Parameters.AddWithValue("fechaDeRegistro", DateTime.Now);
                cmd.Parameters.AddWithValue("activo", true);
                cmd.Parameters.AddWithValue("telefono", telefono);
                cmd.Parameters.AddWithValue("dni", dni);
                //Ejecuto la query
                cmd.ExecuteNonQuery();
                //mensaje ok, y vuelvo al login para poder iniciar sesion
                MessageBox.Show("Usuario registrado, por favor inicie sesión");
                this.Hide();
                new Login().Show();
            }
            catch(Exception e)
            {
                MessageBox.Show("Hubo un error al registrar: " + e.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
