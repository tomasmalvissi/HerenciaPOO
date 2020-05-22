using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Formularios
{
    public partial class FormPersona : Form
    {
        private string Nom;
        private long DNI;
        private DateTime FeNac;
        private char Sex;
        private string CarA;
        private long LegA;
        private string CarD;
        private long LegD;
        public FormPersona()
        {
            InitializeComponent();        
        }
        private void CargarPersona() 
        {
            Nom = txtNom.Text;
            DNI = Convert.ToInt64(txtDNI.Text);
            FeNac = dtFechaNac.Value;
            Sex = 'N';
            if (rbFem.Checked==true)
            {
                Sex = 'F';
            }
            else if (rbMas.Checked==true)
            {
                Sex = 'M';
            }
            else if (rbOtro.Checked == true)
            {
                Sex = 'O';
            }
            Persona pers;
            pers = new Persona(Nom, DNI, FeNac, Sex);
        }
        private void CargarAlumno()
        {
            CarA = txtCarA.Text;
            LegA = Convert.ToInt64(txtLegA.Text);
            
            Alumno alum;
            alum = new Alumno(Nom, DNI, FeNac, Sex, CarA, LegA);
        }
        private void CargarDocente()
        {
            CarD = txtCarD.Text;
            LegD = Convert.ToInt64(txtLegD.Text);

            Docente doc;
            doc = new Docente(Nom, DNI, FeNac, Sex, CarD, LegD);
        }
        private void btnPersona_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "" && txtDNI.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                CargarPersona();
                MessageBox.Show("Datos cargados con exito");
                txtNom.Text = "";
                txtDNI.Text = "";
            }
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            if (txtCarA.Text == "" && txtLegA.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                CargarAlumno();
                MessageBox.Show("Datos cargados con exito");
                txtCarA.Text = "";
                txtLegA.Text = "";
            }
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            if (txtCarD.Text == "" && txtLegD.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                CargarDocente();
                MessageBox.Show("Datos cargados con exito");
                txtCarD.Text = "";
                txtLegD.Text = "";
            }
        }
    }
}
