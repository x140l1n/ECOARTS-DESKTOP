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
<<<<<<< HEAD
            tbtResp1.Text = pregunta.respuestas[0].respuesta.ToString();
            tbtResp2.Text = pregunta.respuestas[1].respuesta.ToString();
            tbtResp3.Text = pregunta.respuestas[2].respuesta.ToString();
=======
            tbtResp1.Text = pregunta.respuestas[0].respuesta;
            tbtResp2.Text = pregunta.respuestas[1].respuesta;
            tbtResp3.Text = pregunta.respuestas[2].respuesta;
>>>>>>> 142a9061a2994949d13f26f847ec941ffdce02fb

            for (int i = 0; i < pregunta.respuestas.Count; i++)
            {
                if (pregunta.respuestas[i].correcta == true)
                {
                    grpBoxRespuestas.Controls[i].Select();
                }
            }
        }
    }
}
