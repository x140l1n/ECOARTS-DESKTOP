using System;
using System.Collections.Generic;

namespace EduJoc_CepSoft
{
    public class Pregunta : IEquatable<Pregunta>
    {
        public int id { set; get; }
        public string tema { set; get; }
        public string pregunta { set; get; }

        List<Respuesta> respuestas = new List<Respuesta>();
        public Pregunta(int id, string tema, string pregunta, List<Respuesta> respuestas)
        {
            this.id = id;
            this.tema = tema ?? throw new ArgumentNullException(nameof(tema));
            this.pregunta = pregunta ?? throw new ArgumentNullException(nameof(pregunta));
            this.respuestas = respuestas;
        }

        /// <summary>
        /// Comprobar si las dos preguntas son iguales. Son iguales cuando tienen la misma pregunta y del mismo tema.
        /// </summary>
        /// <param name="other">La pregunta que vamos a comparar.</param>
        /// <returns>Devuelve true si las dos preguntas son iguales, caso contrario, false.</returns>
        public bool Equals(Pregunta other)
        {
            return (this.pregunta.Equals(other.pregunta) && this.tema.Equals(other.tema));
        }
    }
}
