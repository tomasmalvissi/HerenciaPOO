using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Clases;

namespace Datos
{
    public class DatosPersona : DatosConexionDB
    {
        public int ABMPer(string accion, Persona objper)
        {
            int resultado = 0;
            string orden = "";

            if (accion == "Alta")
            {
                orden = "insert into Persona values ('" + objper.Nombre + ",'" + objper.DNI + ",'" + objper.FechaNac + ",'" + objper.Sexo + "');";
            }
            if (accion == "Modificar") //revisar where
                orden = "update Persona set Nombre='" + objper.Nombre + "', DNI='" + objper.DNI + "', FechaNac='" + objper.FechaNac + "', Sexo='" + objper.Sexo + "where Id='" + ";";

            SqlCommand sqlcmd = new SqlCommand(orden,conexion);
            try
            {
                AbrirConex();
                resultado = sqlcmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de moficiar los registros de Persona", e);
            }
            finally
            {
                CerrarConex();
                sqlcmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoPersona(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos") //ver id where
                orden = "select * from Persona where Id = " + int.Parse(cual) + ";";
            else
                orden = "select * from Persona;";
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
                throw new Exception("Error al listar Personas", e);
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
