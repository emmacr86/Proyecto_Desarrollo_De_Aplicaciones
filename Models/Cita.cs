using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Desarrollo_de_Sistemas.Models
{
    public class Cita
    {
        public int id { get; set; }

        public int id_usuario { get; set; }

        public int id_colaborador { get; set; }

        public int id_factura { get; set; }

        public String estado { get; set; }

        public DateTime fecha { get; set; }

    }
}
