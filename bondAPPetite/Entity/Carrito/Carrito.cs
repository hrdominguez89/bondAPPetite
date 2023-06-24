using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bondAPPetite.Entity.Carrito
{
    internal class Carrito
    {
        public int id { get; set; }
        public int producto_id { get; set; }
        public string producto_nombre { get; set; }
        public int cantidad { get; set; }
        public float precio { get; set; }
        public int estado_id { get; set; }
        public int cliente_id { get; set; }

    }
}
