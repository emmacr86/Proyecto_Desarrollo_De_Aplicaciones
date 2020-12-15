﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Desarrollo_de_Sistemas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Desarrollo_de_Sistemas.Controllers
{
    public class PerfilController : Controller
    {
        // GET: PerfilController
        [HttpGet]
        public ActionResult Index(string uusuario)
        {
            capaDatos.tablamain = capaDatos.Consulta(uusuario);
            return View();
        }

        [HttpPost]
        public ActionResult Index(usuario uusser)
        {
            DataTable tablaraw = new DataTable();
            tablaraw = capaDatos.Consulta(uusser.id);
            ViewBag.msg = "Datos Guardados";
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