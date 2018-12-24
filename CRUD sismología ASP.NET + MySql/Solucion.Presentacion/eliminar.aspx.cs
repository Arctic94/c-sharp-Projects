using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Solucion.Negocio;

namespace Solucion.Presentacion
{
    public partial class eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_eliminarsismo_onclick(object sender, EventArgs e)
        {
            Sismo sis = new Sismo();
            sis.Id = Int32.Parse(txteliminar.Text);
            
            sis.Delete();

            Response.Redirect("inicio.aspx");
        }
    }
}