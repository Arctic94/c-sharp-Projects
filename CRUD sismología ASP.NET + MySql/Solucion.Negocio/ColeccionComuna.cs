using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Solucion.Datos;

namespace Solucion.Negocio
{
    public class ColeccionComuna
    {
        public List<Comuna> ListarComunas()
        {
            String sql = "Select * from comuna;";

            List<Comuna> lstTemp = new List<Comuna>();
            Conexion con = new Conexion();

            foreach (ComunaBase l in con.ObtieneListacb(sql))
            {
                Comuna com = new Comuna()
                {
                    ID = l.ID,
                    Nombre = l.Nombre,
                };

                lstTemp.Add(com);

            }

            return lstTemp;
        }
    }
}
