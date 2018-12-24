using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Solucion.Datos;

namespace Solucion.Negocio
{
    public class ColeccionSismo
    {
        public List<Sismo> ListarSismos()
        {
            String sql = "Select * from sismo;";

            List<Sismo> lstTemp = new List<Sismo>();
            Conexion con = new Conexion();

            foreach (SismoBase l in con.ObtieneListasb(sql))
            {
                Sismo sis = new Sismo()
                {
                    Id = l.ID,
                    FechaEvento = l.FechaEvento,
                    Comuna = l.Comuna,
                    Profundidad = l.Profundidad,
                    Descripcion = l.Descripcion,
                    Intensidad = l.Intensidad,
                };

                lstTemp.Add(sis);

            }

            return lstTemp;
        }
    }
}
