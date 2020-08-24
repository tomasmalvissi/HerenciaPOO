using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Datos;
using Clases;

namespace Negocio
{
    public class NegAlumnos
    {
        DatosAlumno objdatalu = new DatosAlumno();
        public int ABMAlum(string accion, Alumno objAlum)
        {
            return objdatalu.ABMAlum(accion, objAlum);
        }
        public DataSet listadoalu(string cual)
        {
            return objdatalu.listadoAlumno(cual);
        }
    }
}