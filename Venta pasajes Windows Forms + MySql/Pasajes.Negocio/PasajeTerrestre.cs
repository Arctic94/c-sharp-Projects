using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pasajes.Datos;

namespace Pasajes.Negocio
{
    public class PasajeTerrestre:Pasaje
    {
        private int _idTerrestre;

        public int IdTerrestre
        {
            get { return _idTerrestre; }
            set { _idTerrestre = value; }
        }
        private string _terminal;

        public string Terminal
        {
            get { return _terminal; }
            set { _terminal = value; }
        }
        private string _nroAsiento;

        public string NroAsiento
        {
            get { return _nroAsiento; }
            set { _nroAsiento = value; }
        }

        public PasajeTerrestre():base()
        { }
        public PasajeTerrestre(int id, string nombre, string rut, DateTime fechanacimiento, string sexo, string direccion,
            string telacc, string telper, string destino, DateTime fechaviaje, int idterr, string terminal, string nroAsiento)
            : base(id, nombre, rut, fechanacimiento, sexo, direccion, telacc, telper, destino, fechaviaje)
        {
            _idTerrestre = idterr;
            _terminal = terminal;
            _nroAsiento = nroAsiento;
        }

        public PasajeTerrestre( string nombre, string rut, DateTime fechanacimiento, string sexo, string direccion,
            string telacc, string telper, string destino, DateTime fechaviaje, int idterr, string terminal, string nroAsiento)
            : base( nombre, rut, fechanacimiento, sexo, direccion, telacc, telper, destino, fechaviaje)
        {
            _idTerrestre = idterr;
            _terminal = terminal;
            _nroAsiento = nroAsiento;
        }

        public bool CreatePasajeTerrestre()
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

                //sb.Append(string.Format("insert into pasaje_base (nombre_pasajero, rut, sexo, fecha_nacimiento,direccion,telefono_emergencia,telefono_contacto,destino,fecha_viaje) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",  _nombrePasajero, _rutPasajero, _sexo, fecha, _direccionPasajero, _telefonoAccidente, _telefonoPersonal, _destinoViaje, fechav));
                Console.WriteLine(sb.ToString());
                Conector con = new Conector();
                //con.EjecutarComando(sb.ToString());



                sb.Append(string.Format("insert into pasaje_terrestre (codigo,id_pasaje, terminal, nro_asiento) values ({0},{1},'{2}','{3}')", _idTerrestre, _id, _terminal, _nroAsiento));
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
