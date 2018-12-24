using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Solucion.Negocio;

namespace Solucion.Presentacion
{
    public partial class modificar_c : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_buscarcomuna_onclick(object sender, EventArgs e)
        {
            Comuna sis = new Comuna();
            sis.ID = Int32.Parse(txtbuscar.Text);
            sis.Read();
            txtnombre.Text = sis.Nombre;
        }
        protected void btnguardar_onclick(object sender, EventArgs e)
        {
            Comuna sis = new Comuna();
            sis.ID = Int32.Parse(txtbuscar.Text);

            sis.Nombre = txtnombre.Text;
            sis.Update();
        }
    }
}