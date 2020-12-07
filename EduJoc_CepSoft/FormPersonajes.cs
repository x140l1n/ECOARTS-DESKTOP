using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EduJoc_CepSoft
{
    public partial class FormPersonajes : Form
    {
        private const string PERSONAJES_JSON_ES = ".//personajes//personajes_es.json";
        private const string PERSONAJES_JSON_EN = ".//personajes//personajes_en.json";
        private const string PERSONAJES_JSON_CA = ".//personajes//personajes_ca.json";


        private const string IDIOMAS_JSON = "idiomas.json";

        private BindingList<Personaje> personajes_es;
        private BindingList<Personaje> personajes_ca;
        private BindingList<Personaje> personajes_en;

        public FormPersonajes()
        {
            InitializeComponent();

            personajes_es = new BindingList<Personaje>();
            personajes_ca = new BindingList<Personaje>();
            personajes_en = new BindingList<Personaje>();
        }

        private void GestionarPersonajes_Load(object sender, EventArgs e)
        {
            CargarIdiomas();

            CargarPersonajes(ref personajes_es, PERSONAJES_JSON_ES);
            CargarPersonajes(ref personajes_ca, PERSONAJES_JSON_CA);
            CargarPersonajes(ref personajes_en, PERSONAJES_JSON_EN);

            cmbFiltrarIdioma.SelectedIndex = 0;

            string idioma = cmbFiltrarIdioma.SelectedItem.ToString();

            switch (idioma)
            {
                case "Castellano": dgvPersonajes.DataSource = personajes_es; break;
                case "Català": dgvPersonajes.DataSource = personajes_ca; break;
                case "English": dgvPersonajes.DataSource = personajes_en; break;
            }

            dgvPersonajes.ClearSelection();
        }

        /// <summary>
        /// Cargamos los personajes de nuestros json.
        /// </summary>
        /// <param name="personajes">BindingList donde cargaremos los personajes</param>
        /// <param name="path_json">Ruta del json que vamos a cargar</param>
        private void CargarPersonajes(ref BindingList<Personaje> personajes, string path_json)
        {
            if (File.Exists(path_json))
            {
                JArray arrayPreguntas = JArray.Parse(File.ReadAllText(path_json));
                personajes = arrayPreguntas.ToObject<BindingList<Personaje>>();
            }
        }

        /// <summary>
        /// Función para cargar los idiomas en la combobox.
        /// </summary>
        private void CargarIdiomas()
        {
            if (File.Exists(IDIOMAS_JSON))
            {
                JArray arrayIdiomes = JArray.Parse(File.ReadAllText(IDIOMAS_JSON));

                foreach (string idioma in arrayIdiomes.ToArray())
                    cmbFiltrarIdioma.Items.Add(idioma);
            }
        }

        /// <summary>
        /// Función para guardar los personajes (Llamaremos a esta función cuando le demos click al botón de guardar o bien cuando cerremos el formulario).
        /// </summary>
        /// <param name="personajes"></param>
        /// <param name="path_json"></param>
        private void GuardarPersonajes(BindingList<Personaje> personajes, string path_json)
        {
            path_json = path_json.ToLower();
            JArray arrayPersonajes = (JArray)JToken.FromObject(personajes);
            StreamWriter ficheroSalida = File.CreateText(path_json);
            JsonTextWriter jsonTextWriter = new JsonTextWriter(ficheroSalida);

            arrayPersonajes.WriteTo(jsonTextWriter);
            ficheroSalida.Close();
            jsonTextWriter.Close();
        }

        /// <summary>
        /// Función para realizar una búsqueda en función del idioma seleccionado y el texto de la TextBox con el nombre del personaje.
        /// Esta función la llamaremos para actualizar nuestra grid cuando sea necesario.
        /// </summary>
        private void buscar()
        {
            string idioma = cmbFiltrarIdioma.Text;

            BindingList<Personaje> PersonajesFiltrados = null;

            switch (idioma)
            {
                case "Castellano":
                    PersonajesFiltrados = new BindingList<Personaje>(personajes_es.Where(p => p.nombre.ToLower().Contains(tbFiltrarPersonaje.Text.ToLower())).ToList<Personaje>());
                    break;
                case "Català":
                    PersonajesFiltrados = new BindingList<Personaje>(personajes_ca.Where(p => p.nombre.ToLower().Contains(tbFiltrarPersonaje.Text.ToLower())).ToList<Personaje>());
                    break;
                case "English":
                    PersonajesFiltrados = new BindingList<Personaje>(personajes_en.Where(p => p.nombre.ToLower().Contains(tbFiltrarPersonaje.Text.ToLower())).ToList<Personaje>());
                    break;
            }

            //Ordenar los personajes por el id.
            PersonajesFiltrados = new BindingList<Personaje>(PersonajesFiltrados.OrderBy(p => p.id).ToList());
            //Actualizamos los datos de la grid.
            dgvPersonajes.DataSource = PersonajesFiltrados;
            dgvPersonajes.ClearSelection();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void GestionarPersonajes_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Ordenar los personajes por el id.
            personajes_es = new BindingList<Personaje>(personajes_es.OrderBy(p => p.id).ToList());
            personajes_ca = new BindingList<Personaje>(personajes_ca.OrderBy(p => p.id).ToList());
            personajes_en = new BindingList<Personaje>(personajes_en.OrderBy(p => p.id).ToList());

            //Cuando cerremos el formulario, guardamos el estado actual de nuestra grid.
            GuardarPersonajes(personajes_es, PERSONAJES_JSON_ES);
            GuardarPersonajes(personajes_ca, PERSONAJES_JSON_CA);
            GuardarPersonajes(personajes_en, PERSONAJES_JSON_EN);
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            InsertarModificarPersonaje nuevoPersonaje = new InsertarModificarPersonaje(personajes_es, personajes_ca, personajes_en);
            nuevoPersonaje.ShowDialog();

            ActualizarGrid();
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (dgvPersonajes.SelectedCells.Count > 0)
            {
                //Instanciamos un objeto de la clase Personaje con los datos de la fila que hayamos seleccionado.
                Personaje personajeSeleccionado = (Personaje)dgvPersonajes.Rows[dgvPersonajes.SelectedCells[0].RowIndex].DataBoundItem;
                //Dependiendo del idioma del personaje, abriremos un nuevo formulario para modificarlo.
                switch (personajeSeleccionado.idioma)
                {
                    case "Castellano":
                        InsertarModificarPersonaje modificarPersonajeEs = new InsertarModificarPersonaje(personajeSeleccionado, personajes_es);
                        modificarPersonajeEs.ShowDialog();

                        break;

                    case "Català":
                        InsertarModificarPersonaje modificarPersonajeCa = new InsertarModificarPersonaje(personajeSeleccionado, personajes_ca);
                        modificarPersonajeCa.ShowDialog();

                        break;

                    case "English":
                        InsertarModificarPersonaje modificarPersonajeEn = new InsertarModificarPersonaje(personajeSeleccionado, personajes_en);
                        modificarPersonajeEn.ShowDialog();

                        break;
                }
                //Actualizamos la grid una vez hayamos terminado de modificar el personaje.
                ActualizarGrid();
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (dgvPersonajes.SelectedCells.Count > 0)
            {
                //Instanciamos un objeto de la clase Personaje con los datos de la fila que hayamos seleccionado.
                Personaje personajeSeleccionado = (Personaje)dgvPersonajes.Rows[dgvPersonajes.SelectedCells[0].RowIndex].DataBoundItem;
                //Mostramos mensaje de confirmación. 
                DialogResult opcion = MessageBox.Show("¿Estás seguro que quieres eliminar el personaje?", "Eliminar personaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {
                    //En caso de que aceptemos, eliminamos el personaje dependiendo del idioma que tenga como atributo.
                    switch (personajeSeleccionado.idioma)
                    {
                        case "Castellano":
                            personajes_es.Remove(personajeSeleccionado);
                            break;
                        case "Català":
                            personajes_ca.Remove(personajeSeleccionado);
                            break;
                        case "English":
                            personajes_en.Remove(personajeSeleccionado);
                            break;
                    }

                    //Actualizamos la grid una vez hayamos eliminado el personaje.
                    ActualizarGrid();

                    //Guardamos la ruta para luego borrar la imagen.
                    string ruta = personajeSeleccionado.rutaImagen;

                    //Borrar de la memória el objeto.
                    personajeSeleccionado = null;

                    //Una vez borrado el objeto podemos eliminar la imagen sin problemas sin que nos de error de que está en uso.
                    File.Delete(ruta);
                }
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            //Ordenar los personajes por el id.
            personajes_es = new BindingList<Personaje>(personajes_es.OrderBy(p => p.id).ToList());
            personajes_ca = new BindingList<Personaje>(personajes_ca.OrderBy(p => p.id).ToList());
            personajes_en = new BindingList<Personaje>(personajes_en.OrderBy(p => p.id).ToList());

            GuardarPersonajes(personajes_es, PERSONAJES_JSON_ES);
            GuardarPersonajes(personajes_ca, PERSONAJES_JSON_CA);
            GuardarPersonajes(personajes_en, PERSONAJES_JSON_EN);
            //Mostramos mensaje para saber que se ha guardado correctamente.
            MessageBox.Show("Guardado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            //Ordenar los personajes por el id.
            personajes_es = new BindingList<Personaje>(personajes_es.OrderBy(p => p.id).ToList());
            personajes_ca = new BindingList<Personaje>(personajes_ca.OrderBy(p => p.id).ToList());
            personajes_en = new BindingList<Personaje>(personajes_en.OrderBy(p => p.id).ToList());
            //Cuando cerremos el formulario, guardamos el estado actual de nuestra grid.
            GuardarPersonajes(personajes_es, PERSONAJES_JSON_ES);
            GuardarPersonajes(personajes_ca, PERSONAJES_JSON_CA);
            GuardarPersonajes(personajes_en, PERSONAJES_JSON_EN);

            this.Close();
        }

        /// <summary>
        /// Función para actualizar la grid cuando insertemos un nuevo personaje, modifiquemos u eliminemos uno existente.
        /// </summary>
        private void ActualizarGrid()
        {
            string idioma = cmbFiltrarIdioma.SelectedItem.ToString();

            switch (idioma)
            {
                case "Castellano": dgvPersonajes.DataSource = personajes_es; break;
                case "Català": dgvPersonajes.DataSource = personajes_ca; break;
                case "English": dgvPersonajes.DataSource = personajes_en; break;
            }

            dgvPersonajes.ClearSelection();
            dgvPersonajes.Refresh();
        }

        private void tbFiltrarPersonaje_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void cmbFiltrarIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
