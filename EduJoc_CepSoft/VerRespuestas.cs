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
            tbtTema.Text = pregunta.tema;
            tbtIdioma.Text = pregunta.idioma;
            tbtPregunta.Text = pregunta.pregunta;
            tbtResp1.Text = pregunta.respuestas[0].ToString();
            tbtResp2.Text = pregunta.respuestas[1].ToString();
            tbtResp3.Text = pregunta.respuestas[2].ToString();

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
