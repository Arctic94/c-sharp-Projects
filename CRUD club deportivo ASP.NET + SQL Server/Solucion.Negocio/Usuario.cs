using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aplicacion.Datos;
using System.Data.Entity;

namespace Aplicacion.Negocio
{
    public class Usuario
    {
        public string Nombre_usuario { get; set; }
        public string Nombre_completo { get; set; }
        public string Contrasenna { get; set; }

        public Usuario()
        {
            Nombre_completo = string.Empty;
            Nombre_usuario = string.Empty;
            Contrasenna = string.Empty;
        }

        public bool IniciarSesion(string user, string pass)
        {
            try
            {
                Aplicacion.Datos.usuario usu = Conector.Fetach.usuarios.First(u => u.nombre_usuario == user && u.contrasenna == pass);
                
               

                if (usu != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Create()
        {
            try
            {
                Datos.usuario us = new Datos.usuario();
                us.nombre_usuario = this.Nombre_usuario;
                us.nombre_completo = this.Nombre_completo;
                us.contrasenna = this.Contrasenna;

                Conector.Fetach.AddTousuarios(us);
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
                Datos.usuario aso = Conector.Fetach.usuarios.First(u => u.nombre_usuario == this.Nombre_usuario);

                this.Nombre_usuario = aso.nombre_usuario;
                this.Nombre_completo = aso.nombre_completo;
                this.Contrasenna = aso.contrasenna;

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
                Datos.usuario aso = Conector.Fetach.usuarios.First(u => u.nombre_usuario == this.Nombre_usuario);

                aso.nombre_usuario = this.Nombre_usuario;
                aso.nombre_completo = this.Nombre_completo;
                aso.contrasenna = this.Contrasenna;

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
                Datos.usuario aso = Conector.Fetach.usuarios.First(u => u.nombre_usuario == this.Nombre_usuario);

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
