using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aplicacion.Presentacion
{
    public partial class Listar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Negocio.Arquero> lst_arq = new List<Negocio.Arquero>();
            Negocio.ArqueroColection arq_col = new Negocio.ArqueroColection();
            lst_arq = arq_col.ReadAll();

            foreach (Negocio.Arquero arq in lst_arq)
            {
               
                lblnombre.Text = lblnombre.Text + arq.Nombre_completo + "<br />";
                
                lblfecha_nac.Text = lblfecha_nac.Text + arq.Fecha_nacimiento.ToShortDateString() + "<br />";
                
                Negocio.Asociacion aso = new Negocio.Asociacion();
                aso.Id = arq.Asociacion ;
                aso.Read();
                lblasociacion.Text = lblasociacion.Text + aso.Nombre_asociacion + "<br />";

                
            }
        }
    }
}