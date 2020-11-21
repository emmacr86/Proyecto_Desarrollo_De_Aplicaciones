using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Desarrollo_de_Sistemas.Models
{
    public class facturacion
    {
        public int id { get; set; }

        public int id_cita { get; set; }

        [Required(ErrorMessage = "Seleccione un tipo de pago")]
        public string tipo_pago { get; set; }

        public decimal iva { get; set; }

        public decimal total { get; set; }

    }
}
