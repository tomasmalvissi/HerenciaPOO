using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Clases;

namespace Datos
{
    class DatosAlumno : DatosConexionDB
    {
        public int ABMAlum(string accion, Alumno objalu)
        {
            int resultado = 0;
            string orden = "";

            if (accion == "Alta")
            {
                orden = "insert into Docente values ('" + objalu.Nombre + ",'" + objalu.DNI + ",'" + objalu.FechaNac + ",'" + objalu.Sexo + ",'" + objalu.Carrera + ",'" + objalu.Legajo + "');";
            }

            return resultado;
        }
    }
}
