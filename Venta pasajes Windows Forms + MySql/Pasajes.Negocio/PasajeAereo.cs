using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pasajes.Datos;

namespace Pasajes.Negocio
{
    public class PasajeAereo:Pasaje
    {
        private int _idAereo;
        private string _nombreAeropuerto;
        private string _tipoAeronave; 

        public int IdAereo
        {
            get { return _idAereo; }
            set { _idAereo = value; }
        }


        public string NombreAeropuerto
        {
            get { return _nombreAeropuerto; }
            set { _nombreAeropuerto = value; }
        }


        public string TipoAeronave
        {
            get { return _tipoAeronave; }
            set { _tipoAeronave = value; }
        }


        

        public PasajeAereo(int id,string nombre, string rut, DateTime fechanacimiento, string sexo, string direccion,
            string telacc, string telper, string destino, DateTime fechaviaje, string nomAero,string tipoAero,int idAereo):base(id,nombre,rut,fechanacimiento,sexo,direccion,telacc,telper,destino,fechaviaje)
        {
            _idAereo = idAereo;
            _nombreAeropuerto = nomAero;
            _tipoAeronave = tipoAero;
        }

        public PasajeAereo(string nombre, string rut, DateTime fechanacimiento, string sexo, string direccion,
            string telacc, string telper, string destino, DateTime fechaviaje, string nomAero, string tipoAero, int idAereo)
            : base(nombre, rut, fechanacimiento, sexo, direccion, telacc, telper, destino, fechaviaje)
        {
            
            _idAereo = idAereo;
            _nombreAeropuerto = nomAero;
            _tipoAeronave = tipoAero;
        }



        public PasajeAereo():base()
        {
            // TODO: Complete member initialization
        }

        

        #region crud aereo

        public bool CreatePasajeAereo()
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
                //Console.WriteLine(sb.ToString());
                Conector con = new Conector();
                //con.EjecutarComando(sb.ToString());




                sb.Append(string.Format("insert into pasaje_aereo (codigo,id_pasaje,terminal_aerea, tipo_aeronave) values ({0},{1},'{2}','{3}')", _idAereo,_id, _nombreAeropuerto, _tipoAeronave));
                Console.WriteLine(sb.ToString());
                
                con.EjecutarComando(sb.ToString());





                return true;
            }
            catch
            {
                return false;
            }
        }

        public  bool ReadPasajeAereo()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(string.Format("select * from pasaje_base where id={0}", _id));

                Conector con = new Conector();

                DatoPasaje dp = con.ObtienePasaje(sb.ToString());

                Id = dp.Id;
                RutPasajero = dp.Rut;
                NombrePasajero = dp.Nombre;
                FechaNacimiento = dp.FechaNacimiento;
                Sexo = dp.Sexo;
                DireccionPasajero = dp.Direccion;
                TelefonoAccidente = dp.TelefonoAccidente;
                TelefonoPersonal = dp.TelefonoPersonal;
                DestinoViaje = dp.Destino;
                FechaViaje = dp.FechaViaje;

                sb=sb.Clear();
                sb.Append(string.Format("select * from pasaje_aereo where codigo={0}", _idAereo));

                DatoPasajeAereo dpa = con.ObtienePasajeAereo(sb.ToString());

                IdAereo = dpa.Id_aereo;
                Id = dpa.Id_pasaje;
                NombreAeropuerto = dpa.Nombre_aeropuerto;
                TipoAeronave = dpa.Tipo_aeronave;

                return true;

            }
            catch
            {
                return false;

            }
        }

        public bool EliminarPasajeAereo()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                

                
                //con.EjecutarComando(sb.ToString());

                
                sb.Append(string.Format("delete from pasaje_aereo where id_pasaje={0}", _id));
                sb.Append(string.Format("; delete from pasaje_terrestre where id_pasaje={0}", _id));
                sb.Append(string.Format("; delete from pasaje_marino where id_pasaje={0}", _id));
                sb.Append(string.Format("; delete from pasaje_base where id={0}", _id));
                Conector con = new Conector();
                con.EjecutarComando(sb.ToString());


                return true;

            }
            catch
            {
                return false;

            }
        }

        #endregion

    }
    
    
    
}
