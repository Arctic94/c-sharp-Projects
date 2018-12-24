using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacion.Negocio
{
    public class ArqueroColection
    {
        public List<Arquero> ReadAll()
        {
            try
            {
                List<Arquero> lstRetorno = new List<Arquero>();

                foreach (Datos.arquero ar in Conector.Fetach.arqueroes)
                {
                    Arquero arq = new Arquero()
                    {
                        Rut=ar.rut,
                        Nombre_completo=ar.nombre_completo,
                        Direccion=ar.direccion,
                        Asociacion=ar.asociacion,
                        Fecha_nacimiento=ar.fecha_nacimiento,
                        Al_dia=ar.al_dia                    
                    };
                    lstRetorno.Add(arq);
                }
                return lstRetorno;
            }
            catch 
            {
                return new List<Arquero>();
                
            }
        }

        public List<Arquero> Arq_condicionados()
        {
            //return ReadAll();
            return ReadAll().Where(a => DateTime.Today.Subtract(a.Fecha_nacimiento) > new TimeSpan(5475, 0, 0,0) && DateTime.Today.Subtract(a.Fecha_nacimiento) < new TimeSpan(21900, 0, 0,0) && a.Al_dia == true).ToList();  
        }
        public List<Arquero> Arq_asociacion(int id)
        {
            return ReadAll().Where(a => a.Asociacion == id).ToList();
        }
    }
}
