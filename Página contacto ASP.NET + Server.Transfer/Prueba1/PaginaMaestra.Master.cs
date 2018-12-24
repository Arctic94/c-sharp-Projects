using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba1
{
    public partial class PaginaMaestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnInicio_onClick(object sender, EventArgs e)
        {
            Server.Transfer("Inicio.aspx");
        }
        protected void btnProductos_onClick(object sender, EventArgs e)
        {
            Server.Transfer("Productos.aspx");
            
        }
        protected void btnContacto_onClick(object sender, EventArgs e)
        {
            Server.Transfer("Contacto.aspx");
        }
    }
}