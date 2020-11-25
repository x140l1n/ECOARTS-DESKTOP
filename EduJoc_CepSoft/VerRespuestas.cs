using System.Windows.Forms;

namespace EduJoc_CepSoft
{
    public partial class VerRespuestas : Form
    {
        private Pregunta pregunta;

        public VerRespuestas(Pregunta pregunta)
        {
            InitializeComponent();
            this.pregunta = pregunta;
        }

        private void VerRespuestas_Load(object sender, System.EventArgs e)
        {
            lblId.Text = "#" + pregunta.id;
            tbtTema.Text = pregunta.tema;
            tbtIdioma.Text = pregunta.idioma;
            tbtPregunta.Text = pregunta.pregunta;

            tbtResp1.Text = pregunta.respuestas[0].respuesta;
            tbtResp2.Text = pregunta.respuestas[1].respuesta;
            tbtResp3.Text = pregunta.respuestas[2].respuesta;


            /*for (int i = 0; i < pregunta.respuestas.Count; i++)
            {
                if (pregunta.respuestas[i].correcta == true)
                {
                    grpBoxRespuestas.Controls[i].Select();
                }
            }*/

            if (pregunta.respuestas[0].correcta == true)
            {
                radioButtonResp1.Checked = true;
            }
            else if (pregunta.respuestas[1].correcta == true)
            {
                radioButtonResp2.Checked = true;
            }
            else
            {
                radioButtonResp3.Checked = true;
            }
        }
    }
}
