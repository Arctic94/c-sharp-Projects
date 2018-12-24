using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Solucion.Negocio;

namespace Solucion.Presentacion
{
    public partial class modificar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_buscarsismo_onclick(object sender, EventArgs e)
        {
            Sismo sis = new Sismo();
            sis.Id = Int32.Parse(txtbuscar.Text);
            sis.Read();

            Textdescripcion.Text = sis.Descripcion;
            Textintensidad.Text = sis.Intensidad.ToString();
            Textprofundidad.Text = sis.Profundidad.ToString();
            txtcomuna.Text = sis.Comuna.ToString();
            calendario.SelectedDate = sis.FechaEvento.Date;
            Texthora.Text = sis.FechaEvento.Hour.ToString();
            Textminuto.Text = sis.FechaEvento.Minute.ToString();
        }
        protected void btnguardar_onclick(object sender, EventArgs e)
        {
            Sismo sis = new Sismo();
            sis.Id = Int32.Parse(txtbuscar.Text);
            sis.Descripcion = Textdescripcion.Text;
            sis.Comuna = Int32.Parse(txtcomuna.Text);
            sis.Profundidad = Int32.Parse(Textprofundidad.Text);
            sis.Intensidad = Int32.Parse(Textintensidad.Text);

            string fecha = calendario.SelectedDate.ToString();

            string date = Texthora.Text + ":" + Textminuto.Text + ":00";
            fecha = fecha.Replace("0:00:00", date);


            sis.FechaEvento = DateTime.Parse(fecha);



            sis.Update();
            Response.Redirect("inicio.aspx");

            
        }
    }

    
}