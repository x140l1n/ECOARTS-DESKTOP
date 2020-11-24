using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EduJoc_CepSoft
{
    public partial class InsertarModificarPregunta : Form
    {
        private const string TEMAS_JSON = "temas.json";
        private const string IDIOMAS_JSON = "idiomas.json";

        private string pregunta;

        private bool correcta1 = false;
        private bool correcta2 = false;
        private bool correcta3 = false;

        private string respuesta1;
        private string respuesta2;
        private string respuesta3;

        private string tema;

        private int id;

        private List<Respuesta> respuestas = new List<Respuesta>();

        private BindingList<Pregunta> preguntas_es;
        private BindingList<Pregunta> preguntas_ca;
        private BindingList<Pregunta> preguntas_en;

        private Pregunta preguntaModificar;

        /// <summary>
        /// Cuando insertamos.
        /// </summary>
        /// <param name="preguntas_es">Lista de preguntas en castellano.</param>
        /// <param name="preguntas_ca">Lista de preguntas en catalán.</param>
        /// <param name="preguntas_en">Lista de preguntas en Inglés.</param>
        public InsertarModificarPregunta(BindingList<Pregunta> preguntas_es, BindingList<Pregunta> preguntas_ca, BindingList<Pregunta> preguntas_en)
        {
            InitializeComponent();

            this.preguntas_es = preguntas_es;
            this.preguntas_ca = preguntas_ca;
            this.preguntas_en = preguntas_en;

            cargarTemas();
            cargarIdiomas();

            lblId.Visible = false;
        }

        /// <summary>
        /// Cuando modificamos.
        /// </summary>
        /// <param name="preguntaModificar">La pregunta que vamos a modificar</param>
        /// <param name="preguntas_es">Lista de preguntas en castellano.</param>
        /// <param name="preguntas_ca">Lista de preguntas en catalán.</param>
        /// <param name="preguntas_en">Lista de preguntas en Inglés.</param>
        public InsertarModificarPregunta(Pregunta preguntaModificar, BindingList<Pregunta> preguntas_es, BindingList<Pregunta> preguntas_ca, BindingList<Pregunta> preguntas_en)
        {
            InitializeComponent();

            this.preguntaModificar = preguntaModificar;

            this.preguntas_es = preguntas_es;
            this.preguntas_ca = preguntas_ca;
            this.preguntas_en = preguntas_en;

            cargarTemas();
            cargarIdiomas();

            cmbIdioma.SelectedIndex = cmbIdioma.Items.IndexOf(this.preguntaModificar.idioma);
            cmbTema.SelectedIndex = cmbTema.Items.IndexOf(this.preguntaModificar.tema);

            lblId.Visible = true;
            lblId.Text = "#" + preguntaModificar.id;
        }

        private void cargarTemas()
        {
            if (File.Exists(TEMAS_JSON))
            {
                JArray arrayTemas = JArray.Parse(File.ReadAllText(TEMAS_JSON));

                foreach (string tema in arrayTemas.ToArray())
                    cmbTema.Items.Add(tema);
            }
        }

        private void cargarIdiomas()
        {
            if (File.Exists(IDIOMAS_JSON))
            {
                JArray arrayIdiomes = JArray.Parse(File.ReadAllText(IDIOMAS_JSON));

                foreach (string idioma in arrayIdiomes.ToArray())
                    cmbIdioma.Items.Add(idioma);
            }
        }

        private void btnInsertarModificar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(tbtPregunta.Text))
            {
                mostrarError(tbtPregunta, "Hay que escribir una pregunta");
                tbtPregunta.Focus();
            }
            else
            {
                errorProvider.Clear();
                pregunta = tbtPregunta.Text;

                if (string.IsNullOrEmpty(tbtResp1.Text))
                {
                    mostrarError(tbtResp1, "Hay que escribir la respuesta 1");
                    tbtResp1.Focus();
                }
                else
                {
                    errorProvider.Clear();
                    respuesta1 = tbtResp1.Text;

                    if (string.IsNullOrEmpty(tbtResp2.Text))
                    {
                        mostrarError(tbtResp2, "Hay que escribir la respuesta 2");
                        tbtResp2.Focus();
                    }
                    else
                    {
                        errorProvider.Clear();
                        respuesta2 = tbtResp2.Text;

                        if (string.IsNullOrEmpty(tbtResp3.Text))
                        {
                            mostrarError(tbtResp3, "Hay que escribir la respuesta 3");
                            tbtResp3.Focus();
                        }
                        else
                        {
                            errorProvider.Clear();
                            respuesta3 = tbtResp3.Text;

                            if (rdbtnResp1.Checked)
                            {
                                correcta1 = true;
                            }
                            else if (rdbtnResp2.Checked)
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
                            respuestas.Add(objetoRespuesta2);
                            Respuesta objetoRespuesta3 = new Respuesta(respuesta3, correcta3);
                            respuestas.Add(objetoRespuesta3);

                            if (string.IsNullOrEmpty(cmbTema.Text))
                            {
                                mostrarError(cmbTema, "Seleccionar el tema de la pregunta");
                            }
                            else
                            {
                                errorProvider.Clear();
                                tema = cmbTema.Text;

                                if (string.IsNullOrEmpty(cmbIdioma.Text))
                                {
                                    mostrarError(cmbTema, "Seleccionar el idioma de la pregunta");
                                }
                                else
                                {
                                    errorProvider.Clear();

                                    switch (cmbIdioma.Text)
                                    {
                                        case "Castellano":
                                            id = preguntas_es.Count() + 1;
                                            Pregunta pregunta_es = new Pregunta(id, "Castellano", tema, pregunta, respuestas);
                                            preguntas_es.Add(pregunta_es);

                                            break;

                                        case "Català":
                                            id = preguntas_ca.Count() + 1;
                                            Pregunta pregunta_ca = new Pregunta(id, "Català", tema, pregunta, respuestas);
                                            preguntas_ca.Add(pregunta_ca);

                                            break;

                                        case "English":
                                            id = preguntas_en.Count() + 1;
                                            Pregunta pregunta_en = new Pregunta(id, "English", tema, pregunta, respuestas);
                                            preguntas_en.Add(pregunta_en);

                                            break;
                                    }

                                    MessageBox.Show("Pregunta creada correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Mostrar error y poner el foco al textbox.
        /// </summary>
        /// <param name="textBox">El textbox que va a recibir el foco.</param>
        /// <param name="missatge">El mensaje de error que vamos a mostrar.</param>
        public void mostrarError(TextBox textBox, string missatge)
        {
            errorProvider.SetError(textBox, missatge);

            //Mostrem el missatge també en un lloc visible del formulari.
            lblError.Text = missatge.ToUpper();
            textBox.Focus();
        }

        /// <summary>
        /// Mostrar error y poner el foco al combobox.
        /// </summary>
        /// <param name="comboBox">El comboBox que va a recibir el foco.</param>
        /// <param name="missatge">El mensaje de error que vamos a mostrar.</param>
        public void mostrarError(ComboBox comboBox, string missatge)
        {
            errorProvider.SetError(comboBox, missatge);

            //Mostrem el missatge també en un lloc visible del formulari.
            lblError.Text = missatge.ToUpper();
            comboBox.Focus();
        }
    }
}
