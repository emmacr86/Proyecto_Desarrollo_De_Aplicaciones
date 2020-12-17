using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Desarrollo_de_Sistemas.Models;
using Proyecto_Desarrollo_de_Sistemas.Util;

namespace Proyecto_Desarrollo_de_Sistemas.Controllers
{
    public class RegistroController : Controller
    {
        public static usuario user = new usuario();
        // GET: RegistroController
        public ActionResult Index()
        {
            //usuario = Inicio.ObtenerUsuario(0);
            return View();
        }

        [HttpPost]
        public ActionResult Create(usuario user)
        {
            try
            {
                ViewBag.error = "";
                user.nacimiento = DateTime.Now;
                user.fecha_registro = DateTime.Now;
                user.tipo_usuario = "cliente";
                user.telefono = 88887777; 
                user.estado = true; 
                Inicio.InsertarUsuarioNuevo(user.nombre, user.apellido1, user.apellido2, user.correo, user.contrasena, user.telefono, user.direccion, user.latitud, user.longitud, user.nacimiento, user.fecha_registro, user.tipo_usuario, user.estado);

                return RedirectToAction("Index", "Login");
        }
           catch
           {
               ViewBag.error = "Sucedio un error al crear el usuario"; 
               return RedirectToAction("Index", "Registro");
    }



}
    }
}

