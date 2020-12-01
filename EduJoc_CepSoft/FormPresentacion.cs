using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  EduJoc_CepSoft
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
            GestionarPersonajes form = new GestionarPersonajes();
            form.ShowDialog();
        }
    }
}
