using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Desarrollo_de_Sistemas.Models;
using Proyecto_Desarrollo_de_Sistemas.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Desarrollo_de_Sistemas.Controllers
{
    public class PerfilController : Controller
    {
        public static usuario usuario = new usuario();

        // GET: PerfilController
        [HttpGet]
        public ActionResult Index(int uusuario)
        {
            //quitar esto
            //uusuario = 1;
            //quitar esto

            usuario = Inicio.ObtenerUsuario(1);
            capaDatos.tablamain = capaDatos.Consulta(uusuario);
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Index(usuario objUsuario)
        {
            DataTable tablaraw = new DataTable();
            tablaraw = capaDatos.tablamain;
            return View();
        }

        // GET: PerfilController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PerfilController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PerfilController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PerfilController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PerfilController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PerfilController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PerfilController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
