using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Solucion.Datos;

namespace Solucion.Negocio
{
    public class Sismo
    {
        private int _id;
        private int _comuna;
        private DateTime _fechaEvento;
        private float _profundidad;
        private string _descripcion;
        private float _intensidad;

        public float Intensidad
        {
            get { return _intensidad; }
            set { _intensidad = value; }
        }
        
                    
        public float Profundidad
        {
            get { return _profundidad; }
            set { _profundidad = value; }
        }
        

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        

        public DateTime FechaEvento
        {
            get { return _fechaEvento; }
            set { _fechaEvento = value; }
        }
        

        public int Comuna
        {
            get { return _comuna; }
            set { _comuna = value; }
        }
        

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Sismo()
        {
            _id = 0;
            _comuna = 0;
            _fechaEvento = DateTime.Now;
            _descripcion = string.Empty;
            _profundidad = 0;
            _intensidad = 0;
        }

        public bool Create()
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                string fecha = _fechaEvento.ToString("u");
                fecha = fecha.Remove(fecha.Length - 1);
                

                sb.Append(string.Format("insert into sismo (FECHA_EVENTO,COMUNA,PROFUNDIDAD,DESCRIPCION,INTENSIDAD) values ('{0}',{1},{2},'{3}',{4})", fecha, _comuna, _profundidad, _descripcion, _intensidad));
                Conexion con = new Conexion();
                con.EjecutarComando(sb.ToString());
                return true;
            }
            catch 
            {
                

                return false;
            }
        }

        public bool Read()
        {
            try
            {
                StringBuilder sbr = new StringBuilder();
                sbr.Append(string.Format("select * from sismo where ID = {0};", _id));
                Conexion con = new Conexion();

                SismoBase sb = con.ObtieneSismo(sbr.ToString());

                _id = sb.ID;
                _comuna = sb.Comuna;
                _descripcion = sb.Descripcion;
                _fechaEvento = sb.FechaEvento;
                _intensidad = sb.Intensidad;
                _profundidad = sb.Profundidad;

                return true;
            }
            catch 
            {

                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.Append(string.Format("delete from sismo where id = {0};", this._id));

                Conexion con = new Conexion();
                con.EjecutarComando(sb.ToString());

                return true;

            }
            catch { return false; }
        }

        public bool Update()
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                string fecha = _fechaEvento.ToString("u");
                fecha = fecha.Remove(fecha.Length - 1);
                sb.Append(string.Format("update sismo set FECHA_EVENTO='{0}', COMUNA={1}, PROFUNDIDAD={2},DESCRIPCION='{3}',INTENSIDAD={4} where ID = {5};", fecha, _comuna, _profundidad, _descripcion, _intensidad, _id));
                

                Conexion con = new Conexion();
                con.EjecutarComando(sb.ToString());

                return true;
            }
            catch { return false; }
        }   


    }
}
