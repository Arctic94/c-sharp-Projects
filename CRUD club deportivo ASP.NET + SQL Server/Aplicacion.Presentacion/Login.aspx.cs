using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Aplicacion.Presentacion.ServicioAutentificador;


namespace Aplicacion.Presentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lgAutentificar_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (FormsAuthentication.Authenticate(lgAutentificar.UserName, lgAutentificar.Password))
            {
                Session["usuario"] = lgAutentificar.UserName;
                FormsAuthentication.RedirectFromLoginPage(lgAutentificar.UserName, lgAutentificar.RememberMeSet);
            }

            ServicioAutentificador.Autentificador1Client acl = new Autentificador1Client();

            if (acl.Autentificar(lgAutentificar.UserName, lgAutentificar.Password))
            {
                Session["usuario"] = lgAutentificar.UserName;
                FormsAuthentication.RedirectFromLoginPage(lgAutentificar.UserName, lgAutentificar.RememberMeSet);
            }
        }
    
    }
}