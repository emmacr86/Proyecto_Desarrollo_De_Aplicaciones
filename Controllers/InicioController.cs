using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proyecto_Desarrollo_de_Sistemas.Models;
using Proyecto_Desarrollo_de_Sistemas.Util;

namespace Proyecto_Desarrollo_de_Sistemas.Controllers
{
    public class InicioController : Controller
    {
        public static usuario usuario = new usuario();
        public static usuario marido = new usuario();
        public static Cita cita = new Cita(); 


        // GET: InicioController
        public ActionResult Index(usuario usuario)
        {
            //usuario =  Inicio.ObtenerUsuario(4);

            DataSet ds =  Inicio.SelectMarido();
            DataTable tabla = ds.Tables[0];

            int total = tabla.Rows.Count;
            Random r = new Random();
            int offset = r.Next(0, total); 

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (offset == i) {

                    ViewBag.NombreMarido = tabla.Rows[i][1].ToString();
                    ViewBag.ApellidoMarido = tabla.Rows[i][2].ToString();
                    ViewBag.Apellido2Marido = tabla.Rows[i][3].ToString();
                    ViewBag.CorreoMarido = tabla.Rows[i][4].ToString();
                    ViewBag.telefonoMarido = (int)tabla.Rows[i][6];
                    ViewBag.latitudMarido = (decimal)tabla.Rows[i][8];
                    ViewBag.longitudMarido = (decimal)tabla.Rows[i][9];
                }           
            }
            
            return View(usuario);
        }

        // GET: InicioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InicioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InicioController/Create
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

        // GET: InicioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InicioController/Edit/5
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

        // GET: InicioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InicioController/Delete/5
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
