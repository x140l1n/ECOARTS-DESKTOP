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
        //creamos variables para recuperar archivos
        private const string TEMAS_JSON = "temas.json";
        private const string IDIOMAS_JSON = "idiomas.json";
        //variables que formaran el objecto pregunta inicializados
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
        //lista para e atributo de respuestas que forman el atributo de la pregunta
        private List<Respuesta> respuestas = new List<Respuesta>();
        //binding list con las preguntas de cada idioma
        private BindingList<Pregunta> preguntas_es = null;
        private BindingList<Pregunta> preguntas_ca = null;
        private BindingList<Pregunta> preguntas_en = null;

        private Pregunta preguntaModificar;
        //boolean para saber si estamos modificando o insertando
        private bool modificar;

        /// <summary>
        /// Cuando insertamos.
        /// </summary>
        /// <param name="preguntas_es">Lista de preguntas en castellano.</param>
        /// <param name="preguntas_ca">Lista de preguntas en catalán.</param>
        /// <param name="preguntas_en">Lista de preguntas en Inglés.</param>
        // dos metodos constructores, uno para insertar que recibe las tres binding list de preguntas para insertar donde sea necesario
        //y otro que recibe la pregunta que se va a modificar
        public InsertarModificarPregunta(BindingList<Pregunta> preguntas_es, BindingList<Pregunta> preguntas_ca, BindingList<Pregunta> preguntas_en)
        {
            InitializeComponent();
            //capturamos bindingList en variables
            this.preguntas_es = preguntas_es;
            this.preguntas_ca = preguntas_ca;
            this.preguntas_en = preguntas_en;
            //cargamos todos los temas y los idiomas
            cargarTemas();
            cargarIdiomas();
            //seleccionamos castellano por defecto
            cmbIdioma.SelectedIndex = 0;
            //label por defecto que no se muestre, se activará si boolean modificado = true
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
            //capturamos objeto pregunta en variable
            this.preguntaModificar = preguntaModificar;
            //cargamos todos los posibles temas e idiomas
            cargarTemas();
            cargarIdiomas();
            //mostramosla label con el id de la pregunta
            lblId.Visible = true;
            lblId.Text = "#" + preguntaModificar.id;

            //Rellenar campos con la información de la pregunta
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

            }
            else if (preguntaModificar.respuestas[1].correcta == true)
            {
                rdbtnResp2.Checked = true;
            }
            else
            {
                rdbtnResp3.Checked = true;
            }

            //titulo formulario cambiado a modificar, tambien boton
            this.Text = "Modificar pregunta";

            btnInsertarModificar.Text = "Modificar";
            //no se podrá modificar el idioma, solo pregunta, respuestas y temática
            cmbIdioma.Enabled = false;
            //activamos indicador booleano modificar
            modificar = true;
        }

        //metodo para cargar temas
        private void cargarTemas()
        {
            //comprobams que existe el json con los temas
            if (File.Exists(TEMAS_JSON))
            {
                //si existe creamos variable JArray donde transformamos el archivo en un array tipo json
                JArray arrayTemas = JArray.Parse(File.ReadAllText(TEMAS_JSON));
                //pasamos cada elemento del array a un string que vinculamos con el combobox 
                foreach (string tema in arrayTemas.ToArray())
                    cmbTema.Items.Add(tema);
            }
        }
        //mismo funcionamiento que con temas pero con idiomas
        private void cargarIdiomas()
        {
            if (File.Exists(IDIOMAS_JSON))
            {
                JArray arrayIdiomes = JArray.Parse(File.ReadAllText(IDIOMAS_JSON));

                foreach (string idioma in arrayIdiomes.ToArray())
                    cmbIdioma.Items.Add(idioma);
            }
        }
        //funcionar que se ejecuta con el evento clic
        private void btnInsertarModificar_Click(object sender, System.EventArgs e)
        {
            //si modificar no está en true insertamosPregunta, sino modificamosPregunta
            if (!modificar) insertarPregunta();
            else modificarPregunta();
        }
        //si insertamosPregunta ejecutamos la funcion
        private void insertarPregunta()
        {
            //llamamos al metodo comprobarCampos donde se comprueba que todos los campos tienen valores corectos.
            if (comprobarCampos())
            {
                //guardamos en variables la informacion de los diferentes campos eliminando espacios en blanco con metodo Trim
                pregunta = tbtPregunta.Text.Trim();
                tema = cmbTema.Text.Trim();
                idioma = cmbIdioma.Text.Trim();
                respuesta1 = tbtResp1.Text.Trim();
                respuesta2 = tbtResp2.Text.Trim();
                respuesta3 = tbtResp3.Text.Trim();
                //comprobamos que radiobutton esta seleccionado para saber respuesta correcta
                if (rdbtnResp1.Checked) correcta1 = true;
                else if (rdbtnResp2.Checked) correcta2 = true;
                else correcta3 = true;
                //creamos objetos de tipo Respuesta i pasamos el valor de cada respuesta
                Respuesta objetoRespuesta1 = new Respuesta(respuesta1, correcta1);
                Respuesta objetoRespuesta2 = new Respuesta(respuesta2, correcta2);
                Respuesta objetoRespuesta3 = new Respuesta(respuesta3, correcta3);
                //añadimos a la list respuestas los tres objetos respuesta que forman el atributo de la pregunt
                respuestas.Add(objetoRespuesta1);
                respuestas.Add(objetoRespuesta2);
                respuestas.Add(objetoRespuesta3);
                //segun idioma seleccionado en comboBox ejecutamos codigo correspondiente
                switch (idioma)
                {

                    case "Castellano":
                        //miramos si hay preguntas en bindingList para buscar el id que le corresponda
                        if (preguntas_es.Count > 0)
                            //si hay preguntas nos posicionamon en el ultimo elemento de la bindinglist y
                            //seleccionamos su id. añadimos despues una unidad para asignar id a la pregunta
                            id = preguntas_es.ElementAt<Pregunta>(preguntas_es.Count() - 1).id + 1;
                        else
                            //si no hay preguntas en binding list le asignamos id=1
                            id = 1;
                        //instanciamos pregunta pasando por parametro el valor de sus atributos
                        Pregunta pregunta_es = new Pregunta(id, idioma, tema, pregunta, respuestas);
                        //añadimos la pregunta en la bindingList de preguntas
                        preguntas_es.Add(pregunta_es);

                        break;
                    //igual que castellano
                    case "Català":

                        if (preguntas_ca.Count > 0)
                            id = preguntas_ca.ElementAt<Pregunta>(preguntas_ca.Count() - 1).id + 1;
                        else
                            id = 1;

                        Pregunta pregunta_ca = new Pregunta(id, idioma, tema, pregunta, respuestas);
                        preguntas_ca.Add(pregunta_ca);

                        break;
                    //igual que castellano
                    case "English":

                        if (preguntas_en.Count > 0)
                            id = preguntas_en.ElementAt<Pregunta>(preguntas_en.Count() - 1).id + 1;
                        else
                            id = 1;

                        Pregunta pregunta_en = new Pregunta(id, idioma, tema, pregunta, respuestas);
                        preguntas_en.Add(pregunta_en);

                        break;
                }
                //inforamcion para el usuario de ok a insercion
                MessageBox.Show("Pregunta creada correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //cerramos formulario
                this.Close();
            }
        }
        //en caso de ejecutar modificarPregunta
        private void modificarPregunta()
        {
            //comprobamos que todos los campos estén con información correcta
            if (comprobarCampos())
            {
                //ponemos variables de respuesta correcta todos en false.
                correcta1 = false;
                correcta2 = false;
                correcta3 = false;
                //capturamos la info de todos los campos
                preguntaModificar.pregunta = tbtPregunta.Text;
                preguntaModificar.tema = cmbTema.Text;
                preguntaModificar.idioma = cmbIdioma.Text;
                preguntaModificar.respuestas[0].respuesta = tbtResp1.Text;
                preguntaModificar.respuestas[1].respuesta = tbtResp2.Text;
                preguntaModificar.respuestas[2].respuesta = tbtResp3.Text;
                //capturamos info del radioBUtton seleccionado
                if (rdbtnResp1.Checked) correcta1 = true;
                else if (rdbtnResp2.Checked) correcta2 = true;
                else correcta3 = true;
                //ponemos los atributo de la lista respuestas del objeto pregunta correspondiente
                preguntaModificar.respuestas[0].correcta = correcta1;
                preguntaModificar.respuestas[1].correcta = correcta2;
                preguntaModificar.respuestas[2].correcta = correcta3;
                //avisamos al usuarioque se ha modificado correctamente
                MessageBox.Show("Modificado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //cerramos formulario
                this.Close();
            }
        }
        //funcion para comprobar si los campos tienen informacion correcta
        public bool comprobarCampos()
        {
            //por defecto true
            bool correcto = true;

            errorProvider.Clear();

            //miramos si el campo text del combobox tema esta vacio o es null
            if (string.IsNullOrEmpty(cmbTema.Text.Trim()))
            {
                //en caso que sea null o vacio cambiamos correcto a false, limpiamos posibles errores
                //en pantalla anteriores y mostramos error a usuario
                correcto = false;
                mostrarError(cmbTema, "Debes de seleccionar un tema.");
            }
            //hacemos los mismo que anterior para comboBOx idioma

            if (string.IsNullOrEmpty(cmbIdioma.Text.Trim()))
            {
                correcto = false;
                mostrarError(cmbIdioma, "Debes de seleccionar un idioma.");
            }
            //hacemos los mismo que anterior para textBox pregunta

            if (string.IsNullOrEmpty(tbtPregunta.Text.Trim()))
            {
                correcto = false;
                mostrarError(tbtPregunta, "Debes de escribir una pregunta.");
            }
            //hacemos los mismo que anterior para textBox respuesta1, 2 y 3

            if (string.IsNullOrEmpty(tbtResp1.Text.Trim()))
            {
                correcto = false;
                mostrarError(tbtResp1, "Debes de escribir la respuesta 1.");
            }

            if (string.IsNullOrEmpty(tbtResp2.Text.Trim()))
            {
                correcto = false;
                mostrarError(tbtResp2, "Debes de escribir la respuesta 2.");
            }

            if (string.IsNullOrEmpty(tbtResp3.Text.Trim()))
            {
                correcto = false;
                mostrarError(tbtResp3, "Debes de escribir la respuesta 3.");
            }

            if (!correcto) lblError.Text = "HAY CAMPOS SIN RELLENAR";

            //si no ha entrado en ningun if retornaremos true. en caso contrario retornamos false
            return correcto;
        }

        /// <summary>
        /// Mostrar error.
        /// </summary>
        /// <param name="control">El control con el que vamos a mostrar el error.</param>
        /// <param name="mensaje">El mensaje de error que vamos a mostrar.</param>
        public void mostrarError(Control control, string mensaje)
        {
            errorProvider.SetError(control, mensaje);
        }
    }
}
