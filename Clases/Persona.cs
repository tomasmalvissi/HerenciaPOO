using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        #region Atributos
        private string nombre;
        private long dni;
        private DateTime fechanac;
        private char sexo;
        #endregion
        #region Propiedades
        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public long DNI
        { 
            get { return dni; }
            set { dni = value; }
        }
        public DateTime FechaNac
        {
            get { return fechanac; }
            set { fechanac = value; }
        }
        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        #endregion
        #region Constructores
        public Persona()
        {

        }
        public Persona(string Nom, long DU, DateTime FNac, char S)
        {
            Nombre = Nom;
            DNI = DU;
            FechaNac = FNac;
            Sexo = S;
        }
        #endregion
        #region Metodos
        public int Edad() 
        {
            int edad;
            edad = (FechaNac.Year - DateTime.Now.Year);
            return edad;
        }
        #endregion
    }
}
