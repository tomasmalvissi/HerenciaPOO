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
using Negocio;

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
        Persona pers = new Persona();
        Alumno alum = new Alumno();
        Docente doc = new Docente();
        DatosPersona datper = new DatosPersona();
        DatosAlumno datalu = new DatosAlumno();
        DatosDocente datdoc = new DatosDocente();
        NegPersonas negper = new NegPersonas();
        NegAlumnos negalu = new NegAlumnos();
        NegDocentes negdoc = new NegDocentes();
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
                    pers.Nombre = Nom;
                    pers.DNI = DNI;
                    pers.FechaNac = FeNac;
                    pers.Sexo = Sex;
                    string accion = "Alta";
                    datper.ABMPer(accion, pers);
                    //dgv.Rows.Add(pers.Nombre, pers.DNI, pers.FechaNac, pers.Sexo);
                    MessageBox.Show("Datos cargados con exito");
                    DGVPersona();
                    txtNom.Text = "";
                    txtDNI.Text = "";
                }
                else if (avisopersona == DialogResult.Yes)
                {
                    pers.Nombre = Nom;
                    pers.DNI = DNI;
                    pers.FechaNac = FeNac;
                    pers.Sexo = Sex;
                }
            }
        }
        private void CargarAlumno()
        {
            CarA = txtCarA.Text;
            LegA = Convert.ToInt64(txtLegA.Text);

            alum.Nombre = Nom;
            alum.DNI = DNI;
            alum.FechaNac = FeNac;
            alum.Sexo = Sex;
            alum.Carrera = CarA;
            alum.Legajo = LegA;
            //dgv.Rows.Add(alum.Nombre, alum.DNI, alum.FechaNac, alum.Sexo, "Alumno", alum.Carrera, alum.Legajo);
            string accion = "Alta";
            datalu.ABMAlum(accion, alum);

        }
        private void CargarDocente()
        {
            CarD = txtCarD.Text;
            LegD = Convert.ToInt64(txtLegD.Text);

            doc.Nombre = Nom;
            doc.DNI = DNI;
            doc.FechaNac = FeNac;
            doc.Sexo = Sex;
            doc.Carrera = CarD;
            doc.Legajo = LegD;
            //dgv.Rows.Add(doc.Nombre, doc.DNI, doc.FechaNac, doc.Sexo, "Docente", doc.Carrera, doc.Legajo);
            string accion = "Alta";
            datdoc.ABMDoc(accion, doc);
        }
        private void Rellenar()
        {
            txtNom.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtDNI.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            string sexoif = dgv.CurrentRow.Cells[3].Value.ToString();
            dtFechaNac.Value = Convert.ToDateTime(dgv.CurrentRow.Cells[2].Value.ToString());
            if (sexoif == "F")
            {
                rbFem.Checked = true;
            }
            else if (sexoif == "M")
            {
                rbMas.Checked = true;
            }
            else if (sexoif == "O")
            {
                rbOtro.Checked = true;
            }
            string condicion = dgv.CurrentRow.Cells[4].Value.ToString();
            if (condicion == "Alumno")
            {
                txtCarA.Text = dgv.CurrentRow.Cells[5].Value.ToString();
                txtLegA.Text = dgv.CurrentRow.Cells[6].Value.ToString();
                txtCarD.Text = "";
                txtLegD.Text = "";
            }
            else if (condicion == "Docente")
            {
                txtCarD.Text = dgv.CurrentRow.Cells[5].Value.ToString();
                txtLegD.Text = dgv.CurrentRow.Cells[6].Value.ToString();
                txtCarA.Text = "";
                txtLegA.Text = "";
            }
        }
        private void DGVPersona()
        {
            dgv.Rows.Clear();
            DataSet ds = new DataSet();
            ds = negper.listadoper("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgv.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
                }
            }
        }
        private void DGVAlumno()
        {
            dgv.Rows.Clear();
            DataSet ds = new DataSet();
            ds = negalu.listadoalu("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgv.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
                }
            }
        }
        private void DGVDocente()
        {
            dgv.Rows.Clear();
            DataSet ds = new DataSet();
            ds = negdoc.listadodoc("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgv.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
                }
            }
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
                DGVAlumno();
                txtCarA.Text = "";
                txtLegA.Text = "";
                txtNom.Text = "";
                txtDNI.Text = "";
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
                DGVDocente();
                txtCarD.Text = "";
                txtLegD.Text = "";
                txtNom.Text = "";
                txtDNI.Text = "";
            }
        }
        private void btnModif_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "" && txtDNI.Text == "" && txtCarD.Text == "" && txtLegD.Text == "" && txtCarA.Text == "" && txtLegA.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!rbFem.Checked && !rbMas.Checked && !rbOtro.Checked)
            {
                MessageBox.Show("Debe seleccionar una opcion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dgv.CurrentRow.Cells[4].Value.ToString() == "Alumno")
                {
                    string accion = "Modificar";
                    datalu.ABMAlum(accion, alum);
                }
                else if (dgv.CurrentRow.Cells[4].Value.ToString() == "Docente")
                {
                    string accion = "Modificar";
                    datdoc.ABMDoc(accion, doc);
                }
                else
                {
                    string accion = "Modificar";
                    datper.ABMPer(accion, pers);
                }
            }
        }

        private void btnElimin_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow.Cells[4].Value.ToString() == "Alumno")
            {
                string accion = "Eliminar";
                datalu.ABMAlum(accion, alum);
            }
            else if (dgv.CurrentRow.Cells[4].Value.ToString() == "Docente")
            {
                string accion = "Eliminar";
                datdoc.ABMDoc(accion, doc);
            }
            else
            {
                string accion = "Eliminar";
                datper.ABMPer(accion, pers);
            }
        }
        private void rbPers_CheckedChanged(object sender, EventArgs e)
        {
            DGVPersona();
        }

        private void rbAlum_CheckedChanged(object sender, EventArgs e)
        {
            DGVAlumno();
        }

        private void rbDoc_CheckedChanged(object sender, EventArgs e)
        {
            DGVDocente();
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Rellenar();
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
