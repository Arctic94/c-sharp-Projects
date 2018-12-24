using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Aplicacion.Negocio;


namespace Aplicacion.Servicio
{
    
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    [ServiceContract]
    public class Autentificador1
    {
        [OperationContract]
        public bool Autentificar(string user, string pass)
        {
            Usuario usu = new Usuario();

            return usu.IniciarSesion(user, pass);
        }
    }
}
