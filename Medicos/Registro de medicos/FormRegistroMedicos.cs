using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_integrador.Medicos.Registro_de_medicos
{
    public partial class FormRegistroMedicos : Form
    {
        public FormRegistroMedicos()
        {
            InitializeComponent();
        }

        private void btonRegistrar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(textNombreM.Text))
            {
                MessageBox.Show(
                    "Campo obligatirio.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textNombreM.Focus();
                return;

            }

            if (string.IsNullOrWhiteSpace(textApellidoP.Text))
            {
                MessageBox.Show(
                    "Campo obligatirio.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textApellidoP.Focus();
                return;

            }

            if (string.IsNullOrWhiteSpace(textApellidoM.Text))
            {
                MessageBox.Show(
                    "Campo obligatirio.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textApellidoM.Focus();
                return;

            }

            if (string.IsNullOrWhiteSpace(textTelefono.Text))
            {
                MessageBox.Show(
                    "Campo obligatirio.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textTelefono.Focus();
                return;

            }

            if (string.IsNullOrWhiteSpace(textMail.Text))
            {
                MessageBox.Show(
                    "Campo obligatirio.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textMail.Focus();
                return;

            }

            if (string.IsNullOrWhiteSpace(textCedula.Text))
            {
                MessageBox.Show(
                    "Campo obligatirio.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textCedula.Focus();
                return;

            }

            
        }

        private void btonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void limpiarRegistro()
        {
            textNombreM.Clear();
            textApellidoP.Clear();
            textApellidoM.Clear();
            textTelefono.Clear();
            textMail.Clear();
        }

        
    }
}
