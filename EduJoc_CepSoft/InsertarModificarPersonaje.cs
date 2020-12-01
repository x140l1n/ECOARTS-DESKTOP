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
        private string idioma = "";
        private string descripcion = "";
        private int id = -1;

        private BindingList<Personaje> personajes_es = null;
        private BindingList<Personaje> personajes_ca = null;
        private BindingList<Personaje> personajes_en = null;

        private Personaje personajeModificar;
        private BindingList<Personaje> personajes = null;

        private bool modificar;

        private const string RUTA_DIRECTORIO_IMG = ".//Personajes//img//";

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
            
            //Idioma predeterminado (castellano).
            cmbIdioma.SelectedIndex = 0;

            //Cuando insertamos un nuevo personaje no queremos que se vea su id (solo cuando lo modificamos).
            lblId.Visible = false;

            modificar = false;
        }

        /// <summary>
        /// Cuando modificamos.
        /// </summary>
        /// <param name="personajeModificar">El personaje que vamos a modificar.</param>
        /// <param name="personajes">Lista de personajes.</param>
        public InsertarModificarPersonaje(Personaje personajeModificar, BindingList<Personaje> personajes)
        {
            InitializeComponent();

            this.personajeModificar = personajeModificar;
            this.personajes = personajes;
            this.id = personajeModificar.id;

            cargarIdiomas();

            //Al modificar un personaje, mostramos su id.
            lblId.Visible = true;
            lblId.Text = "#" + personajeModificar.id;

            //Cargamos los datos del personaje que queremos modificar.
            cmbIdioma.SelectedIndex = cmbIdioma.Items.IndexOf(this.personajeModificar.idioma);

            txtboxNombre.Text = personajeModificar.nombre;
            txtboxDescripcion.Text = personajeModificar.descripcion;

            picboxImagen.ImageLocation = personajeModificar.rutaImagen;

            this.Text = "Modificar personaje";

            btnInsertarModificar.Text = "Modificar";

            //El idioma no será un campo modificable.
            cmbIdioma.Enabled = false;

            modificar = true;
        }

        /// <summary>
        /// Función para cargar los idiomas del json en la combobox.
        /// </summary>
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
            //Dependiendo del valor del bool "modificar", entraremos en la función para insertar un nuevo personaje o modificar uno ya existente.
            if (!modificar) insertarPersonaje();
            else modificarPersonaje();
        }

        private void insertarPersonaje()
        {
            //Comprobamos que todos los campos esten rellenados para insertar.
            if (comprobarCampos())
            {
                //Con el .Trim() quitamos los espacios en blanco al final del array.
                nombre = txtboxNombre.Text.Trim();
                descripcion = txtboxDescripcion.Text.Trim();
                idioma = cmbIdioma.Text.Trim();

                if (!existePersonaje(nombre, idioma))
                {
                    //Guardamos la ruta de la imagen que hemos seleccionado para nuestro personaje y la movemos a nuestra carpeta img.
                    string rutaImagenOrigen = picboxImagen.ImageLocation;
                    string rutaImagenDestino="";



                    switch (idioma)
                    {
                        case "Castellano":
                            //En caso de que ya haya un personaje, busquem la ultima id y le damos el siguiente valor.
                            if (personajes_es.Count > 0)
                                id = personajes_es.ElementAt<Personaje>(personajes_es.Count() - 1).id + 1;
                            //Si no existe ningún personaje, su id será 1.
                            else
                                id = 1;
                            //Instanciamos el nuevo personaje y lo añadimos a la BindingList de personajes.
                           rutaImagenDestino = moverImagen(rutaImagenOrigen, RUTA_DIRECTORIO_IMG, id, "es");
                            Personaje personaje_es = new Personaje(id, nombre, idioma, rutaImagenDestino, descripcion);
                            personajes_es.Add(personaje_es);

                            break;

                        case "Català":

                            if (personajes_ca.Count > 0)
                                id = personajes_ca.ElementAt<Personaje>(personajes_ca.Count() - 1).id + 1;
                            else
                                id = 1;

                            rutaImagenDestino = moverImagen(rutaImagenOrigen, RUTA_DIRECTORIO_IMG, id, "ca");
                            Personaje personaje_ca = new Personaje(id, nombre, idioma, rutaImagenDestino, descripcion);
                            personajes_ca.Add(personaje_ca);

                            break;

                        case "English":

                            if (personajes_en.Count > 0)
                                id = personajes_en.ElementAt<Personaje>(personajes_en.Count() - 1).id + 1;
                            else
                                id = 1;

                            rutaImagenDestino = moverImagen(rutaImagenOrigen, RUTA_DIRECTORIO_IMG, id, "en");
                            Personaje personaje_en = new Personaje(id, nombre, idioma, rutaImagenDestino, descripcion);
                            personajes_en.Add(personaje_en);

                            break;
                    }
                    //Mostramos un MessageBox con el mensaje siguiente:
                    MessageBox.Show("Personaje creado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                //Si el nombre e idioma del personaje que queremos insertar ya está en nuestro json, damos un mensaje de error.
                else
                {
                    errorProvider.Clear();
                    mostrarError(txtboxNombre, "Ya existe este personaje.");
                }
            }
        }

        /// <summary>
        /// Función para comprobar si un personaje ya existe.
        /// </summary>
        /// <param name="nombre">Nombre del personaje que queremos insertar (Ya sea al crear o modificar uno existente).</param>
        /// <param name="idioma">Idioma del personaje que queremos insertar (Ya sea al crear o modificar uno existente).</param>
        /// <returns>Nos retornará un valor true en caso de que el personaje que queramos insertar ya exista, false si no existe.</returns>
        private bool existePersonaje(string nombre, string idioma)
        {
            bool existe = false;
            int index = 0;
            //En caso de que estemos insertando un nuevo personaje: 
            if (!modificar)
            {
                switch (idioma)
                {
                    case "Castellano":
                        //Bucle para recorrer la lista de personajes mientras no encontremos uno que coincida o terminemos de recorrer la lista.
                        while (!existe && personajes_es.Count > index)
                        {
                            if (personajes_es[index].Equals(nombre))
                                existe = true;

                            index++;
                        }

                        break;

                    case "Català":
                        while (!existe && personajes_ca.Count > index)
                        {
                            if (personajes_ca[index].Equals(nombre))
                                existe = true;

                            index++;
                        }

                        break;

                    case "English":

                        while (!existe && personajes_en.Count > index)
                        {
                            if (personajes_en[index].Equals(nombre))
                                existe = true;

                            index++;
                        }

                        break;
                }
            }
            //Si estamos modificando un personaje existente:
            else
            {
                //Bucle para recorrer la lista de personajes mientras no encontremos uno que coincida o terminemos de recorrer la lista.
                while (!existe && personajes.Count > index)
                {
                    //Compraramos el nombre del personaje seleccionado y su id con los de la lista. 
                    /*Comparamos la id para saber si existe otro personaje con los mismos datos o si estamos modificando un 
                    atributo de éste ya que no nos dejaria cambiar la imagen del personaje y dejarlo con el mismo nombre.*/
                    if (personajes[index].Equals(nombre) && personajes[index].id != id)
                        existe = true;

                    index++;
                }
            }
            
            return existe;
        }

        /// <summary>
        /// Función para copiar la imagen que enlazemos con un personaje a nuestro directorio img.
        /// </summary>
        /// <param name="origen">Ruta de origen de la imagen.</param>
        /// <param name="destino">Ruta de destino de la imagen (directorio img)</param>
        /// <returns>Esta función nos retorna la ruta final de la imagen.</returns>
        private string moverImagen(string origen, string destino, int id, string idioma)
        {
            string nombreImagen = Path.GetFileName(origen);
            string rutaDestinoImagen = destino + nombreImagen.Split('.')[0] + "_" + idioma + "_"  + id + "." + nombreImagen.Split('.')[1];

            if (!File.Exists(rutaDestinoImagen))
                //Con el último parámetro indicamos que queremos sobreescribir la imagen en caso de que ya exista en la rutaDestinoImagen.
                File.Copy(origen, rutaDestinoImagen, true);

            return rutaDestinoImagen;
        }

        /// <summary>
        /// Función para modificar un personaje existente.
        /// </summary>
        private void modificarPersonaje()
        {
            if (comprobarCampos())
            {
                if (!existePersonaje(txtboxNombre.Text, cmbIdioma.Text))
                {
                    String idioma = "";
                    switch (cmbIdioma.Text)
                    {
                        case "Castellano": idioma = "es";
                            break;
                        case "Català": idioma = "ca";
                            break;
                        case "English": idioma = "en";
                            break;

                    }
                    //Modificamos los datos del personaje quitando los espacios al final de los string.
                    personajeModificar.nombre = txtboxNombre.Text.Trim();
                    personajeModificar.descripcion = txtboxDescripcion.Text.Trim();
                    personajeModificar.idioma = cmbIdioma.Text.Trim();
                    personajeModificar.rutaImagen = moverImagen(picboxImagen.ImageLocation, RUTA_DIRECTORIO_IMG, personajeModificar.id, idioma);

                    MessageBox.Show("Personaje modificado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    errorProvider.Clear();
                    mostrarError(txtboxNombre, "Ya existe este personaje.");
                }
            }
        }

        /// <summary>
        /// Comprobamos que los campos no estén vacíos. En caso de que lo estén, mostramos un mensaje de error.
        /// </summary>
        /// <returns>En caso de que los campos estén rellenados correctamente retornamos true, en caso contrario false.</returns>
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

            //Mostramos el mensaje también en un sitio visible del formulario.
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

            //Mostramos el mensaje también en un sitio visible del formulario.
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

            //Mostramos el mensaje también en un sitio visible del formulario.
            lblError.Text = missatge.ToUpper();
            pictureBox.Focus();
        }

        /// <summary>
        /// Función para abrir el buscador de archivos y seleccionar una imagen para el personaje.
        /// </summary>
        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            try
            {
                //Filtramos los archivos que queremos que nos salgan según sus extensiones:
                openFileDialog.Filter = "Files|*.jpg;*.jpeg;*.png;";
                //Si seleccionamos un archivo y le damos al botón "Abrir":
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    

                    //Guardamos la ruta del archivo seleccionado.
                    string ruta_imagen = openFileDialog.FileName;

                    //Mostramos en nuestra picBox la vista prévia de la imagen seleccionada.
                    picboxImagen.Image = Image.FromFile(ruta_imagen);
                    picboxImagen.ImageLocation = ruta_imagen;
                }
            }
            //En caso de que el archivo no sea una imagen, damos un mensaje de error.
            catch (Exception)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
