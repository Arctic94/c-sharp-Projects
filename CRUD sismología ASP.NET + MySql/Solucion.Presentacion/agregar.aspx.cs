using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Solucion.Negocio;

namespace Solucion.Presentacion
{
    public partial class agregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnenviar_onclick(object sender, EventArgs e)
        {
            Sismo sis = new Sismo();

            sis.Comuna = Int32.Parse(DropDownList2.SelectedValue);


            sis.Profundidad = float.Parse(Textprofundidad.Text);
            sis.Intensidad = float.Parse(Textintensidad.Text);
            sis.Descripcion = Textdescripcion.Text;

            string fecha = calendario.SelectedDate.ToString();

            string date = Texthora.Text + ":" + Textminuto.Text + ":00";
            fecha = fecha.Replace("0:00:00", date);


            sis.FechaEvento = DateTime.Parse(fecha);

            if (sis.Profundidad < 50 || sis.Intensidad > 4)
            {
                sis.Create();
                Response.Redirect("inicio.aspx");
            }
            else { Textintensidad.Text = "rango invalido"; Textprofundidad.Text = "rango invalido"; }
            
        }
    }
}