using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Solucion.Datos;

namespace Solucion.Negocio
{
    public class Comuna
    {
        private int _id;
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public Comuna()
        {
            _id = 0;
            _nombre = string.Empty;
        }

        public bool Create()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(string.Format("insert into comuna(NOMBRE) values ('{0}')", _nombre));
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
                StringBuilder sb = new StringBuilder();
                sb.Append(string.Format("select * from comuna where ID = {0};", _id));
                Conexion con = new Conexion();

                ComunaBase cm = con.ObtieneComuna(sb.ToString());

                _id = cm.ID;
                _nombre = cm.Nombre;


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

                sb.Append(string.Format("delete from comuna where id = {0};", this._id));

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
                sb.Append(string.Format("update comuna set NOMBRE = '{0}' where ID = {1};", _nombre,_id));

                Conexion con = new Conexion();
                con.EjecutarComando(sb.ToString());

                return true;
            }
            catch { return false; }
        }   


            

        
    }

   
}
