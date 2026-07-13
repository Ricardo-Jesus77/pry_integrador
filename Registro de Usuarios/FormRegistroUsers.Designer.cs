namespace pry_integrador.Registro_de_Usuarios
{
    partial class FormRegistroUsers
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textConfPassword = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.labelPerfil = new System.Windows.Forms.Label();
            this.labelConfContraseña = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCancelar);
            this.groupBox1.Controls.Add(this.buttonRegistrar);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textConfPassword);
            this.groupBox1.Controls.Add(this.textPassword);
            this.groupBox1.Controls.Add(this.labelPerfil);
            this.groupBox1.Controls.Add(this.labelConfContraseña);
            this.groupBox1.Controls.Add(this.labelContraseña);
            this.groupBox1.Controls.Add(this.labelNombreUsuario);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Nuevo Usuario";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(371, 263);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(87, 33);
            this.buttonCancelar.TabIndex = 19;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(218, 263);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(94, 33);
            this.buttonRegistrar.TabIndex = 18;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Medico",
            "Enfermera"});
            this.comboBox1.Location = new System.Drawing.Point(218, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 30);
            this.comboBox1.TabIndex = 17;
            // 
            // textConfPassword
            // 
            this.textConfPassword.Location = new System.Drawing.Point(218, 149);
            this.textConfPassword.Name = "textConfPassword";
            this.textConfPassword.Size = new System.Drawing.Size(240, 28);
            this.textConfPassword.TabIndex = 16;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(218, 97);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(240, 28);
            this.textPassword.TabIndex = 15;
            // 
            // labelPerfil
            // 
            this.labelPerfil.AutoSize = true;
            this.labelPerfil.Location = new System.Drawing.Point(22, 203);
            this.labelPerfil.Name = "labelPerfil";
            this.labelPerfil.Size = new System.Drawing.Size(58, 22);
            this.labelPerfil.TabIndex = 14;
            this.labelPerfil.Text = "Perfil:";
            // 
            // labelConfContraseña
            // 
            this.labelConfContraseña.AutoSize = true;
            this.labelConfContraseña.Location = new System.Drawing.Point(21, 149);
            this.labelConfContraseña.Name = "labelConfContraseña";
            this.labelConfContraseña.Size = new System.Drawing.Size(184, 22);
            this.labelConfContraseña.TabIndex = 13;
            this.labelConfContraseña.Text = "Confirmar Contrseña:";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(21, 97);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(106, 22);
            this.labelContraseña.TabIndex = 12;
            this.labelContraseña.Text = "Contraseña:";
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Location = new System.Drawing.Point(22, 51);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(175, 22);
            this.labelNombreUsuario.TabIndex = 11;
            this.labelNombreUsuario.Text = "Nombre de Usuario:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(218, 48);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(240, 28);
            this.textNombre.TabIndex = 10;
            // 
            // FormRegistroUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 344);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRegistroUsers";
            this.Text = "FormRegistroUsers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textConfPassword;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label labelPerfil;
        private System.Windows.Forms.Label labelConfContraseña;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.TextBox textNombre;
    }
}