using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Aplicacion.Datos;



namespace Aplicacion.Negocio
{
    public class Asociacion
    {
        public int Id { get; set; }
        public string Nombre_asociacion { get; set; }
        public string Direccion { get; set; }

        public Asociacion()
        {
            Id = 0;
            Nombre_asociacion = string.Empty;
            Direccion = string.Empty;
        }

        public bool Create()
        {
            try
            {
                Datos.asociacion aso = new Datos.asociacion();

                aso.id = this.Id;
                aso.nombre_asociacion = this.Nombre_asociacion;
                aso.direccion = this.Direccion;

                Conector.Fetach.AddToasociacions(aso);
                Conector.Fetach.SaveChanges();
                
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
                Datos.asociacion aso = Conector.Fetach.asociacions.First(a => a.id == this.Id);

                this.Id = aso.id;
                this.Nombre_asociacion = aso.nombre_asociacion;
                this.Direccion = aso.direccion;

                return true;
            }
            catch
            {

                return false;
            }
        }
        public bool Update()
        {
            try
            {
                Datos.asociacion aso = Conector.Fetach.asociacions.First(a => a.id == this.Id);

                aso.id = this.Id;
                aso.nombre_asociacion = this.Nombre_asociacion;
                aso.direccion = this.Direccion;

                Conector.Fetach.SaveChanges();

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
                Datos.asociacion aso = Conector.Fetach.asociacions.First(a => a.id == this.Id);

                Conector.Fetach.DeleteObject(aso);
                Conector.Fetach.SaveChanges();

                return true;
            }
            catch
            {

                return false;
            }
        }

    }
}
