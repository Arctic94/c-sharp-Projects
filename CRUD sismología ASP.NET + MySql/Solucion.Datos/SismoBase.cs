using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solucion.Datos
{
    public class SismoBase
    {
        public int ID { get; set; }
        public DateTime FechaEvento { get; set; }
        public int Comuna { get; set; }
        public string Descripcion { get; set; }
        public float Profundidad { get; set; }
        public float Intensidad { get; set; }
    }
}
