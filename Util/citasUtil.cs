using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Proyecto_Desarrollo_de_Sistemas.Models;

namespace Proyecto_Desarrollo_de_Sistemas.Util
{
    public class citasUtil
    {

        public static DataSet SelectCitas(int identificacion)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(local); Initial Catalog=proyecto_desarrollo; Integrated Security=true");
            SqlCommand comando = new SqlCommand("select c.id, c.idUsuario, c.fecha, c.estado, f.totalNeto, " +
                                                "t.nombre, (u.nombre + ' ' + u.apellido1) as Colaborador from Cita c " +
                                                "Inner join Factura f on c.idFactura = f.id Inner join Trabajo t on f.idTrabajo = t.id " +
                                                "Inner join Usuario u on c.idColaborador = u.id where c.idUsuario = " + identificacion, conexion);
            conexion.Open();
            DataSet tabla = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            dataAdapter.Fill(tabla);
            return tabla;
        }

        //public static cita ObtenerCitas(int identificacion)
        //{
        //    DataSet ds = SelectCitas(identificacion);
        //    DataTable tabla = ds.Tables[0];
        //    int cantidadCitas = tabla.Rows.Count;
        //    cita[,] citas = new cita[cantidadCitas, 7];
        //}
    }
}
