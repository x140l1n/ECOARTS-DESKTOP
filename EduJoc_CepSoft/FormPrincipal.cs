using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EduJoc_CepSoft
{
    public partial class FormPrincipal : Form
    {
        //variables para archivos json
        private const string PREGUNTAS_JSON_ES = ".//Preguntas//preguntas_es.json";
        private const string PREGUNTAS_JSON_CA = ".//Preguntas//preguntas_ca.json";
        private const string PREGUNTAS_JSON_EN = ".//Preguntas//preguntas_en.json";

        private const string TEMAS_JSON = "temas.json";
        private const string IDIOMAS_JSON = "idiomas.json";
        //binding list donde se guardará la informacion de las preguntas
        private BindingList<Pregunta> preguntas_es;
        private BindingList<Pregunta> preguntas_ca;
        private BindingList<Pregunta> preguntas_en;

        public FormPrincipal()
        {
            InitializeComponent();
            //inicializamos binding list de cada idioma
            preguntas_es = new BindingList<Pregunta>();
            preguntas_ca = new BindingList<Pregunta>();
            preguntas_en = new BindingList<Pregunta>();
        }
        //funcion load al cargar el programa
        private void FormPrincipal_Load(object sender, System.EventArgs e)
        {
            //si apretamos enter en formulario será lo mismo que el evento clic sobre el boton buscar
            this.AcceptButton = btnBuscar;
            //llamamos a la funcion cargarTemas y cargarIdiomas para rellenar comboBox 
            cargarTemas();
            cargarIdiomas();
            //llamamos a la funcion cargarPreguntas pasando por referencia la bindingList y por valor el archivo
            CargarPreguntas(ref preguntas_es, PREGUNTAS_JSON_ES);
            CargarPreguntas(ref preguntas_ca, PREGUNTAS_JSON_CA);
            CargarPreguntas(ref preguntas_en, PREGUNTAS_JSON_EN);
            //por defecto mostramos idioma castellano en combobox idioma
            cmbFiltrarIdioma.SelectedIndex = 0;
            //en variable idioma introducimos la opcion seleccionada del comboBox
            string idioma = cmbFiltrarIdioma.SelectedItem.ToString();
            //segun idioma ejecutamos codigo
            switch (idioma)
            {
                //mostramos una bindingList o otra segun el idioma seleccionado en la dataGrid
                case "Castellano": dgvPreguntas.DataSource = preguntas_es; break;
                case "Catalán": dgvPreguntas.DataSource = preguntas_ca; break;
                case "Inglés": dgvPreguntas.DataSource = preguntas_en; break;
            }
            //borramos cualquier posible seleccion de la memoria del data grid que pueda haber
            dgvPreguntas.ClearSelection();
        }
        //metodo para cargar preguntas en bindingList desde archivo json. recibe por referencia la bindinList y
        //el nombre del archivo donde se almacena las preguntas
        private void CargarPreguntas(ref BindingList<Pregunta> preguntas, string path_json)
        {
            //comprobamos si existe archivo
            if (File.Exists(path_json))
            {
                //si existe transformamos datos de archivo en array de tipo json
                JArray arrayPreguntas = JArray.Parse(File.ReadAllText(path_json));
                //transformamos los objetos del jarray  en objetos para la bindingList de tipo Pregunta y lo guardamos 
                //en bindingList recibido
                preguntas = arrayPreguntas.ToObject<BindingList<Pregunta>>();
            }
        }
        // metodo para cargar los temas
        private void cargarTemas()
        {
            //comprobamos si sexiste archivo
            if (File.Exists(TEMAS_JSON))
            {
                //si existe transformamos datos de archivo en array de tipo json
                JArray arrayTemas = JArray.Parse(File.ReadAllText(TEMAS_JSON));
                //por cada elemento del jarray lo añadimos en el comboBox tema
                foreach (string tema in arrayTemas.ToArray())
                    cmbFiltrarTema.Items.Add(tema);
            }
        }
        //igual qie el metodo cargarTemas pero con Idiomas
        private void cargarIdiomas()
        {
            if (File.Exists(IDIOMAS_JSON))
            {
                JArray arrayIdiomes = JArray.Parse(File.ReadAllText(IDIOMAS_JSON));

                foreach (string idioma in arrayIdiomes.ToArray())
                    cmbFiltrarIdioma.Items.Add(idioma);
            }
        }
        //metodo que recibe la bindinglist i el archivo donde se guardarán los elementos que contiene la bindingList
        private void GuardarPreguntas(BindingList<Pregunta> preguntas, string path_json)
        {
            //metemos en un jarray cada objeto que hay en la bingingList
            JArray arrayPreguntas = (JArray)JToken.FromObject(preguntas);
            //creamos el streamWritter que es el elemento que escribirá en el archivo que recibe por parametre
            StreamWriter ficheroSalida = File.CreateText(path_json);
            //definimos el fichero de tipo json
            JsonTextWriter jsonTextWriter = new JsonTextWriter(ficheroSalida);
            //añadimos elementos del array en fichero json
            arrayPreguntas.WriteTo(jsonTextWriter);
            //cerramos todo
            ficheroSalida.Close();
            jsonTextWriter.Close();
        }
        //evento que responde al clic en el boton buscar
        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            //llamamos a metodo buscar
            buscar();
        }
        //meotdo buscar
        private void buscar()
        {
            //capturamos un idiom y un tema del comboBox
            string idioma = cmbFiltrarIdioma.Text;
            string tema = cmbFiltrarTema.Text;
            //borramos elementos de preguntasFiltrada
            BindingList<Pregunta> preguntasFiltrada = null;

            switch (idioma)
            {
                //segun idioma cargamos en bindingList preguntasFiltrada elementos con instruccion where.
                //miramos que la pregunta contenga el texto que ha escrito el usuario en el textBox i coincida con el tema
                //todas las preguntas que coincidan con el criterio se pondrán dentro la bindingList filtrada
                case "Castellano":
                    preguntasFiltrada = new BindingList<Pregunta>(preguntas_es.Where(p => p.pregunta.ToLower().Contains(tbFiltrarPregunta.Text) && p.tema.Contains(tema)).ToList<Pregunta>());
                    break;
                case "Català":
                    preguntasFiltrada = new BindingList<Pregunta>(preguntas_ca.Where(p => p.pregunta.ToLower().Contains(tbFiltrarPregunta.Text) && p.tema.Contains(tema)).ToList<Pregunta>());
                    break;
                case "English":
                    preguntasFiltrada = new BindingList<Pregunta>(preguntas_en.Where(p => p.pregunta.ToLower().Contains(tbFiltrarPregunta.Text) && p.tema.Contains(tema)).ToList<Pregunta>());
                    break;
            }

            //Ordenar las preguntas por el id.
            preguntasFiltrada = new BindingList<Pregunta>(preguntasFiltrada.OrderBy(p => p.id).ToList());
            //mostramos en dataGrid los valores seleccionados
            dgvPreguntas.DataSource = preguntasFiltrada;
            dgvPreguntas.ClearSelection();
        }
        //al cerrar el formulario
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Ordenar las preguntas por el id.
            preguntas_es = new BindingList<Pregunta>(preguntas_es.OrderBy(p => p.id).ToList());
            preguntas_ca = new BindingList<Pregunta>(preguntas_ca.OrderBy(p => p.id).ToList());
            preguntas_en = new BindingList<Pregunta>(preguntas_en.OrderBy(p => p.id).ToList());
            //llamamos al metodo guardar para cada bindingList y sobreescribimos el fichero
            GuardarPreguntas(preguntas_es, PREGUNTAS_JSON_ES);
            GuardarPreguntas(preguntas_ca, PREGUNTAS_JSON_CA);
            GuardarPreguntas(preguntas_en, PREGUNTAS_JSON_EN);
        }
        //evento al clicar en boton Añadir
        private void btnAnadir_Click(object sender, System.EventArgs e)
        {
            //creamos un nuevo formulario para añadir pregunta i le pasamos por parametro kas 3 bindingList
            InsertarModificarPregunta nuevaPregunta = new InsertarModificarPregunta(preguntas_es, preguntas_ca, preguntas_en);
            //mostramos formulario
            nuevaPregunta.ShowDialog();
            //una vez regresamos refrescamos dataGrid
            buscar();
        }
        //funcion para modificar una pregunta que responde al evento clic
        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            //comprobamos si hay seleccionada una celda
            if (dgvPreguntas.SelectedCells.Count > 0)
            {
                //capturamos el objeto pregunta con el DataBoundItm de la fila seleccionada 
                Pregunta preguntaSeleccionada = (Pregunta)dgvPreguntas.Rows[dgvPreguntas.SelectedCells[0].RowIndex].DataBoundItem;
                //creamos nuevo formulario con el segundo constructor pasandole la pregunta por parametro
                InsertarModificarPregunta modificarPregunta = new InsertarModificarPregunta(preguntaSeleccionada);
                //mostramos formulario
                modificarPregunta.ShowDialog();
                //al regresar refrescamos datagrid
                buscar();
            }
        }
        //metodo para eliminar que responde al click sobre icono
        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            //comprobamos que haya una pregunta seleccionada
            if (dgvPreguntas.SelectedCells.Count > 0)
            {
                //guardamos en objeto pregunta la seleccion
                Pregunta preguntaSeleccionada = (Pregunta)dgvPreguntas.Rows[dgvPreguntas.SelectedCells[0].RowIndex].DataBoundItem;
                //nos aseguramos que realmente se quiera eliminar la pregunta con dialogo
                DialogResult opcion = MessageBox.Show("¿Estás seguro que quieres eliminar la pregunta?", "Eliminar pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //en caso afirmativo ejecutamos codigo segun idioma de la pregunta
                if (opcion == DialogResult.Yes)
                {
                    switch (preguntaSeleccionada.idioma)
                    {
                        //eliminamos de la bindingList que corresponda el elemento seleccionado
                        case "Castellano":
                            preguntas_es.Remove(preguntaSeleccionada);
                            break;
                        case "Català":
                            preguntas_ca.Remove(preguntaSeleccionada);
                            break;
                        case "English":
                            preguntas_en.Remove(preguntaSeleccionada);
                            break;
                    }
                }
                buscar();
            }
        }
        //evento clic al boton de guardar
        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            //Ordenar las preguntas por el id.
            preguntas_es = new BindingList<Pregunta>(preguntas_es.OrderBy(p => p.id).ToList());
            preguntas_ca = new BindingList<Pregunta>(preguntas_ca.OrderBy(p => p.id).ToList());
            preguntas_en = new BindingList<Pregunta>(preguntas_en.OrderBy(p => p.id).ToList());
            //ejecutamos metodo para guardar preguntas en archivo
            GuardarPreguntas(preguntas_es, PREGUNTAS_JSON_ES);
            GuardarPreguntas(preguntas_ca, PREGUNTAS_JSON_CA);
            GuardarPreguntas(preguntas_en, PREGUNTAS_JSON_EN);

            MessageBox.Show("Guardado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //funcion al salir
        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            //Ordenar las preguntas por el id.
            preguntas_es = new BindingList<Pregunta>(preguntas_es.OrderBy(p => p.id).ToList());
            preguntas_ca = new BindingList<Pregunta>(preguntas_ca.OrderBy(p => p.id).ToList());
            preguntas_en = new BindingList<Pregunta>(preguntas_en.OrderBy(p => p.id).ToList());
            //guardamos las bindingList en archivos de manera automatica
            GuardarPreguntas(preguntas_es, PREGUNTAS_JSON_ES);
            GuardarPreguntas(preguntas_ca, PREGUNTAS_JSON_CA);
            GuardarPreguntas(preguntas_en, PREGUNTAS_JSON_EN);

            this.Close();
        }
        //evento doble click para abrir nuevo formulario de verPregunta con la pregunta seleccionada
        private void dgvPreguntas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //comprobamos que la seleccion sea superior a 0 ya que cabecera cuenta
            if (e.RowIndex >= 0)
            {
                //capturamos pregunta seleccionada
                Pregunta pregunta = (Pregunta)dgvPreguntas.Rows[e.RowIndex].DataBoundItem;
                //nuevo formulario pasando pregunta por parametro
                VerRespuestas verRespuestas = new VerRespuestas(pregunta);
                //abrimos formulario
                verRespuestas.ShowDialog();
            }
        }
        //evento click sobre el icono personajes 
        private void btnPersonajes_Click(object sender, System.EventArgs e)
        {
            //creamos nuevo formulario gestionarPersonaje
            GestionarPersonajes gestionarPersonaje = new GestionarPersonajes();
            //y lo mostramos
            gestionarPersonaje.ShowDialog();
        }
    }
}
