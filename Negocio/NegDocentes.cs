using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Datos;
using Clases;

namespace Negocio
{
    public class NegDocentes
    {
        DatosDocente objdatdoc = new DatosDocente();
        public int ABMDoc(string accion, Docente objDoc)
        {
            return objdatdoc.ABMDoc(accion, objDoc);
        }
    }
}
