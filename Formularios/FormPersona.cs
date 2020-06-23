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
        #region Variables
        private string Nom;
        private long DNI;
        private DateTime FeNac;
        private char Sex;
        private string CarA;
        private long LegA;
        private string CarD;
        private long LegD;
        #endregion
        public FormPersona()
        {
            InitializeComponent();        
        }
        #region Metodos
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

            Alumno alum = new Alumno(Nom, DNI, FeNac, Sex, CarA, LegA);
        }
        private void CargarDocente()
        {
            CarD = txtCarD.Text;
            LegD = Convert.ToInt64(txtLegD.Text);
            
            Docente doc = new Docente(Nom, DNI, FeNac, Sex, CarD, LegD);
        }
        #endregion
        #region botones
        private void btnPersona_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "" && txtDNI.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!rbFem.Checked && !rbMas.Checked && !rbOtro.Checked)
            {
                MessageBox.Show("Debe seleccionar una opcion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Datos cargados con exito");
                CargarPersona();                
                txtNom.Text = "";
                txtDNI.Text = "";
            }
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            if (txtCarA.Text == "" && txtLegA.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Datos cargados con exito");
                CargarAlumno();
                txtCarA.Text = "";
                txtLegA.Text = "";
            }
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            if (txtCarD.Text == "" && txtLegD.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Datos cargados con exito");
                CargarDocente();
                txtCarD.Text = "";
                txtLegD.Text = "";
            }
        }
        #endregion
        #region validation
        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && txtDNI.Text.Length != 8)
            {
                MessageBox.Show("Solo debe ingresar los 8 números de su DNI", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCarA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtLegA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCarD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtLegD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        #endregion
    }
}
