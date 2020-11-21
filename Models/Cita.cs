using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Desarrollo_de_Sistemas.Models
{
    public class cita
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un servicio")]
        public int id_servicio { get; set; }

        public int id_usuario { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una fecha")]
        public DateTime fecha { get; set; }

        public TimeSpan hora { get; set; }

        public int id_status { get; set; }

        public int id_colaborador { get; set; }

    }
}
