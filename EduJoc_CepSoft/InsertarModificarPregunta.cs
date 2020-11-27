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

        private string pregunta = "";

        private bool correcta1 = false;
        private bool correcta2 = false;
        private bool correcta3 = false;

        private string respuesta1 = "";
        private string respuesta2 = "";
        private string respuesta3 = "";

        private string tema = "";
        private string idioma = "";

        private int id = -1;

        private List<Respuesta> respuestas = new List<Respuesta>();

        private BindingList<Pregunta> preguntas_es = null;
        private BindingList<Pregunta> preguntas_ca = null;
        private BindingList<Pregunta> preguntas_en = null;

        private Pregunta preguntaModificar;

        private bool modificar;

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

            cmbIdioma.SelectedIndex = 0;

            lblId.Visible = false;

            modificar = false;
        }

        /// <summary>
        /// Cuando modificamos.
        /// </summary>
        /// <param name="preguntaModificar">La pregunta que vamos a modificar</param>
        public InsertarModificarPregunta(Pregunta preguntaModificar)
        {
            InitializeComponent();

            this.preguntaModificar = preguntaModificar;

            cargarTemas();
            cargarIdiomas();

            lblId.Visible = true;
            lblId.Text = "#" + preguntaModificar.id;

            //Rellenar campos.
            //Comboboxes.
            cmbIdioma.SelectedIndex = cmbIdioma.Items.IndexOf(this.preguntaModificar.idioma);
            cmbTema.SelectedIndex = cmbTema.Items.IndexOf(this.preguntaModificar.tema);

            //Textboxes.
            tbtPregunta.Text = preguntaModificar.pregunta;
            tbtResp1.Text = preguntaModificar.respuestas[0].respuesta;
            tbtResp2.Text = preguntaModificar.respuestas[1].respuesta;
            tbtResp3.Text = preguntaModificar.respuestas[2].respuesta;

            //Radiobuttons.
            
            if (preguntaModificar.respuestas[0].correcta == true)
            {
                rdbtnResp1.Checked = true;

            }else if(preguntaModificar.respuestas[1].correcta == true)
            {
                rdbtnResp2.Checked = true;
            }
            else
            {
                rdbtnResp3.Checked = true;
            }
            

            this.Text = "Modificar pregunta";

            btnInsertarModificar.Text = "Modificar";

            cmbIdioma.Enabled = false;

            modificar = true;
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
            if (!modificar) insertarPregunta();
            else modificarPregunta();
        }

        private void insertarPregunta()
        {
            //Si todos los campos están rellenados, modificamos.
            if (comprobarCampos())
            {
                pregunta = tbtPregunta.Text.Trim();
                tema = cmbTema.Text.Trim();
                idioma = cmbIdioma.Text.Trim();
                respuesta1 = tbtResp1.Text.Trim();
                respuesta2 = tbtResp2.Text.Trim();
                respuesta3 = tbtResp3.Text.Trim();

                if (rdbtnResp1.Checked) correcta1 = true;
                else if (rdbtnResp2.Checked) correcta2 = true;
                else correcta3 = true;

                Respuesta objetoRespuesta1 = new Respuesta(respuesta1, correcta1);
                Respuesta objetoRespuesta2 = new Respuesta(respuesta2, correcta2);
                Respuesta objetoRespuesta3 = new Respuesta(respuesta3, correcta3);

                respuestas.Add(objetoRespuesta1);
                respuestas.Add(objetoRespuesta2);
                respuestas.Add(objetoRespuesta3);

                switch (idioma)
                {
                    case "Castellano":

                        if (preguntas_es.Count > 0)
                            id = preguntas_es.ElementAt<Pregunta>(preguntas_es.Count() - 1).id + 1;
                        else
                            id = 1;

                        Pregunta pregunta_es = new Pregunta(id, idioma, tema, pregunta, respuestas);
                        preguntas_es.Add(pregunta_es);

                        break;

                    case "Català":

                        if (preguntas_ca.Count > 0)
                            id = preguntas_ca.ElementAt<Pregunta>(preguntas_ca.Count() - 1).id + 1;
                        else
                            id = 1;

                        Pregunta pregunta_ca = new Pregunta(id, idioma, tema, pregunta, respuestas);
                        preguntas_ca.Add(pregunta_ca);

                        break;

                    case "English":

                        if (preguntas_en.Count > 0)
                            id = preguntas_en.ElementAt<Pregunta>(preguntas_en.Count() - 1).id + 1;
                        else
                            id = 1;

                        Pregunta pregunta_en = new Pregunta(id, idioma, tema, pregunta, respuestas);
                        preguntas_en.Add(pregunta_en);

                        break;
                }

                MessageBox.Show("Pregunta creada correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void modificarPregunta()
        {
            if (comprobarCampos())
            {
                correcta1 = false;
                correcta2 = false;
                correcta3 = false;
                preguntaModificar.pregunta = tbtPregunta.Text;
                preguntaModificar.tema = cmbTema.Text;
                preguntaModificar.idioma = cmbIdioma.Text;
                preguntaModificar.respuestas[0].respuesta = tbtResp1.Text;
                preguntaModificar.respuestas[1].respuesta = tbtResp2.Text;
                preguntaModificar.respuestas[2].respuesta = tbtResp3.Text;

                if (rdbtnResp1.Checked) correcta1 = true;
                else if (rdbtnResp2.Checked) correcta2 = true;
                else correcta3 = true;

                preguntaModificar.respuestas[0].correcta = correcta1;
                preguntaModificar.respuestas[1].correcta = correcta2;
                preguntaModificar.respuestas[2].correcta = correcta3;

                MessageBox.Show("Modificado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        public bool comprobarCampos()
        {
            bool correcto = true;

            if (string.IsNullOrEmpty(cmbTema.Text.Trim()))
            {
                correcto = false;
                errorProvider.Clear();
                mostrarError(cmbTema, "Debes de seleccionar un tema.");
            }
            else if (string.IsNullOrEmpty(cmbIdioma.Text.Trim()))
            {
                correcto = false;
                errorProvider.Clear();
                mostrarError(cmbIdioma, "Debes de seleccionar un idioma.");
            }
            else if (string.IsNullOrEmpty(tbtPregunta.Text.Trim()))
            {
                correcto = false;
                errorProvider.Clear();
                mostrarError(tbtPregunta, "Debes de escribir una pregunta.");
            }
            else if (string.IsNullOrEmpty(tbtResp1.Text.Trim()))
            {
                correcto = false;
                errorProvider.Clear();
                mostrarError(tbtResp1, "Debes de escribir la respuesta 1.");
            }
            else if (string.IsNullOrEmpty(tbtResp2.Text.Trim()))
            {
                correcto = false;
                errorProvider.Clear();
                mostrarError(tbtResp2, "Debes de escribir la respuesta 2.");
            }
            else if (string.IsNullOrEmpty(tbtResp3.Text.Trim()))
            {
                correcto = false;
                errorProvider.Clear();
                mostrarError(tbtResp3, "Debes de escribir la respuesta 3.");
            }

            return correcto;
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
