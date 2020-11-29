using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Desarrollo_de_Sistemas.Models
{
    public class Trabajo
    {
        public int id { get; set; }

        public int id_servicio { get; set; }

        public String nombre { get; set; }

        public String detalle { get; set; }

        public decimal costo { get; set; }
    }
}
