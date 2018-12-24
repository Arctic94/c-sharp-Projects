using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pasajes.Datos;

namespace Pasajes.Negocio
{
    public class Pasaje
    {
        #region campos de objeto


        /*private int _id { get; set; }
        private string _nombrePasajero{get;set;}
        private string _rutPasajero{get;set;}
        private string _fechaNacimiento{get;set;}
        private string _sexo{get;set;}
        private string _direccionPasajero{get;set;}
        private string _telefonoAccidente{get;set;}
        private string _telefonoPersonal{get;set;}
        private string _destinoViaje{get;set;}
        private string _fechaViaje{get;set;}*/

        protected int _id;
        protected string _nombrePasajero;
        protected string _rutPasajero;
        protected DateTime _fechaNacimiento;
        protected string _sexo;
        protected string _direccionPasajero;
        protected string _telefonoAccidente;
        protected string _telefonoPersonal;
        protected string _destinoViaje;
        protected DateTime _fechaViaje;

        public DateTime FechaViaje
        {
            get { return _fechaViaje; }
            set { _fechaViaje = value; }
        }
        

        public string DestinoViaje
        {
            get { return _destinoViaje; }
            set { _destinoViaje = value; }
        }
        

        public string TelefonoPersonal
        {
            get { return _telefonoPersonal; }
            set { _telefonoPersonal = value; }
        }
        

        public string TelefonoAccidente
        {
            get { return _telefonoAccidente; }
            set { _telefonoAccidente = value; }
        }
        

        public string DireccionPasajero
        {
            get { return _direccionPasajero; }
            set { _direccionPasajero = value; }
        }
        

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
        

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        

        public string RutPasajero
        {
            get { return _rutPasajero; }
            set { _rutPasajero = value; }
        }
        

        public string NombrePasajero
        {
            get { return _nombrePasajero; }
            set { _nombrePasajero = value; }
        }
        

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        

        public Pasaje(int id,string nombre,string rut, DateTime fechanacimiento,string sexo,string direccion,
            string telacc,string telper,string destino,DateTime fechaviaje)
        {
            _id = id;
            _nombrePasajero = nombre;
            _rutPasajero = rut;
            _fechaNacimiento = fechanacimiento;
            _sexo = sexo;
            _direccionPasajero = direccion;
            _telefonoAccidente = telacc;
            _telefonoPersonal = telper;
            _destinoViaje = destino;
            _fechaViaje = fechaviaje;
        }

        public Pasaje( string nombre, string rut, DateTime fechanacimiento, string sexo, string direccion,
            string telacc, string telper, string destino, DateTime fechaviaje)
        {
            
            _nombrePasajero = nombre;
            _rutPasajero = rut;
            _fechaNacimiento = fechanacimiento;
            _sexo = sexo;
            _direccionPasajero = direccion;
            _telefonoAccidente = telacc;
            _telefonoPersonal = telper;
            _destinoViaje = destino;
            _fechaViaje = fechaviaje;
        }

        public Pasaje()
        {
            // TODO: Complete member initialization
        }

       

       /* public Pasaje( string nombre, string rut, DateTime fechanacimiento, string sexo, string direccion,
            string telacc, string telper, string destino, DateTime fechaviaje)
        {
            _id = 0;
            _nombrePasajero = nombre;
            _rutPasajero = rut;
            _fechaNacimiento = fechanacimiento;
            _sexo = sexo;
            _direccionPasajero = direccion;
            _telefonoAccidente = telacc;
            _telefonoPersonal = telper;
            _destinoViaje = destino;
            _fechaViaje = fechaviaje;
        }



        public Pasaje() { }*/
        #endregion

        #region crud

        public virtual bool Create()
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                string fecha = _fechaNacimiento.ToString("u");
                fecha = fecha.Replace("Z", " ");
                fecha.Trim();
                _fechaNacimiento=Convert.ToDateTime(fecha);

                string fechav = _fechaViaje.ToString("u");
                fechav = fechav.Replace("Z", " ");
                fechav.Trim();
                _fechaViaje = Convert.ToDateTime(fechav);

                sb.Append(string.Format("insert into pasaje_base (nombre_pasajero, rut, sexo, fecha_nacimiento,direccion,telefono_emergencia,telefono_contacto,destino,fecha_viaje) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",  _nombrePasajero,_rutPasajero, _sexo, fecha,_direccionPasajero,_telefonoAccidente,_telefonoPersonal,_destinoViaje,fechav));
                Console.WriteLine(sb.ToString());
                Conector con = new Conector();
                con.EjecutarComando(sb.ToString());
                

                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual bool Read()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(string.Format("select * from pasaje_base order by id desc limit 1")); 

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

                return true;

            }
            catch
            {
                return false;

            }
        }
        public virtual bool Read1()
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

                return true;

            }
            catch
            {
                return false;

            }
        }

        public virtual bool Update()
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

                sb.Append(string.Format("update pasaje_base set nombre_pasajero='{0}', rut='{1}', sexo='{2}', fecha_nacimiento='{3}', direccion='{4}',telefono_emergencia='{5}',telefono_contacto='{6}',destino='{7}',fecha_viaje='{8}' where id={9}", _nombrePasajero,_rutPasajero, _sexo, fecha,_direccionPasajero,_telefonoAccidente,_telefonoPersonal,_destinoViaje,fechav, _id));

                Conector con = new Conector();
                con.EjecutarComando(sb.ToString());


                return true;

            }
            catch
            {
                return false;

            }

        }

        public virtual bool Delete()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(string.Format("delete from pasaje_base where id={0}", _id));

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
