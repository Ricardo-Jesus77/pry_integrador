using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_integrador.Registro_de_Usuarios
{
    public partial class FormRegistroUsers : Form
    {
        public FormRegistroUsers()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show(
                    "El nombre de usuario no debe estar en blanco.",
                    "Validacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textNombre.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textPassword.Text))
            {
                MessageBox.Show(
                    "La contraseña no debe estar en blanco.",
                    "Validacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textConfPassword.Text))
            {
                MessageBox.Show(
                    "Debe confirmar la contrasena.",
                    "Validacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textConfPassword.Focus();
                return;
            }

            if (textPassword.Text != textConfPassword.Text)
            {
                MessageBox.Show(
                    "Las contrasenas no coinciden",
                    "Validacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);


                textPassword.Clear();
                textConfPassword.Clear();
                textPassword.Focus();
                return;
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
