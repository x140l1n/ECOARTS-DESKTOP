using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
        private bool correcta1 = false;
        private string respuesta2;
        private bool correcta2 = false;
        private string respuesta3;
        private bool correcta3 = false;
        private string tema;
        private int idPregunta;
        private List<Respuesta> respuestas = new List<Respuesta>();
        
        private BindingList<Pregunta> preguntas_es;
        private BindingList<Pregunta> preguntas_ca;
        private BindingList<Pregunta> preguntas_en;
        public InsertarPregunta(BindingList<Pregunta> preguntas_es, BindingList<Pregunta> preguntas_ca, BindingList<Pregunta> preguntas_en)
        {
            InitializeComponent();
           
            this.preguntas_es = preguntas_es;
            this.preguntas_ca = preguntas_ca;
            this.preguntas_en = preguntas_en;
            
        }
        private void InsertarPregunta_Load(object sender, System.EventArgs e)
        {
            cargarTemas();
            cargarIdiomas();
            labelId.Text = "";
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
                mostrarError(textBoxPregunta, "Hay que escribir una pregunta.");
                textBoxPregunta.Focus();
            }
            else
            {
                errorProvider.Clear();
                pregunta = textBoxPregunta.Text;
                if (textBoxResp1.Text.Equals(""))
                {
                    mostrarError(textBoxResp1, "Hay que escribir la respuesta 1.");
                    textBoxResp1.Focus();
                }
                else
                {
                    errorProvider.Clear();
                    respuesta1 = textBoxResp1.Text;
                    if (textBoxResp2.Text.Equals(""))
                    {
                        mostrarError(textBoxResp2, "Hay que escribir la respuesta 2.");
                        textBoxResp2.Focus();
                    }
                    else
                    {
                        errorProvider.Clear();
                        respuesta2 = textBoxResp2.Text; 
                        if (textBoxResp3.Text.Equals(""))
                        {
                            mostrarError(textBoxResp3, "Hay que escribir la respuesta 3.");
                            textBoxResp3.Focus();
                        }
                        else
                        {
                            errorProvider.Clear();
                            respuesta3 = textBoxResp3.Text;
                            if (radioButtonResp1.Checked)
                            {
                                correcta1 = true;
                            }else if (radioButtonResp2.Checked)
                            {
                                correcta2 = true;
                            }
                            else
                            {
                                correcta3 = true;
                            }
                            Respuesta objetoRespuesta1 = new Respuesta(respuesta1, correcta1);
                            respuestas.Add(objetoRespuesta1);
                            Respuesta objetoRespuesta2 = new Respuesta(respuesta2, correcta2);
                            respuestas.Add(objetoRespuesta1);
                            Respuesta objetoRespuesta3 = new Respuesta(respuesta3, correcta3);
                            respuestas.Add(objetoRespuesta3);

                            if (comboBoxTema.SelectedIndex==0)
                            {
                                mostrarError(comboBoxTema, "Seleccionar el tema de la pregunta");
                            }
                            else
                            {
                                errorProvider.Clear();
                                tema = comboBoxTema.Text;
                                if (comboBoxIdioma.Text.Equals(""))
                                {
                                    mostrarError(comboBoxTema, "Seleccionar el idioma de la pregunta");
                                }
                                else
                                {
                                    errorProvider.Clear();
                                    if (comboBoxIdioma.Text.Equals("Castellano"))
                                    {
                                        idPregunta = preguntas_es.Count()+1;
                                        Pregunta nuevaPregunta = new Pregunta(idPregunta, tema, pregunta, respuestas);
                                        preguntas_es.Add(nuevaPregunta);

                                    }else if (comboBoxIdioma.Text.Equals("Català"))
                                    {
                                        idPregunta = preguntas_ca.Count() + 1;
                                        Pregunta nuevaPregunta = new Pregunta(idPregunta, tema, pregunta, respuestas);
                                        preguntas_ca.Add(nuevaPregunta);
                                    }
                                    else
                                    {
                                        idPregunta = preguntas_en.Count() + 1;
                                        Pregunta nuevaPregunta = new Pregunta(idPregunta, tema, pregunta, respuestas);
                                        preguntas_en.Add(nuevaPregunta);
                                    }
                                    this.Close();   
                                }
                                
                            }

                        }
                    }
                }
            }
        }

        private void groupBoxRespuestas_Enter(object sender, System.EventArgs e)
        {

        }
        public void mostrarError(TextBox textBox, string missatge)
        {
            errorProvider.SetError(textBox, missatge);
            //mostrem el missatge també en un lloc visible del formulari
            missatgeError.Text = missatge.ToUpper();
            textBox.Focus();

        }
        public void mostrarError(ComboBox comboBox, string missatge)
        {
            errorProvider.SetError(comboBox, missatge);
            //mostrem el missatge també en un lloc visible del formulari
            missatgeError.Text = missatge.ToUpper();
            comboBox.Focus();

        }


    }
}
