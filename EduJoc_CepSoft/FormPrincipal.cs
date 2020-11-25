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
        private const string PREGUNTAS_JSON_ES = ".//Preguntas//preguntas_es.json";
        private const string PREGUNTAS_JSON_CA = ".//Preguntas//preguntas_ca.json";
        private const string PREGUNTAS_JSON_EN = ".//Preguntas//preguntas_en.json";

        private const string TEMAS_JSON = "temas.json";
        private const string IDIOMAS_JSON = "idiomas.json";

        private BindingList<Pregunta> preguntas_es;
        private BindingList<Pregunta> preguntas_ca;
        private BindingList<Pregunta> preguntas_en;

        public FormPrincipal()
        {
            InitializeComponent();

            preguntas_es = new BindingList<Pregunta>();
            preguntas_ca = new BindingList<Pregunta>();
            preguntas_en = new BindingList<Pregunta>();
        }

        private void FormPrincipal_Load(object sender, System.EventArgs e)
        {
            this.AcceptButton = btnBuscar;

            cargarTemas();
            cargarIdiomas();

            CargarPreguntas(ref preguntas_es, PREGUNTAS_JSON_ES);
            CargarPreguntas(ref preguntas_ca, PREGUNTAS_JSON_CA);
            CargarPreguntas(ref preguntas_en, PREGUNTAS_JSON_EN);

            cmbFiltrarIdioma.SelectedIndex = 0;

            string idioma = cmbFiltrarIdioma.SelectedItem.ToString();

            switch (idioma)
            {
                case "Castellano": dgvPreguntas.DataSource = preguntas_es; break;
                case "Catalán": dgvPreguntas.DataSource = preguntas_ca; break;
                case "Inglés": dgvPreguntas.DataSource = preguntas_en; break;
            }

            dgvPreguntas.ClearSelection();
        }

        private void CargarPreguntas(ref BindingList<Pregunta> preguntas, string path_json)
        {
            if (File.Exists(path_json))
            {
                JArray arrayPreguntas = JArray.Parse(File.ReadAllText(path_json));
                preguntas = arrayPreguntas.ToObject<BindingList<Pregunta>>();
            }
        }

        private void cargarTemas()
        {
            if (File.Exists(TEMAS_JSON))
            {
                JArray arrayTemas = JArray.Parse(File.ReadAllText(TEMAS_JSON));

                foreach (string tema in arrayTemas.ToArray())
                    cmbFiltrarTema.Items.Add(tema);
            }
        }

        private void cargarIdiomas()
        {
            if (File.Exists(IDIOMAS_JSON))
            {
                JArray arrayIdiomes = JArray.Parse(File.ReadAllText(IDIOMAS_JSON));

                foreach (string idioma in arrayIdiomes.ToArray())
                    cmbFiltrarIdioma.Items.Add(idioma);
            }
        }

        private void GuardarPreguntas(BindingList<Pregunta> preguntas, string path_json)
        {
            JArray arrayPreguntas = (JArray)JToken.FromObject(preguntas);
            StreamWriter ficheroSalida = File.CreateText(path_json);
            JsonTextWriter jsonTextWriter = new JsonTextWriter(ficheroSalida);

            arrayPreguntas.WriteTo(jsonTextWriter);
            ficheroSalida.Close();
            jsonTextWriter.Close();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            string idioma = cmbFiltrarIdioma.Text;
            string tema = cmbFiltrarTema.Text;

            BindingList<Pregunta> preguntasFiltrada = null;

            switch (idioma)
            {
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


            dgvPreguntas.DataSource = preguntasFiltrada;
    
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Ordenar las preguntas por el id.
            preguntas_es = new BindingList<Pregunta>(preguntas_es.OrderBy(p => p.id).ToList());
            preguntas_ca = new BindingList<Pregunta>(preguntas_ca.OrderBy(p => p.id).ToList());
            preguntas_en = new BindingList<Pregunta>(preguntas_en.OrderBy(p => p.id).ToList());

            GuardarPreguntas(preguntas_es, PREGUNTAS_JSON_ES);
            GuardarPreguntas(preguntas_ca, PREGUNTAS_JSON_CA);
            GuardarPreguntas(preguntas_en, PREGUNTAS_JSON_EN);
        }

        private void btnAnadir_Click(object sender, System.EventArgs e)
        {
            InsertarModificarPregunta nuevaPregunta = new InsertarModificarPregunta(preguntas_es, preguntas_ca, preguntas_en);
            nuevaPregunta.ShowDialog();
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            if (dgvPreguntas.SelectedCells.Count > 0)
            {
                Pregunta preguntaSeleccionada = (Pregunta)dgvPreguntas.Rows[dgvPreguntas.SelectedCells[0].RowIndex].DataBoundItem;

                InsertarModificarPregunta modificarPregunta = new InsertarModificarPregunta(preguntaSeleccionada, preguntas_es, preguntas_ca, preguntas_en);
                modificarPregunta.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            if (dgvPreguntas.SelectedCells.Count > 0)
            {
                Pregunta preguntaSeleccionada = (Pregunta)dgvPreguntas.Rows[dgvPreguntas.SelectedCells[0].RowIndex].DataBoundItem;

                DialogResult opcion = MessageBox.Show("¿Estás seguro que quieres eliminar la pregunta?", "Eliminar pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {
                    switch (preguntaSeleccionada.idioma)
                    {
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
            }
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            //Ordenar las preguntas por el id.
            preguntas_es = new BindingList<Pregunta>(preguntas_es.OrderBy(p => p.id).ToList());
            preguntas_ca = new BindingList<Pregunta>(preguntas_ca.OrderBy(p => p.id).ToList());
            preguntas_en = new BindingList<Pregunta>(preguntas_en.OrderBy(p => p.id).ToList());

            GuardarPreguntas(preguntas_es, PREGUNTAS_JSON_ES);
            GuardarPreguntas(preguntas_ca, PREGUNTAS_JSON_CA);
            GuardarPreguntas(preguntas_en, PREGUNTAS_JSON_EN);

            MessageBox.Show("Guardado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }


        private void dgvPreguntas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Pregunta pregunta = (Pregunta)dgvPreguntas.Rows[e.RowIndex].DataBoundItem;

            VerRespuestas verRespuestas = new VerRespuestas(pregunta);
            verRespuestas.ShowDialog();

        }
    }
}
