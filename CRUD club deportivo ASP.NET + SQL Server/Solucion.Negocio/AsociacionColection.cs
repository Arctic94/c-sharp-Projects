using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacion.Negocio
{
    public class AsociacionColection
    {
    
        public List<Asociacion> ReadAll()
        {
            try
            {
                List<Asociacion> lstRetorno = new List<Asociacion>();

                foreach (Datos.asociacion aso in Conector.Fetach.asociacions)
                {
                    Asociacion asoc = new Asociacion()
                    {
                        Id=aso.id,
                        Nombre_asociacion=aso.nombre_asociacion,
                        Direccion=aso.direccion
                        
                    };
                    lstRetorno.Add(asoc);
                }
                return lstRetorno;
            }
            catch 
            {
                return new List<Asociacion>();
                
            }
        }

       
    
    
    }
}
