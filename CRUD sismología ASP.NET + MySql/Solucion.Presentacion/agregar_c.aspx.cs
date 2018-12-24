using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Solucion.Negocio;

namespace Solucion.Presentacion
{
    public partial class agregar_c : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnagregarc_onclick(object sender, EventArgs e)
        {
            Comuna com = new Comuna();
            com.Nombre = Textprofundidad.Text;
            com.Create();
            Response.Redirect("inicio.aspx");
        }
    }
}