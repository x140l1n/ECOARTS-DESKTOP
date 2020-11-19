using System;

namespace EduJoc_CepSoft
{
    public class Pregunta : IEquatable<Pregunta>
    {
        public int id { set; get; }
        public string tema { set; get; }
        public string idioma { set; get; }
        public string pregunta { set; get; }

        public Pregunta(int id, string tema, string idioma, string pregunta)
        {
            this.id = id;
            this.tema = tema ?? throw new ArgumentNullException(nameof(tema));
            this.idioma = idioma ?? throw new ArgumentNullException(nameof(idioma));
            this.pregunta = pregunta ?? throw new ArgumentNullException(nameof(pregunta));
        }

        /// <summary>
        /// Comprobar si las dos preguntas son iguales.
        /// </summary>
        /// <param name="other">La pregunta que vamos a comparar.</param>
        /// <returns>Devuelve true si las dos preguntas son iguales, caso contrario, false.</returns>
        public bool Equals(Pregunta other)
        {
            return (this.pregunta.Equals(other.pregunta) && this.tema.Equals(other.tema) && this.idioma.Equals(other.idioma));
        }
    }
}
