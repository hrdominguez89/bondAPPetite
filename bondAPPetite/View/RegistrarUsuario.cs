using bondAPPetite.DAL;
using bondAPPetite.Entity;
using bondAPPetite.View;
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

namespace bondAPPetite
{
    public partial class RegistroUsuario : Form
    {
        private ConnectionDB con = new ConnectionDB();

        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.registroUsuario(this.textBoxNombre.Text, this.textBoxEmail.Text, this.textBoxPassword.Text, this.textBoxTelefono.Text, this.textBoxDni.Text, Roles.Admin);
        }

        public void registroUsuario(string nombre, string email, string password, string telefono, string dni, Roles rol_id)
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

                if (dt.Rows.Count == 2)
                {
                    //si existe cuenta arrojo exception 
                    throw new Exception("Su cuenta ya se encuentra registrada");
                }

                Usuario usuario = new Usuario(nombre, email, rol_id);

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
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error al registrar: " + e.Message);
            }
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
