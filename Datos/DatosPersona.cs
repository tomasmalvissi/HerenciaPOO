using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Clases;

namespace Datos
{
    class DatosPersona : DatosConexionDB
    {
        public int ABMPer(string accion, Persona objper)
        {
            int resultado = 0;
            string orden = "";

            if (accion == "Alta")
            {
                orden = "insert into Docente values ('" + objper.Nombre + ",'" + objper.DNI + ",'" + objper.FechaNac + ",'" + objper.Sexo + "');";
            }

            return resultado;
        }
    }
}
