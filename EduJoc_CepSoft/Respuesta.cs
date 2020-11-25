namespace EduJoc_CepSoft
{
    public class Respuesta
    {
        public string respuesta { get; set; }
        public bool correcta { get; set; }

        public Respuesta(string respuesta, bool correcta)
        {
            this.respuesta = respuesta;
            this.correcta = correcta;
        }
    }
}
