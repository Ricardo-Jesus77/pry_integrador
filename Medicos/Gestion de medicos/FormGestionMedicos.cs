using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pry_integrador.Medicos.Registro_de_medicos;

namespace pry_integrador.Medicos.Gestion_de_medicos
{
    public partial class FormGestionMedicos : Form
    {
        public FormGestionMedicos()
        {
            InitializeComponent();
        }

              
        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistroMedicos form = new FormRegistroMedicos();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
    }
}
