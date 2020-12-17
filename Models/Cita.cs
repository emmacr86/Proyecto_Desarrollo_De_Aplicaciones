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

        public int idUsuario { get; set; }

        public DateTime fecha { get; set; }

        public string estado { get; set; }

        public decimal totalNeto { get; set; }

        public string trabajo { get; set; }

        public string nombreColaborador { get; set; }

        

    }
}

