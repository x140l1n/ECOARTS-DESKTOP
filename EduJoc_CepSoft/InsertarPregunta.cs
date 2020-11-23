using Newtonsoft.Json.Linq;
using System.Collections;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EduJoc_CepSoft
{
    public partial class InsertarPregunta : Form
    {
        private const string TEMAS_JSON = "temas.json";
        private const string IDIOMAS_JSON = "idiomas.json";
        private string pregunta;
        private string respuesta1;
        private string respuesta2;
        private string respuesta3;
        public InsertarPregunta()
        {
            InitializeComponent();
        }

        private void cargarTemas()
        {
            if (File.Exists(TEMAS_JSON))
            {
                JArray arrayTemas = JArray.Parse(File.ReadAllText(TEMAS_JSON));
                comboBoxTema.DataSource = arrayTemas.ToArray();
            }
        }
        private void cargarIdiomas()
        {
            if (File.Exists(IDIOMAS_JSON))
            {
                JArray arrayIdiomes = JArray.Parse(File.ReadAllText(IDIOMAS_JSON));
                comboBoxIdioma.DataSource = arrayIdiomes.ToArray();

            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (textBoxPregunta.Text.Equals(""))
            {
                MessageBox.Show("Hay que escribir una pregunta.");
                textBoxPregunta.Focus();
            }
            else
            {
                pregunta = textBoxPregunta.Text;
                if (textBoxResp1.Text.Equals(""))
                {
                    MessageBox.Show("Hay que escribir la respuesta 1.");
                    textBoxResp1.Focus();
                }
                else
                {
                    respuesta1 = textBoxResp1.Text;
                    if (textBoxResp2.Text.Equals(""))
                    {
                        MessageBox.Show("Hay que escribir la respuesta 2.");
                        textBoxResp2.Focus();
                    }
                    else
                    {
                        respuesta2 = textBoxResp2.Text; 
                        if (textBoxResp3.Text.Equals(""))
                        {
                            MessageBox.Show("Hay que escribir la respuesta 3.");
                            textBoxResp3.Focus();
                        }
                        else
                        {
                            respuesta3 = textBoxResp3.Text;

                        }
                    }
                }
            }
        }
    }
}
