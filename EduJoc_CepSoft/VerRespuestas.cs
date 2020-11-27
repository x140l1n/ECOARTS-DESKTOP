using System.Windows.Forms;

namespace EduJoc_CepSoft
{
    public partial class VerRespuestas : Form
    {
        private Pregunta pregunta;
        //constructor donde capturamos pregunta recibida por parametro
        public VerRespuestas(Pregunta pregunta)
        {
            InitializeComponent();
            this.pregunta = pregunta;
        }
        //funcion al cargar formulario
        private void VerRespuestas_Load(object sender, System.EventArgs e)
        {
            //añadimos a los elementos dl formulario la informacion que contiene la pregunta
            lblId.Text = "#" + pregunta.id;
            tbtTema.Text = pregunta.tema;
            tbtIdioma.Text = pregunta.idioma;
            tbtPregunta.Text = pregunta.pregunta;

            tbtResp1.Text = pregunta.respuestas[0].respuesta;
            tbtResp2.Text = pregunta.respuestas[1].respuesta;
            tbtResp3.Text = pregunta.respuestas[2].respuesta;


            //seleccionamos radioButton correcto
            if (pregunta.respuestas[0].correcta == true)
            {
                radioButtonResp1.Checked = true;

            }else if(pregunta.respuestas[1].correcta == true)
            {
                radioButtonResp2.Checked=true;
            }
            else
            {
                radioButtonResp3.Checked = true;
            }
            
        }
    }
}
