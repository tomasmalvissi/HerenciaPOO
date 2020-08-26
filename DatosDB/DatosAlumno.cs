using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Clases;

namespace Datos
{
    public class DatosAlumno : DatosConexionDB
    {
        public int ABMAlum(string accion, Alumno objalu)
        {
            int resultado = 0;
            string orden = "";

            if (accion == "Alta")
            {
                orden = "insert into Alumno values ('" + objalu.Nombre + ",'" + objalu.DNI + ",'" + objalu.FechaNac + ",'" + objalu.Sexo + ",'" + objalu.Carrera + ",'" + objalu.Legajo + "');";
            }

            SqlCommand sqlcmd = new SqlCommand(orden, conexion);
            try
            {
                AbrirConex();
                resultado = sqlcmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de moficiar los registros de Alumno", e);
            }
            finally
            {
                CerrarConex();
                sqlcmd.Dispose();
            }
            return resultado;
        }


        public DataSet listadoAlumno(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos") //ver id where
                orden = "select * from Alumno where Id = " + int.Parse(cual) + ";";
            else
                orden = "select * from Alumno;";
            SqlCommand sqlcmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                AbrirConex();
                sqlcmd.ExecuteNonQuery();
                da.SelectCommand = sqlcmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Alumnos", e);
            }
            finally
            {
                CerrarConex();
                sqlcmd.Dispose();
            }
            return ds;
        }
    }
}
