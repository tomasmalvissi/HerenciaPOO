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
using Datos;

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
            if (txtCarA.Text == "" || txtLegA.Text == "" || txtCarD.Text == "" || txtLegD.Text == "")
            {
                DialogResult avisopersona = MessageBox.Show("¿Quiere cargar los datos de un Alumno o Docente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (avisopersona == DialogResult.No)
                {
                    Persona pers = new Persona(Nom, DNI, FeNac, Sex);
                    DatosPersona dpersona = new DatosPersona();
                    string accion = "Alta";
                    dpersona.ABMPer(accion, pers);
                    //dgv.Rows.Add(pers.Nombre, pers.DNI, pers.FechaNac, pers.Sexo);
                    MessageBox.Show("Datos cargados con exito");
                    txtNom.Text = "";
                    txtDNI.Text = "";
                }
                else if (avisopersona == DialogResult.Yes)
                {
                    Persona pers = new Persona(Nom, DNI, FeNac, Sex);
                }
            }
        }
        private void CargarAlumno()
        {
            CarA = txtCarA.Text;
            LegA = Convert.ToInt64(txtLegA.Text);

            Alumno alum = new Alumno(Nom, DNI, FeNac, Sex, CarA, LegA);
            //dgv.Rows.Add(alum.Nombre, alum.DNI, alum.FechaNac, alum.Sexo, "Alumno", alum.Carrera, alum.Legajo);
            DatosAlumno dalumno = new DatosAlumno();
            string accion = "Alta";
            dalumno.ABMAlum(accion, alum);

        }
        private void CargarDocente()
        {
            CarD = txtCarD.Text;
            LegD = Convert.ToInt64(txtLegD.Text);
            
            Docente doc = new Docente(Nom, DNI, FeNac, Sex, CarD, LegD);
            //dgv.Rows.Add(doc.Nombre, doc.DNI, doc.FechaNac, doc.Sexo, "Docente", doc.Carrera, doc.Legajo);
            DatosDocente ddocente = new DatosDocente();
            string accion = "Alta";
            ddocente.ABMDoc(accion, doc);
        }
        //private void Rellenar() 
        //{
        //    txtNom.Text = dgv.CurrentRow.Cells[0].Value.ToString();
        //    txtDNI.Text = dgv.CurrentRow.Cells[1].Value.ToString();
        //    dtFechaNac.Value = Convert.ToDateTime(dgv.CurrentRow.Cells[2].Value.ToString());
        //    string condicion = dgv.CurrentRow.Cells[4].Value.ToString();
        //    if (condicion == "Alumno")
        //    {
        //        txtCarA.Text = dgv.CurrentRow.Cells[5].Value.ToString();
        //        txtLegA.Text = dgv.CurrentRow.Cells[6].Value.ToString();
        //        txtCarD.Text = "";
        //        txtLegD.Text = "";
        //    }
        //    else if (condicion == "Docente")
        //    {
        //        txtCarD.Text = dgv.CurrentRow.Cells[5].Value.ToString();
        //        txtLegD.Text = dgv.CurrentRow.Cells[6].Value.ToString();
        //        txtCarA.Text = "";
        //        txtLegA.Text = "";
        //    }
        //}
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
            else if (txtDNI.Text.Length != 8)
            {
                MessageBox.Show("Debe ingresar los 8 números de su DNI", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                CargarPersona();
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
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Sex == 'F')
            {
                rbFem.Checked = true;
            }
            else if (Sex == 'M')
            {
                rbMas.Checked = true;
            }
            else if (Sex == 'O')
            {
                rbOtro.Checked = true;
            }
            //Rellenar();
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
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
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
