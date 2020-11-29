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

        public int id_trabajo { get; set; }

        public DateTime fecha { get; set; }

        public decimal totalBruto { get; set; }

        public decimal impuesto { get; set; }

        public decimal totalNeto { get; set; }

    }
}
