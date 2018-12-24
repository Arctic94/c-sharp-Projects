using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pasajes.Datos;

namespace Pasajes.Negocio
{
    public class ColeccionPasaje
    {
        
        public List<Pasaje> ListarPasajes()
        {
            try
            {
                List<Pasaje> lst = new List<Pasaje>();
                Conector con = new Conector();

                List<DatoPasaje> lstdp = con.ObtieneLista("select * from pasaje_base");

                foreach (DatoPasaje dp in lstdp)
                {
                    Pasaje p = new Pasaje();
                    p.Id = dp.Id;
                    p.RutPasajero = dp.Rut;
                    p.NombrePasajero = dp.Nombre;
                    p.Sexo = dp.Sexo;
                    p.TelefonoAccidente = dp.TelefonoAccidente;
                    p.TelefonoPersonal = dp.TelefonoPersonal;
                    p.FechaNacimiento = dp.FechaNacimiento;
                    p.DireccionPasajero = dp.Direccion;
                    p.DestinoViaje = dp.Destino;
                    p.FechaViaje = dp.FechaViaje;

                    lst.Add(p);
                }
                return lst;
            }
            catch
            {
                List<Pasaje> p= new List<Pasaje>();
                
                return p;
            }
        }

            
        }
        
}
