using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacion.Negocio
{
    public class Arquero
    {
        public string Rut { get; set; }
        public string Nombre_completo { get; set; }
        public string Direccion { get; set; }
        public int Asociacion { get; set; }
        public DateTime Fecha_nacimiento { get; set; }
        public bool Al_dia { get; set; }

        public Arquero()
        {
            Rut = string.Empty;
            Nombre_completo = string.Empty;
            Direccion = string.Empty;
            Asociacion = 0;
            Fecha_nacimiento = DateTime.Now;
            Al_dia = true;
        }

        public bool Create()
        {
            try
            {
                Datos.arquero ar = new Datos.arquero();
                ar.rut = this.Rut;
                ar.nombre_completo = this.Nombre_completo;
                ar.direccion = this.Direccion;
                ar.asociacion = this.Asociacion;
                ar.fecha_nacimiento = this.Fecha_nacimiento;
                ar.al_dia = this.Al_dia;

                Conector.Fetach.AddToarqueroes(ar);
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
                Datos.arquero ar = Conector.Fetach.arqueroes.First(a => a.rut == this.Rut);
                this.Rut = ar.rut;
                this.Nombre_completo = ar.nombre_completo;
                this.Direccion = ar.direccion;
                this.Asociacion = ar.asociacion;
                this.Fecha_nacimiento = ar.fecha_nacimiento;
                this.Al_dia = ar.al_dia;

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
                Datos.arquero ar = Conector.Fetach.arqueroes.First(a => a.rut == this.Rut);
                ar.rut = this.Rut;
                ar.nombre_completo = this.Nombre_completo;
                ar.direccion = this.Direccion;
                ar.asociacion = this.Asociacion;
                ar.fecha_nacimiento = this.Fecha_nacimiento;
                ar.al_dia = this.Al_dia;

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
                Datos.arquero ar = Conector.Fetach.arqueroes.First(a => a.rut == this.Rut);           
                Conector.Fetach.DeleteObject(ar);
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
