using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Docente : Persona
    {
        #region Atributos
        private string carrera;
        private long legajo;
        #endregion
        #region Propiedades
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public long Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        #endregion
        #region Constructor
        public Docente()
        {
        }
        public Docente(string Nom, long DU, DateTime FNac, char S, string Carr, long Leg) : base(Nom, DU, FNac, S)
        {
            Carrera = Carr;
            Legajo = Leg;
        }
        #endregion
    }
}
