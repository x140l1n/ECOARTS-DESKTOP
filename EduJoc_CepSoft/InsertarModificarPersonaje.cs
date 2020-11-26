using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace EduJoc_CepSoft
{
    public partial class InsertarModificarPersonaje : Form
    {
        private const string IDIOMAS_JSON = "idiomas.json";

        private string nombre = "";
        private string rutaImagen = "";
        private string idioma = "";
        private string descripcion = "";
        private int id = -1;

        private BindingList<Personaje> personajes_es = null;
        private BindingList<Personaje> personajes_ca = null;
        private BindingList<Personaje> personajes_en = null;

        private Personaje personajeModificar;

        private bool modificar;

        /// <summary>
        /// Cuando insertamos.
        /// </summary>
        /// <param name="personajes_es">Lista de personajes en castellano.</param>
        /// <param name="personajes_ca">Lista de personajes en catalán.</param>
        /// <param name="personajes_en">Lista de personajes en inglés.</param>
        public InsertarModificarPersonaje(BindingList<Personaje> personajes_es, BindingList<Personaje> personajes_ca, BindingList<Personaje> personajes_en)
        {
            InitializeComponent();

            this.personajes_es = personajes_es;
            this.personajes_ca = personajes_ca;
            this.personajes_en = personajes_en;

            cargarIdiomas();

            cmbIdioma.SelectedIndex = 0;

            lblId.Visible = false;

            modificar = false;
        }

        public InsertarModificarPersonaje(Personaje personajeModificar)
        {
            InitializeComponent();

            this.personajeModificar = personajeModificar;

            cargarIdiomas();

            lblId.Visible = true;
            lblId.Text = "#" + personajeModificar.id;

            cmbIdioma.SelectedIndex = cmbIdioma.Items.IndexOf(this.personajeModificar.idioma);

            txtboxNombre.Text = personajeModificar.nombre;
            txtboxDescripcion.Text = personajeModificar.descripcion;

            picboxImagen.ImageLocation = personajeModificar.rutaImagen;

            this.Text = "Modificar personaje";

            btnInsertarModificar.Text = "Modificar";

            cmbIdioma.Enabled = false;

            modificar = true;
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

        private void btnInsertarModificar_Click(object sender, EventArgs e)
        {
            if (!modificar) insertarPersonaje();
            else modificarPersonaje();
        }

        private void insertarPersonaje()
        {
            //Comprobamos que todos los campos esten rellenados para insertar.
            if (comprobarCampos())
            {
                nombre = txtboxNombre.Text;
                descripcion = txtboxDescripcion.Text;
                idioma = cmbIdioma.Text;
                rutaImagen = picboxImagen.ImageLocation;

                switch (idioma)
                {
                    case "Castellano":

                        if (personajes_es.Count > 0)
                            id = personajes_es.ElementAt<Personaje>(personajes_es.Count() - 1).id + 1;
                        else
                            id = 1;

                        Personaje personaje_es = new Personaje(id, nombre, idioma, rutaImagen, descripcion);
                        personajes_es.Add(personaje_es);

                        break;

                    case "Català":

                        if (personajes_ca.Count > 0)
                            id = personajes_ca.ElementAt<Personaje>(personajes_ca.Count() - 1).id + 1;
                        else
                            id = 1;

                        Personaje personaje_ca = new Personaje(id, nombre, idioma, rutaImagen, descripcion);
                        personajes_ca.Add(personaje_ca);

                        break;

                    case "English":

                        if (personajes_en.Count > 0)
                            id = personajes_en.ElementAt<Personaje>(personajes_en.Count() - 1).id + 1;
                        else
                            id = 1;

                        Personaje personaje_en = new Personaje(id, nombre, idioma, rutaImagen, descripcion);
                        personajes_en.Add(personaje_en);

                        break;
                }

                MessageBox.Show("Personaje creado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void modificarPersonaje()
        {
            if (comprobarCampos())
            {
                personajeModificar.nombre = txtboxNombre.Text;
                personajeModificar.descripcion = txtboxDescripcion.Text;
                personajeModificar.idioma = cmbIdioma.Text;
                personajeModificar.rutaImagen = picboxImagen.ImageLocation;
            }
        }

        public bool comprobarCampos()
        {
            bool correcto = true;

            if (string.IsNullOrEmpty(cmbIdioma.Text.Trim()))
            {
                correcto = false;
                errorProvider.Clear();
                mostrarError(cmbIdioma, "Debes seleccionar un idioma.");
            }
            else if (string.IsNullOrEmpty(txtboxNombre.Text.Trim()))
            {
                correcto = false;
                errorProvider.Clear();
                mostrarError(txtboxNombre, "Debes escribir el nombre del personaje.");
            }
            else if (string.IsNullOrEmpty(txtboxDescripcion.Text.Trim()))
            {
                correcto = false;
                errorProvider.Clear();
                mostrarError(txtboxDescripcion, "Debes escribir la descripción del personaje.");
            }
            else if (picboxImagen.Image == null)
            {
                correcto = false;
                errorProvider.Clear();
                mostrarError(picboxImagen, "Debes seleccionar una imagen.");
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

        /// <summary>
        /// Mostrar error.
        /// </summary>
        /// <param name="pictureBox">El pictureBox con el que vamos a trabajar.</param>
        /// <param name="missatge">El mensaje de error que vamos a mostrar.</param>
        public void mostrarError(PictureBox pictureBox, string missatge)
        {
            errorProvider.SetError(pictureBox, missatge);

            //Mostrem el missatge també en un lloc visible del formulari.
            lblError.Text = missatge.ToUpper();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    openFileDialog.Filter = ""
                    string imagen = openFileDialog.FileName;
                    picboxImagen.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
