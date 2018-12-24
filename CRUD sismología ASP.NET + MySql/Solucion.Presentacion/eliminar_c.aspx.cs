using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Solucion.Negocio;

namespace Solucion.Presentacion
{
    public partial class eliminar_c : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_eliminarcomuna_onclick(object sender, EventArgs e)
        {
            Comuna com = new Comuna();
            com.ID = Int32.Parse(txteliminar.Text);
            com.Delete();
            Response.Redirect("inicio.aspx");
        }

    }
}