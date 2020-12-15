using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Desarrollo_de_Sistemas.Models
{
    public class usuario
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Digite su cédula")]
        public int cedula { get; set; }

        [Required(ErrorMessage = "Digite su contraseña")]
        public string password { get; set; }

        [Required(ErrorMessage = "Digite su nombre")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Digite su primer apellido")]
        public string apellido1 { get; set; }

        [Required(ErrorMessage = "Digite su segundo apellido")]
        public string apellido2 { get; set; }

        [Required(ErrorMessage = "Seleccione su edad")]
        public DateTime nacimiento { get; set; }

        [Required(ErrorMessage = "Ingrese su telefono")]
        public int telefono { get; set; }

        [Required(ErrorMessage = "Ingrese su domicilio")]
        public string direccion { get; set; }

        public decimal latitud { get; set; }

        public decimal longitud { get; set; }
     
    }
}
