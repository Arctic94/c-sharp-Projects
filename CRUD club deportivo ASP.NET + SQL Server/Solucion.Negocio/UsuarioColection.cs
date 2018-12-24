using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacion.Negocio
{
    public class UsuarioColection
    {
        public List<Usuario> ReadAll()
        {
            try
            {
                List<Usuario> lstRetorno = new List<Usuario>();

                foreach (Datos.usuario aso in Conector.Fetach.usuarios)
                {
                    Usuario asoc = new Usuario()
                    {
                        Nombre_completo = aso.nombre_completo,
                        Nombre_usuario = aso.nombre_usuario,
                        Contrasenna=aso.contrasenna

                    };
                    lstRetorno.Add(asoc);
                }
                return lstRetorno;
            }
            catch
            {
                return new List<Usuario>();

            }
        }
    }
}
