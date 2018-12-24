using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aplicacion.Presentacion
{
    public partial class Estadisticas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblrut.Text = string.Empty;
            lblnombre.Text = string.Empty;
            lbldireccion.Text = string.Empty;
            lblfecha_nac.Text = string.Empty;
            lblasociacion.Text = string.Empty;
            lblal_dia.Text = string.Empty;

            lbl_rut.Text = string.Empty;
            lbl_rut.Text = string.Empty;
            lbl_nombre.Text = string.Empty;
            lbl_direccion.Text = string.Empty;
            lbl_asociacion.Text = string.Empty;
            lbl_fecha_nac.Text = string.Empty;
            lbl_al_dia.Text = string.Empty;

            List<Negocio.Arquero> lst_arq = new List<Negocio.Arquero>();
            Negocio.ArqueroColection arq_col = new Negocio.ArqueroColection();
            lst_arq = arq_col.Arq_condicionados();

            foreach (Negocio.Arquero arq in lst_arq)
            {
                lblrut.Text = lblrut.Text+arq.Rut+"<br />";
                lblnombre.Text = lblnombre.Text + arq.Nombre_completo + "<br />";
                lbldireccion.Text = lbldireccion.Text + arq.Direccion + "<br />";
                lblfecha_nac.Text = lblfecha_nac.Text + arq.Fecha_nacimiento.ToShortDateString() + "<br />";

                Negocio.Asociacion aso = new Negocio.Asociacion();
                aso.Id = arq.Asociacion;
                aso.Read();
                lblasociacion.Text = lblasociacion.Text + aso.Nombre_asociacion + "<br />";

                //lblasociacion.Text = lblasociacion.Text + arq.Asociacion.ToString() + "<br />";
                lblal_dia.Text = lblal_dia.Text + arq.Al_dia.ToString() + "<br />";
            }
            
            
   
        }
        protected void select_click(object sender, EventArgs e)
        {
            List<Negocio.Arquero> lst_arq = new List<Negocio.Arquero>();
            Negocio.ArqueroColection arq_col = new Negocio.ArqueroColection();
            lst_arq = arq_col.Arq_condicionados();

            
            //int id = int.Parse(listboxasociaciones.SelectedValue);
            lst_arq = arq_col.Arq_asociacion(int.Parse(listboxasociaciones.SelectedValue));

            foreach (Negocio.Arquero arq in lst_arq)
            {
                lbl_rut.Text = lbl_rut.Text + arq.Rut + "<br />";
                lbl_nombre.Text = lbl_nombre.Text + arq.Nombre_completo + "<br />";
                lbl_direccion.Text = lbl_direccion.Text + arq.Direccion + "<br />";

                Negocio.Asociacion aso = new Negocio.Asociacion();
                aso.Id = arq.Asociacion;
                aso.Read();
                lbl_asociacion.Text = lbl_asociacion.Text + aso.Nombre_asociacion + "<br />";

                //lbl_asociacion.Text = lbl_asociacion.Text + arq.Asociacion + "<br />";
                lbl_fecha_nac.Text = lbl_fecha_nac.Text + arq.Fecha_nacimiento + "<br />";
                lbl_al_dia.Text = lbl_al_dia.Text + arq.Al_dia + "<br />";
            }
        }
    }
}