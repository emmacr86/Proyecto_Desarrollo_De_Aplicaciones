using Proyecto_Desarrollo_de_Sistemas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Desarrollo_de_Sistemas.Util
{
    interface Inicio
    {
        public static DataSet SelectUsuario(int identificacion)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(local);Initial Catalog=proyecto_desarrollo;Integrated Security=True");
            SqlCommand comando = new SqlCommand("SELECT * FROM Usuario WHERE id =" + identificacion, conexion);
            conexion.Open();
            DataSet tabla = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            dataAdapter.Fill(tabla);
            return tabla;
        }

        public static usuario ObtenerUsuario(int identificacion) 
        {
            usuario user = new usuario();
            DataSet ds = SelectUsuario(identificacion);
            DataTable tabla = ds.Tables[0];
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                user.id = (int) tabla.Rows[i][0];
                user.nombre = tabla.Rows[i][1].ToString();
                user.apellido1 = tabla.Rows[i][2].ToString();
                user.apellido2 = tabla.Rows[i][3].ToString();
                user.correo = tabla.Rows[i][4].ToString();
                user.contrasena = tabla.Rows[i][5].ToString();
                user.telefono = (int)tabla.Rows[i][6];
                user.direccion = tabla.Rows[i][7].ToString();
                user.latitud =(decimal) tabla.Rows[i][8];
                user.longitud = (decimal) tabla.Rows[i][9];
                user.nacimiento = (DateTime)tabla.Rows[i][10];
                user.fecha_registro = (DateTime)tabla.Rows[i][11];
                user.tipo_usuario = (String)tabla.Rows[i][12]; 
                user.estado = Convert.ToBoolean(tabla.Rows[i][13]);
            }

            return user; 
        }

        public static DataSet SelectMarido(int identificacion)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(local);Initial Catalog=proyecto_desarrollo;Integrated Security=True");
            SqlCommand comando = new SqlCommand("SELECT * FROM Usuario WHERE id =" + identificacion + "AND tipo_usuario = marido", conexion);
            conexion.Open();
            DataSet tabla = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            dataAdapter.Fill(tabla);
            return tabla;
        }

        public static usuario ObtenerMarido(int identificacion)
        {
            usuario user = new usuario();
            DataSet ds = SelectMarido(identificacion);
            DataTable tabla = ds.Tables[0];
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                user.id = (int)tabla.Rows[i][0];
                user.nombre = tabla.Rows[i][1].ToString();
                user.apellido1 = tabla.Rows[i][2].ToString();
                user.apellido2 = tabla.Rows[i][3].ToString();
                user.correo = tabla.Rows[i][4].ToString();
                user.contrasena = tabla.Rows[i][5].ToString();
                user.telefono = (int)tabla.Rows[i][6];
                user.direccion = tabla.Rows[i][7].ToString();
                user.latitud = (decimal)tabla.Rows[i][8];
                user.longitud = (decimal)tabla.Rows[i][9];
                user.nacimiento = (DateTime)tabla.Rows[i][10];
                user.fecha_registro = (DateTime)tabla.Rows[i][11];
                user.tipo_usuario = (String)tabla.Rows[i][12];
                user.estado = Convert.ToBoolean(tabla.Rows[i][13]);
            }

            return user;
        }

        public static DataSet SelectServicio()
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(local);Initial Catalog=proyecto_desarrollo;Integrated Security=True");
            SqlCommand comando = new SqlCommand("SELECT * FROM Servicio", conexion);
            conexion.Open();
            DataSet tabla = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            dataAdapter.Fill(tabla);
            return tabla;
        }

        public static List<servicio> ObtenerServicio()
        {
            servicio ser = new servicio();
            DataSet ds = SelectServicio();

            var emplist = ds.Tables[0].AsEnumerable().Select(DataRow =>
            new servicio() {
                id = DataRow.Field<int>("id"),
                nombre = DataRow.Field<String>("nombre"),
                detalle = DataRow.Field<String>("detalle")
            }).ToList();


            return emplist;
        }

        public static DataSet SelectMarido()
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(local);Initial Catalog=proyecto_desarrollo;Integrated Security=True");
            SqlCommand comando = new SqlCommand("SELECT * FROM Usuario WHERE tipoUsuario = 'marido'", conexion);
            conexion.Open();
            DataSet tabla = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            dataAdapter.Fill(tabla);
            return tabla;
        }

        public static DataSet ValidarUsuarioIngresado(string correo, string contrasena)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(local);Initial Catalog=proyecto_desarrollo;Integrated Security=True");
            SqlCommand comando = new SqlCommand("SELECT * FROM Usuario WHERE correo = " + correo + " AND contrasenia = " + contrasena, conexion);
            DataSet tabla = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            dataAdapter.Fill(tabla);
            return tabla;
        }

        public static int InsertarUsuarioNuevo(string nombre, string apellidos1, string apellidos2, string correo, string contrasena, int telefono, string direccion, decimal latitud, decimal longitud, DateTime nacimiento, DateTime fecha, string tipo_usuario, Boolean estado)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(local);Initial Catalog=proyecto_desarrollo;Integrated Security=True");
            SqlCommand comando = new SqlCommand("Insert Into Usuario(nombre,apellido1,apellido2,correo,contrasenia,telefono,direccion,latitud,longitud,fechaNacimiento,fechaRegistro,tipoUsuario,estado)Values('"
            + nombre + "','" + apellidos1 + "','" + apellidos2 + "','" + correo + "','" + contrasena + "','" + telefono + "','" + direccion + "','" + latitud + "','" + longitud + "','" + nacimiento + "','" + fecha + "','" + tipo_usuario + "','" + Convert.ToInt32(estado) + "')", conexion);
            conexion.Open();
            return comando.ExecuteNonQuery();
        }

        public static DataSet SelectUsuariosClientes()
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(local);Initial Catalog=proyecto_desarrollo;Integrated Security=True");
            SqlCommand comando = new SqlCommand("SELECT * FROM Usuario", conexion);
            conexion.Open();
            DataSet tabla = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            dataAdapter.Fill(tabla);
            return tabla;
        }




    }
}
