using Newtonsoft.Json.Linq;
using System.Collections;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EduJoc_CepSoft
{
    public partial class InsertarPregunta : Form
    {
        private const string TEMAS_JSON = "temas.json";
        public InsertarPregunta()
        {
            InitializeComponent();
        }

        private void cargarTemas()
        {
            if (File.Exists(TEMAS_JSON))
            {
                JArray arrayTemas = JArray.Parse(File.ReadAllText(TEMAS_JSON));
                comboBoxTema.DataSource = arrayTemas.ToArray();
            }
        }
    }
}
