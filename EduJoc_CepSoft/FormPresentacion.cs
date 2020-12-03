using System;
using System.Windows.Forms;

namespace EduJoc_CepSoft
{
    public partial class FormPresentacion : Form
    {
        public FormPresentacion()
        {
            InitializeComponent();
        }

        private void btnPreguntas_Click(object sender, EventArgs e)
        {
            FormPreguntas form = new FormPreguntas();
            form.ShowDialog();
        }

        private void btnPersonajes_Click(object sender, EventArgs e)
        {
            FormPersonajes form = new FormPersonajes();
            form.ShowDialog();
        }
    }
}
