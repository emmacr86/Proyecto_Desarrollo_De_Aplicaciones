using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Desarrollo_de_Sistemas.Util
{
    public class StatusFunctions
    {
        public int InsertarStatus(string nombre)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(local);Initial Catalog=proyecto_desarrollo;Integrated Security=True");
            SqlCommand comando = new SqlCommand("Insert Into status(nombre)Values('"
            + nombre + "')", conexion);
            conexion.Open();
            return comando.ExecuteNonQuery();
        }

        public DataSet TablaStatus()
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(local);Initial Catalog=proyecto_desarrollo;Integrated Security=True");
            SqlCommand comando = new SqlCommand("Select * FROM status", conexion);
            DataSet tabla = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabla);
            return tabla;
        }

    }
}
