namespace Formularios
{
    partial class FormPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.dtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.rbMas = new System.Windows.Forms.RadioButton();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.btnPersona = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbObjetos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLegA = new System.Windows.Forms.TextBox();
            this.txtCarA = new System.Windows.Forms.TextBox();
            this.btnAlumno = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLegD = new System.Windows.Forms.TextBox();
            this.txtCarD = new System.Windows.Forms.TextBox();
            this.btnDocente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ndni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnElimin = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbDoc = new System.Windows.Forms.RadioButton();
            this.rbAlum = new System.Windows.Forms.RadioButton();
            this.rbPers = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.tbObjetos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(14, 35);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(200, 20);
            this.txtNom.TabIndex = 0;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(14, 74);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(200, 20);
            this.txtDNI.TabIndex = 1;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // dtFechaNac
            // 
            this.dtFechaNac.CustomFormat = "DD/MM/YYYY";
            this.dtFechaNac.Location = new System.Drawing.Point(14, 122);
            this.dtFechaNac.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtFechaNac.Name = "dtFechaNac";
            this.dtFechaNac.Size = new System.Drawing.Size(200, 20);
            this.dtFechaNac.TabIndex = 2;
            this.dtFechaNac.Value = new System.DateTime(2020, 8, 31, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOtro);
            this.groupBox1.Controls.Add(this.rbMas);
            this.groupBox1.Controls.Add(this.rbFem);
            this.groupBox1.Location = new System.Drawing.Point(270, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Location = new System.Drawing.Point(6, 86);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(45, 17);
            this.rbOtro.TabIndex = 2;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            // 
            // rbMas
            // 
            this.rbMas.AutoSize = true;
            this.rbMas.Location = new System.Drawing.Point(6, 53);
            this.rbMas.Name = "rbMas";
            this.rbMas.Size = new System.Drawing.Size(73, 17);
            this.rbMas.TabIndex = 1;
            this.rbMas.TabStop = true;
            this.rbMas.Text = "Masculino";
            this.rbMas.UseVisualStyleBackColor = true;
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Location = new System.Drawing.Point(7, 20);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(71, 17);
            this.rbFem.TabIndex = 0;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Femenino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // btnPersona
            // 
            this.btnPersona.Location = new System.Drawing.Point(270, 189);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(115, 23);
            this.btnPersona.TabIndex = 4;
            this.btnPersona.Text = "Crear Persona";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha de Nacimiento:";
            // 
            // tbObjetos
            // 
            this.tbObjetos.Controls.Add(this.tabPage1);
            this.tbObjetos.Controls.Add(this.tabPage2);
            this.tbObjetos.Location = new System.Drawing.Point(499, 12);
            this.tbObjetos.Name = "tbObjetos";
            this.tbObjetos.SelectedIndex = 0;
            this.tbObjetos.Size = new System.Drawing.Size(259, 209);
            this.tbObjetos.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtLegA);
            this.tabPage1.Controls.Add(this.txtCarA);
            this.tabPage1.Controls.Add(this.btnAlumno);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(251, 183);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alumno";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Legajo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Carrera:";
            // 
            // txtLegA
            // 
            this.txtLegA.Location = new System.Drawing.Point(44, 62);
            this.txtLegA.Name = "txtLegA";
            this.txtLegA.Size = new System.Drawing.Size(163, 20);
            this.txtLegA.TabIndex = 2;
            this.txtLegA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLegA_KeyPress);
            // 
            // txtCarA
            // 
            this.txtCarA.Location = new System.Drawing.Point(44, 20);
            this.txtCarA.Name = "txtCarA";
            this.txtCarA.Size = new System.Drawing.Size(163, 20);
            this.txtCarA.TabIndex = 1;
            this.txtCarA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarA_KeyPress);
            // 
            // btnAlumno
            // 
            this.btnAlumno.Location = new System.Drawing.Point(98, 155);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(123, 23);
            this.btnAlumno.TabIndex = 0;
            this.btnAlumno.Text = "Crear Alumno";
            this.btnAlumno.UseVisualStyleBackColor = true;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtLegD);
            this.tabPage2.Controls.Add(this.txtCarD);
            this.tabPage2.Controls.Add(this.btnDocente);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(251, 183);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Docente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Legajo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Carrera:";
            // 
            // txtLegD
            // 
            this.txtLegD.Location = new System.Drawing.Point(43, 62);
            this.txtLegD.Name = "txtLegD";
            this.txtLegD.Size = new System.Drawing.Size(163, 20);
            this.txtLegD.TabIndex = 5;
            this.txtLegD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLegD_KeyPress);
            // 
            // txtCarD
            // 
            this.txtCarD.Location = new System.Drawing.Point(43, 20);
            this.txtCarD.Name = "txtCarD";
            this.txtCarD.Size = new System.Drawing.Size(163, 20);
            this.txtCarD.TabIndex = 4;
            this.txtCarD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarD_KeyPress);
            // 
            // btnDocente
            // 
            this.btnDocente.Location = new System.Drawing.Point(97, 155);
            this.btnDocente.Name = "btnDocente";
            this.btnDocente.Size = new System.Drawing.Size(123, 23);
            this.btnDocente.TabIndex = 3;
            this.btnDocente.Text = "Crear Docente";
            this.btnDocente.UseVisualStyleBackColor = true;
            this.btnDocente.Click += new System.EventHandler(this.btnDocente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DNI:";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Ndni,
            this.FechaNac,
            this.Sexo,
            this.Condicion,
            this.Carrera,
            this.Legajo});
            this.dgv.Location = new System.Drawing.Point(34, 266);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(703, 324);
            this.dgv.TabIndex = 9;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Ndni
            // 
            this.Ndni.HeaderText = "DNI";
            this.Ndni.Name = "Ndni";
            this.Ndni.ReadOnly = true;
            // 
            // FechaNac
            // 
            this.FechaNac.HeaderText = "Fecha Nacimiento";
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Condicion
            // 
            this.Condicion.HeaderText = "Condicion";
            this.Condicion.Name = "Condicion";
            this.Condicion.ReadOnly = true;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(411, 237);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(75, 23);
            this.btnModif.TabIndex = 10;
            this.btnModif.Text = "Modificar";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnElimin
            // 
            this.btnElimin.Location = new System.Drawing.Point(515, 237);
            this.btnElimin.Name = "btnElimin";
            this.btnElimin.Size = new System.Drawing.Size(75, 23);
            this.btnElimin.TabIndex = 11;
            this.btnElimin.Text = "Eliminar";
            this.btnElimin.UseVisualStyleBackColor = true;
            this.btnElimin.Click += new System.EventHandler(this.btnElimin_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.rbDoc);
            this.groupBox2.Controls.Add(this.rbAlum);
            this.groupBox2.Controls.Add(this.rbPers);
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 74);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mostrar lista de:";
            // 
            // rbDoc
            // 
            this.rbDoc.AutoSize = true;
            this.rbDoc.Location = new System.Drawing.Point(144, 48);
            this.rbDoc.Name = "rbDoc";
            this.rbDoc.Size = new System.Drawing.Size(71, 17);
            this.rbDoc.TabIndex = 2;
            this.rbDoc.TabStop = true;
            this.rbDoc.Text = "Docentes";
            this.rbDoc.UseVisualStyleBackColor = true;
            this.rbDoc.CheckedChanged += new System.EventHandler(this.rbDoc_CheckedChanged);
            // 
            // rbAlum
            // 
            this.rbAlum.AutoSize = true;
            this.rbAlum.Location = new System.Drawing.Point(77, 48);
            this.rbAlum.Name = "rbAlum";
            this.rbAlum.Size = new System.Drawing.Size(65, 17);
            this.rbAlum.TabIndex = 1;
            this.rbAlum.TabStop = true;
            this.rbAlum.Text = "Alumnos";
            this.rbAlum.UseVisualStyleBackColor = true;
            this.rbAlum.CheckedChanged += new System.EventHandler(this.rbAlum_CheckedChanged);
            // 
            // rbPers
            // 
            this.rbPers.AutoSize = true;
            this.rbPers.Location = new System.Drawing.Point(7, 48);
            this.rbPers.Name = "rbPers";
            this.rbPers.Size = new System.Drawing.Size(69, 17);
            this.rbPers.TabIndex = 0;
            this.rbPers.TabStop = true;
            this.rbPers.Text = "Personas";
            this.rbPers.UseVisualStyleBackColor = true;
            this.rbPers.CheckedChanged += new System.EventHandler(this.rbPers_CheckedChanged);
            // 
            // FormPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 610);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnElimin);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbObjetos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPersona);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtFechaNac);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtNom);
            this.Name = "FormPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Persona ABM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbObjetos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.DateTimePicker dtFechaNac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.RadioButton rbMas;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbObjetos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtLegA;
        private System.Windows.Forms.TextBox txtCarA;
        private System.Windows.Forms.Button btnAlumno;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtLegD;
        private System.Windows.Forms.TextBox txtCarD;
        private System.Windows.Forms.Button btnDocente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnElimin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbDoc;
        private System.Windows.Forms.RadioButton rbAlum;
        private System.Windows.Forms.RadioButton rbPers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ndni;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
    }
}

