using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Desarrollo_de_Sistemas.Models;
using Proyecto_Desarrollo_de_Sistemas.Util;

namespace Proyecto_Desarrollo_de_Sistemas.Controllers
{
    public class LoginController : Controller
    {
        public static usuario usuario = new usuario();
        // GET: LoginController
        public ActionResult Index()
        {
            //usuario = Inicio.ObtenerUsuario(1);
            return View();
        }

        [HttpPost]
        public ActionResult Validate(usuario user)
        {
            usuario = new usuario();
            DataSet ds = Inicio.SelectUsuariosClientes();
            DataTable tabla = ds.Tables[0];
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                string correo = tabla.Rows[i][4].ToString();
                string pass = tabla.Rows[i][5].ToString();

                if (user.correo.Equals(correo) && user.contrasena.Equals(pass)) {

                    usuario.id = (int)tabla.Rows[i][0];
                    usuario.nombre = tabla.Rows[i][1].ToString();
                    usuario.apellido1 = tabla.Rows[i][2].ToString();
                    usuario.apellido2 = tabla.Rows[i][3].ToString();
                    usuario.correo = tabla.Rows[i][4].ToString();
                    usuario.contrasena = tabla.Rows[i][5].ToString();
                    usuario.telefono = (int)tabla.Rows[i][6];
                    usuario.direccion = tabla.Rows[i][7].ToString();
                    usuario.latitud = (decimal)tabla.Rows[i][8];
                    usuario.longitud = (decimal)tabla.Rows[i][9];
                    usuario.nacimiento = (DateTime)tabla.Rows[i][10];
                    usuario.fecha_registro = (DateTime)tabla.Rows[i][11];
                    usuario.tipo_usuario = (String)tabla.Rows[i][12];
                    usuario.estado = Convert.ToBoolean(tabla.Rows[i][13]);

                }
               }

            if (!String.IsNullOrEmpty(usuario.nombre))
            {
                //usuario = Inicio.ObtenerUsuario(user.id);
                return RedirectToAction("Index", "Inicio", usuario);

            }
            else {
                ViewBag.error = "Los datos no coinciden con ningun usuario";  
                return RedirectToAction("Index", "Login");
            }
                
            
        }

        private ActionResult View(string v1, string v2, usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
