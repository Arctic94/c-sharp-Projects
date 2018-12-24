using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aplicacion.Presentacion
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DateTime today = DateTime.Today.AddYears(-12);
                calfecha_nac.TodaysDate = today;
                calfecha_nac.SelectedDate = calfecha_nac.TodaysDate;
            }
        }

        protected void brnAddARQ_Click(object sender, EventArgs e)
        {
            if (calfecha_nac.SelectedDate < DateTime.Today.AddYears(-12))
            {

                Negocio.Arquero ar = new Negocio.Arquero();
                ar.Rut = txtrut.Text;
                ar.Nombre_completo = txtrut.Text;
                ar.Direccion = txtdireccion.Text;
                ar.Asociacion = int.Parse(txtasociacion.Text);
                ar.Fecha_nacimiento = calfecha_nac.SelectedDate;
                ar.Al_dia = true;

                if (ar.Create())
                {
                    Response.Redirect("Index.aspx");
                }

            }

            resultado.Text = "* EL ARQUERO DEBE SER MAYOR A 12 AÑOS EDAD *";

        }
    }
}