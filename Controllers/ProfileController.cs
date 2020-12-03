using Microsoft.AspNetCore.Mvc;
using Proyecto_Desarrollo_de_Sistemas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Desarrollo_de_Sistemas.Controllers
{
    public class ProfileController : Controller
    {
        //[HttpGet]

        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Index(usuario useer)
        //{
        //    usuario.tablamain = useer.Consulta(useer.cedula);
        //    return View();
        //}
    }
}
