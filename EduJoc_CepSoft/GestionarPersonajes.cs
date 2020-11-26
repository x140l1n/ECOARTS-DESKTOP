using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EduJoc_CepSoft
{
    public partial class GestionarPersonajes : Form
    {
        private const string PERSONAJES_JSON_ES = ".//Personajes/personajes_es.json";
        private const string PERSONAJES_JSON_EN = ".//Personajes/personajes_en.json";
        private const string PERSONAJES_JSON_CA = ".//Personajes/personajes_ca.json";

        private const string IDIOMAS_JSON = "idiomas.json";

        private BindingList<Personaje> personajes_es;
        private BindingList<Personaje> personajes_ca;
        private BindingList<Personaje> personajes_en;

        public GestionarPersonajes()
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
                case "Catalán": dgvPersonajes.DataSource = personajes_ca; break;
                case "Inglés": dgvPersonajes.DataSource = personajes_en; break;
            }

            dgvPersonajes.ClearSelection();
        }

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
            JArray arrayPersonajes = (JArray)JToken.FromObject(personajes);
            StreamWriter ficheroSalida = File.CreateText(path_json);
            JsonTextWriter jsonTextWriter = new JsonTextWriter(ficheroSalida);

            arrayPersonajes.WriteTo(jsonTextWriter);
            ficheroSalida.Close();
            jsonTextWriter.Close();
        }

        private void buscar()
        {
            string idioma = cmbFiltrarIdioma.Text;

            BindingList<Personaje> PersonajesFiltrados = null;

            switch (idioma)
            {
                case "Castellano":
                    PersonajesFiltrados = new BindingList<Personaje>(personajes_es.Where(p => p.nombre.ToLower().Contains(tbFiltrarPersonaje.Text)).ToList<Personaje>());
                    break;
                case "Català":
                    PersonajesFiltrados = new BindingList<Personaje>(personajes_ca.Where(p => p.nombre.ToLower().Contains(tbFiltrarPersonaje.Text)).ToList<Personaje>());
                    break;
                case "English":
                    PersonajesFiltrados = new BindingList<Personaje>(personajes_en.Where(p => p.nombre.ToLower().Contains(tbFiltrarPersonaje.Text)).ToList<Personaje>());
                    break;
            }

            //Ordenar los personajes por el id.
            PersonajesFiltrados = new BindingList<Personaje>(PersonajesFiltrados.OrderBy(p => p.id).ToList());

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

            GuardarPersonajes(personajes_es, PERSONAJES_JSON_ES);
            GuardarPersonajes(personajes_ca, PERSONAJES_JSON_CA);
            GuardarPersonajes(personajes_en, PERSONAJES_JSON_EN);
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            InsertarModificarPersonaje nuevoPersonaje = new InsertarModificarPersonaje(personajes_es, personajes_ca, personajes_en);
            nuevoPersonaje.ShowDialog();

            buscar();
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (dgvPersonajes.SelectedCells.Count > 0)
            {
                Personaje personajeSeleccionado = (Personaje)dgvPersonajes.Rows[dgvPersonajes.SelectedCells[0].RowIndex].DataBoundItem;

                InsertarModificarPersonaje modificarPersonaje = new InsertarModificarPersonaje(personajeSeleccionado);
                modificarPersonaje.ShowDialog();

                buscar();
            }

        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (dgvPersonajes.SelectedCells.Count > 0)
            {
                Personaje personajeSeleccionado = (Personaje)dgvPersonajes.Rows[dgvPersonajes.SelectedCells[0].RowIndex].DataBoundItem;

                DialogResult opcion = MessageBox.Show("¿Estás seguro que quieres eliminar el personaje?", "Eliminar personaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {
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

            MessageBox.Show("Guardado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
