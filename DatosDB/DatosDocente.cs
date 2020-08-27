using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Clases;

namespace Datos
{
    public class DatosDocente : DatosConexionDB
    {
        public int ABMDoc(string accion, Docente objdoc) 
        {
            int resultado = 0;
            string orden = "";

            if (accion == "Alta")
            {
                orden = "insert into Docente " +
                                          "values ("
                                            + "'" + objdoc.Nombre + "',"
                                            + "'" + objdoc.DNI + "',"
                                            + "'" + objdoc.FechaNac + "',"
                                            + "'" + objdoc.Sexo + "',"
                                            + "'" + objdoc.Carrera + "',"
                                            + "'" + objdoc.Legajo + "'"
                                            + ");";
            }

            SqlCommand sqlcmd = new SqlCommand(orden, conexion);
            try
            {
                AbrirConex();
                resultado = sqlcmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de moficiar los registros de Docente", e);
            }
            finally
            {
                CerrarConex();
                sqlcmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoDocente(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos") //ver id where
                orden = "select * from Docente where Id = " + int.Parse(cual) + ";";
            else
                orden = "select * from Docente;";
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
                throw new Exception("Error al listar Docentes", e);
            }
            finally
            {
                CerrarConex();
                sqlcmd.Dispose();
            }
            return ds;
        }
        public void hola()
        {

        }
    }
}
