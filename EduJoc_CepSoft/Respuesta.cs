using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduJoc_CepSoft
{
    public class Respuesta
    {
        public String respuesta { get; set; }
        public bool correcta { get; set; }

        public Respuesta(String respuesta, bool correcta)
        {
            this.respuesta = respuesta;
            this.correcta = correcta;
        }
    }
}
