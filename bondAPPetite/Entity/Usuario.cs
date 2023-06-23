using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bondAPPetite.Entity
{
    public class Usuario
    {

        public string nombre { get; set; }
        public string email {get; set; }
        public string password { get; set; }
        public DateTime fechaDeRegistro { get; set; }
        public bool activo { get; set; }
        public string telefono { get; set; }
        public string dni { get; set; }
        public Roles rol_id { get; set; }


        public Usuario(string nombre, string email, Roles rol_id)
        {
            this.nombre = nombre;
            this.email = email;
            this.rol_id = rol_id;
        }
    }

}
