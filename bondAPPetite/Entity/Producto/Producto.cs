using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bondAPPetite.Entity.Producto
{
    internal class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public float precio { get; set; }
        public string descripcion { get; set; }
        public int cateogiria_id { get; set; }
        //public byte[] imagen { get; set; }
    }
}
