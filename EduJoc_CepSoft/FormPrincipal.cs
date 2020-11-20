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
        private const string PREGUNTAS_JSON_ES = "//Preguntas//preguntas_es.json";
        private const string PREGUNTAS_JSON_CA = "//Preguntas//preguntas_ca.json";
        private const string PREGUNTAS_JSON_EN = "//Preguntas//preguntas_en.json";

        private BindingList<Pregunta> preguntas;

        public FormPrincipal()
        {
            InitializeComponent();

            preguntas = new BindingList<Pregunta>();

            cmbFiltrarIdioma.SelectedIndex = 0;

            this.AcceptButton = btnBuscar;
        }

        private void CargarPreguntas()
        {
            if (File.Exists(PREGUNTAS_JSON_ES))
            {
                JArray arrayPreguntas = JArray.Parse(File.ReadAllText(PREGUNTAS_JSON_ES));
                preguntas = arrayPreguntas.ToObject<BindingList<Pregunta>>();
            }

            dgvPreguntas.DataSource = preguntas;
        }

        private void GuardarPreguntas()
        {
            JArray arrayPreguntas = (JArray)JToken.FromObject(preguntas);
            StreamWriter ficheroSalida = File.CreateText(PREGUNTAS_JSON_ES);
            JsonTextWriter jsonTextWriter = new JsonTextWriter(ficheroSalida);

            arrayPreguntas.WriteTo(jsonTextWriter);
            ficheroSalida.Close();
            jsonTextWriter.Close();
        }

        private void FormPrincipal_Load(object sender, System.EventArgs e)
        {
            CargarPreguntas();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarPreguntas();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            dgvPreguntas.DataSource = new BindingList<Pregunta>(preguntas.Where(p => p.pregunta.Contains(tbFiltrarPregunta.Text)).ToList<Pregunta>());
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
