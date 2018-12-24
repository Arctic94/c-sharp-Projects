using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pasajes.Datos
{
    public class DatoPasaje
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Rut { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string TelefonoAccidente { get; set; }
        public string TelefonoPersonal { get; set; }
        public string Destino { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaViaje { get; set; }

    }
}
