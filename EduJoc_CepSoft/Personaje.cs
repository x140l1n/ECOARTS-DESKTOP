using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduJoc_CepSoft
{
    public class Personaje : IEquatable<Personaje>
    {
        public int id { set; get; }
        public String nombre { set; get; }
        public string idioma { set; get; }
        public String rutaImagen { set; get; }
        public String descripcion { set; get; }

        public Personaje(int id, string nombre, string idioma, string rutaImagen, string descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.idioma = idioma;
            this.rutaImagen = rutaImagen;
            this.descripcion = descripcion;
        }

        /// <summary>
        /// Comprobar si dos personajes son iguales. Para ello comparamos el nombre y el idioma.
        /// </summary>
        /// <param name="other">Personaje que vamos a comparar.</param>
        /// <returns>Devuelve true en caso de que los dos personajes sean iguales.</returns>
        public bool Equals(Personaje other)
        {
            return (this.nombre.Equals(other.nombre) && this.idioma.Equals(other.idioma));
        }
    }
}
