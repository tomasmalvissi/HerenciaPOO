using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Clases;

namespace Datos
{
    class DatosDocente : DatosConexionDB
    {
        public int ABMDoc(string accion, Docente objdoc) 
        {
            int resultado = 0;
            string orden = "";

            if (accion == "Alta")
            {
                orden = "insert into Docente values ('" + objdoc.Nombre + ",'" + objdoc.DNI + ",'" + objdoc.FechaNac + ",'" + objdoc.Sexo + ",'" + objdoc.Carrera + ",'" + objdoc.Legajo + "');";
            }

            return resultado;
        }
    }
}
