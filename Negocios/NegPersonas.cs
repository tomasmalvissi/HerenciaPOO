using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Datos;
using Clases;

namespace Negocio
{
    public class NegPersonas
    {
        DatosPersona objdatper = new DatosPersona();
        public int ABMPer(string accion, Persona objPer)
        {
            return objdatper.ABMPer(accion, objPer);
        }
        public DataSet listadoper(string cual)
        {
            return objdatper.listadoPersona(cual);
        }
    }
}