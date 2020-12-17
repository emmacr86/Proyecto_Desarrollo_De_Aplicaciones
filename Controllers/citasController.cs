using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;

using Proyecto_Desarrollo_de_Sistemas.Models;

namespace Proyecto_Desarrollo_de_Sistemas.Controllers
{
    public class citasController : Controller
    {
        public ActionResult citas()
        {
            //DataSet ds = new DataSet();
            //string constr = "Data Source=(local); Initial Catalog=proyecto_desarrollo; Integrated Security=true";
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    string query = "select c.id, c.idUsuario, c.fecha, c.estado, f.totalNeto, " +
            //                                    "t.nombre, (u.nombre + ' ' + u.apellido1) as Colaborador from Cita c " +
            //                                    "Inner join Factura f on c.idFactura = f.id Inner join Trabajo t on f.idTrabajo = t.id " +
            //                                    "Inner join Usuario u on c.idColaborador = u.id where c.idUsuario = 1";

            //    using (SqlCommand cmd = new SqlCommand(query))
            //    {
            //        cmd.Connection = con;
            //        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            //        {
            //            sda.Fill(ds);
            //        }
            //    }
            //}
            return View();  //ds
        }
    }
}
