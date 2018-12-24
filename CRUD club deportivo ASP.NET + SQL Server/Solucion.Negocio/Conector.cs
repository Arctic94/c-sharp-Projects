using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacion.Negocio
{
    public class Conector
    {
        private static Aplicacion.Datos.solucion_fetachEntities _fetach;

        public static Aplicacion.Datos.solucion_fetachEntities Fetach
        {
            get
            {
                if (_fetach == null)
                {
                    _fetach = new Aplicacion.Datos.solucion_fetachEntities();
                }

                return _fetach;
            }
        }

        

        private Conector()
        {
        }
    }
}
