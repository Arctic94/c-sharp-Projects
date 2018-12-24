using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba1
{
    public partial class Respuesta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["nombre"]!=null)
            {
                lblrespuesta.Text = "Sr(a). " + Request.Params["nombre"] + " su consulta ha sido enviada, nos contactaremos con usted lo más pronto posible.";
            }
           
        }
    }
}