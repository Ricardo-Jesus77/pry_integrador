namespace pry_integrador.Medicos.Registro_de_medicos
{
    partial class FormEditarMedico
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btonCambios = new System.Windows.Forms.Button();
            this.btonCancelar = new System.Windows.Forms.Button();
            this.comboEspecialidad = new System.Windows.Forms.ComboBox();
            this.textCedula = new System.Windows.Forms.TextBox();
            this.textMail = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textApellidoM = new System.Windows.Forms.TextBox();
            this.textApellidoP = new System.Windows.Forms.TextBox();
            this.textNombreM = new System.Windows.Forms.TextBox();
            this.Especialidad = new System.Windows.Forms.Label();
            this.Correo = new System.Windows.Forms.Label();
            this.Cedula = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.ApellidoM = new System.Windows.Forms.Label();
            this.ApellidoP = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btonCambios);
            this.groupBox1.Controls.Add(this.btonCancelar);
            this.groupBox1.Controls.Add(this.comboEspecialidad);
            this.groupBox1.Controls.Add(this.textCedula);
            this.groupBox1.Controls.Add(this.textMail);
            this.groupBox1.Controls.Add(this.textTelefono);
            this.groupBox1.Controls.Add(this.textApellidoM);
            this.groupBox1.Controls.Add(this.textApellidoP);
            this.groupBox1.Controls.Add(this.textNombreM);
            this.groupBox1.Controls.Add(this.Especialidad);
            this.groupBox1.Controls.Add(this.Correo);
            this.groupBox1.Controls.Add(this.Cedula);
            this.groupBox1.Controls.Add(this.Telefono);
            this.groupBox1.Controls.Add(this.ApellidoM);
            this.groupBox1.Controls.Add(this.ApellidoP);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Medico";
            // 
            // btonCambios
            // 
            this.btonCambios.AutoSize = true;
            this.btonCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.btonCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btonCambios.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonCambios.ForeColor = System.Drawing.Color.White;
            this.btonCambios.Location = new System.Drawing.Point(444, 282);
            this.btonCambios.Name = "btonCambios";
            this.btonCambios.Size = new System.Drawing.Size(155, 33);
            this.btonCambios.TabIndex = 33;
            this.btonCambios.Text = "Guardar Cambios";
            this.btonCambios.UseVisualStyleBackColor = false;
            this.btonCambios.Click += new System.EventHandler(this.btonCambios_Click);
            // 
            // btonCancelar
            // 
            this.btonCancelar.AutoSize = true;
            this.btonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.btonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btonCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonCancelar.ForeColor = System.Drawing.Color.White;
            this.btonCancelar.Location = new System.Drawing.Point(298, 282);
            this.btonCancelar.Name = "btonCancelar";
            this.btonCancelar.Size = new System.Drawing.Size(90, 33);
            this.btonCancelar.TabIndex = 32;
            this.btonCancelar.Text = "Cancelar";
            this.btonCancelar.UseVisualStyleBackColor = false;
            // 
            // comboEspecialidad
            // 
            this.comboEspecialidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEspecialidad.FormattingEnabled = true;
            this.comboEspecialidad.Items.AddRange(new object[] {
            "Cirugia",
            "Medicina Interna",
            "Pediatria",
            "Traumatologia"});
            this.comboEspecialidad.Location = new System.Drawing.Point(450, 146);
            this.comboEspecialidad.Name = "comboEspecialidad";
            this.comboEspecialidad.Size = new System.Drawing.Size(152, 29);
            this.comboEspecialidad.TabIndex = 31;
            // 
            // textCedula
            // 
            this.textCedula.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCedula.Location = new System.Drawing.Point(450, 71);
            this.textCedula.Name = "textCedula";
            this.textCedula.Size = new System.Drawing.Size(152, 28);
            this.textCedula.TabIndex = 30;
            // 
            // textMail
            // 
            this.textMail.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMail.Location = new System.Drawing.Point(235, 146);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(152, 28);
            this.textMail.TabIndex = 29;
            // 
            // textTelefono
            // 
            this.textTelefono.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefono.Location = new System.Drawing.Point(235, 71);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(152, 28);
            this.textTelefono.TabIndex = 28;
            // 
            // textApellidoM
            // 
            this.textApellidoM.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellidoM.Location = new System.Drawing.Point(30, 227);
            this.textApellidoM.Name = "textApellidoM";
            this.textApellidoM.Size = new System.Drawing.Size(152, 28);
            this.textApellidoM.TabIndex = 27;
            // 
            // textApellidoP
            // 
            this.textApellidoP.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellidoP.Location = new System.Drawing.Point(30, 147);
            this.textApellidoP.Name = "textApellidoP";
            this.textApellidoP.Size = new System.Drawing.Size(152, 28);
            this.textApellidoP.TabIndex = 26;
            // 
            // textNombreM
            // 
            this.textNombreM.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreM.Location = new System.Drawing.Point(30, 71);
            this.textNombreM.Name = "textNombreM";
            this.textNombreM.Size = new System.Drawing.Size(152, 28);
            this.textNombreM.TabIndex = 25;
            // 
            // Especialidad
            // 
            this.Especialidad.AutoSize = true;
            this.Especialidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Especialidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.Especialidad.Location = new System.Drawing.Point(446, 123);
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.Size = new System.Drawing.Size(103, 21);
            this.Especialidad.TabIndex = 24;
            this.Especialidad.Text = "Especialidad";
            // 
            // Correo
            // 
            this.Correo.AutoSize = true;
            this.Correo.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.Correo.Location = new System.Drawing.Point(237, 123);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(143, 21);
            this.Correo.TabIndex = 23;
            this.Correo.Text = "Correo Eletronico";
            // 
            // Cedula
            // 
            this.Cedula.AutoSize = true;
            this.Cedula.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.Cedula.Location = new System.Drawing.Point(446, 47);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(153, 21);
            this.Cedula.TabIndex = 22;
            this.Cedula.Text = "Cedula Profesional";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.Telefono.Location = new System.Drawing.Point(237, 47);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(77, 21);
            this.Telefono.TabIndex = 21;
            this.Telefono.Text = "Telefono";
            // 
            // ApellidoM
            // 
            this.ApellidoM.AutoSize = true;
            this.ApellidoM.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.ApellidoM.Location = new System.Drawing.Point(32, 203);
            this.ApellidoM.Name = "ApellidoM";
            this.ApellidoM.Size = new System.Drawing.Size(143, 21);
            this.ApellidoM.TabIndex = 20;
            this.ApellidoM.Text = "Apellido Materno";
            // 
            // ApellidoP
            // 
            this.ApellidoP.AutoSize = true;
            this.ApellidoP.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.ApellidoP.Location = new System.Drawing.Point(32, 123);
            this.ApellidoP.Name = "ApellidoP";
            this.ApellidoP.Size = new System.Drawing.Size(137, 21);
            this.ApellidoP.TabIndex = 19;
            this.ApellidoP.Text = "Apellido Paterno";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.Nombre.Location = new System.Drawing.Point(26, 47);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(90, 21);
            this.Nombre.TabIndex = 18;
            this.Nombre.Text = "Nombre(s)";
            // 
            // FormEditarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 344);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEditarMedico";
            this.Text = "FormEditarMedico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btonCambios;
        private System.Windows.Forms.Button btonCancelar;
        private System.Windows.Forms.ComboBox comboEspecialidad;
        private System.Windows.Forms.TextBox textCedula;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textApellidoM;
        private System.Windows.Forms.TextBox textApellidoP;
        private System.Windows.Forms.TextBox textNombreM;
        private System.Windows.Forms.Label Especialidad;
        private System.Windows.Forms.Label Correo;
        private System.Windows.Forms.Label Cedula;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label ApellidoM;
        private System.Windows.Forms.Label ApellidoP;
        private System.Windows.Forms.Label Nombre;
    }
}