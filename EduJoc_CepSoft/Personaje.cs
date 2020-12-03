using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace EduJoc_CepSoft
{
    public class Personaje : IEquatable<string>
    {
        public int id { set; get; }
        public string nombre { set; get; }
        public string idioma { set; get; }
        public string rutaImagen { set; get; }
        [JsonIgnore]
        //El try catch nos servirá para que el programa no pete. Devolverá null, y en editar personaje podemos añadir la imagen correcta.
        public Image imagen { set { } get { try { return (Image)Resize(Image.FromFile(rutaImagen), 80, 80); } catch (Exception e) { return null; } } }
        public string descripcion { set; get; }

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
        /// <param name="nombre">El nombre que vamos a comparar.</param>
        /// <returns>Devuelve true en caso de que los dos personajes sean iguales.</returns>
        public bool Equals(string nombre)
        {
            return (this.nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }

        public static Bitmap Resize(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
