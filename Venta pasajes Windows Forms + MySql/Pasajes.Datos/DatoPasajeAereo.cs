using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pasajes.Datos
{
    public class DatoPasajeAereo
    {
        

        public int Id_aereo { get; set; }
        public string Nombre_aeropuerto { get; set; }
        public string Tipo_aeronave { get; set; }
        public int Id_pasaje { get; set; }
    }
}
