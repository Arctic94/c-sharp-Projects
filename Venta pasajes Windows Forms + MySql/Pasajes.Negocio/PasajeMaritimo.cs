using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pasajes.Datos;

namespace Pasajes.Negocio
{
    public class PasajeMaritimo:Pasaje
    {
        private int _idMaritimo;

        public int IdMaritimo
        {
            get { return _idMaritimo; }
            set { _idMaritimo = value; }
        }
        private string _nombreMuelle;

        public string NombreMuelle
        {
            get { return _nombreMuelle; }
            set { _nombreMuelle = value; }
        }

        public PasajeMaritimo(int id,string nombre, string rut, DateTime fechanacimiento, string sexo, string direccion,
            string telacc, string telper, string destino, DateTime fechaviaje, string nombremuelle,int idMaritimo):base(id,nombre,rut,fechanacimiento,sexo,direccion,telacc,telper,destino,fechaviaje)
        {
            IdMaritimo=idMaritimo;
            NombreMuelle=nombremuelle;
        }

        public PasajeMaritimo( string nombre, string rut, DateTime fechanacimiento, string sexo, string direccion,
            string telacc, string telper, string destino, DateTime fechaviaje, string nombremuelle, int idMaritimo)
            : base( nombre, rut, fechanacimiento, sexo, direccion, telacc, telper, destino, fechaviaje)
        {
            IdMaritimo = idMaritimo;
            NombreMuelle = nombremuelle;
        }

        public PasajeMaritimo():base()
        {
            // TODO: Complete member initialization
        }

        public bool CreatePasajeMaritimo()
        {
            try
            {

                StringBuilder sb = new StringBuilder();

                string fecha = _fechaNacimiento.ToString("u");
                fecha = fecha.Replace("Z", " ");
                fecha.Trim();
                _fechaNacimiento = Convert.ToDateTime(fecha);

                string fechav = _fechaViaje.ToString("u");
                fechav = fechav.Replace("Z", " ");
                fechav.Trim();
                _fechaViaje = Convert.ToDateTime(fechav);

               // sb.Append(string.Format("insert into pasaje_base (nombre_pasajero, rut, sexo, fecha_nacimiento,direccion,telefono_emergencia,telefono_contacto,destino,fecha_viaje) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",  _nombrePasajero, _rutPasajero, _sexo, fecha, _direccionPasajero, _telefonoAccidente, _telefonoPersonal, _destinoViaje, fechav));
                Console.WriteLine(sb.ToString());
                Conector con = new Conector();
                //con.EjecutarComando(sb.ToString());



                sb.Append(string.Format("insert into pasaje_marino (codigo,id_pasaje, nombre_muelle) values ({0},{1},'{2}')", _idMaritimo, _id, _nombreMuelle));
                Console.WriteLine(sb.ToString());

                con.EjecutarComando(sb.ToString());





                return true;
            }
            catch
            {
                return false;
            }
        }
        
        
    }
}
