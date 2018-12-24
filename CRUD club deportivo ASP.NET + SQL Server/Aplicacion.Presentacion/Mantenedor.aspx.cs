using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aplicacion.Presentacion
{
    public partial class Mantenedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Negocio.Usuario> lst_arq = new List<Negocio.Usuario>();
            Negocio.UsuarioColection arq_col = new Negocio.UsuarioColection();
            lst_arq = arq_col.ReadAll();

            foreach (Negocio.Usuario arq in lst_arq)
            {

                lblnombreusuario.Text = lblnombreusuario.Text + arq.Nombre_usuario + "<br />";

                lblnombrecompleto.Text = lblnombrecompleto.Text + arq.Nombre_completo + "<br />";


                lblcontrasenna.Text = lblcontrasenna.Text + arq.Contrasenna + "<br />";
            }
        }

        protected void btnAgregarASO_onclick(object sender, EventArgs e)
        {
            Negocio.Asociacion aso = new Negocio.Asociacion();
            aso.Nombre_asociacion = txtnombreASO.Text;
            aso.Direccion = txtdireccionASO.Text;
            if (aso.Create())
            {
                Response.Redirect("Mantenedor.aspx");
            }
            txtnombreASO.Text = "asociacion no creada";
            txtdireccionASO.Text = "asociacion no creada";
        }

        protected void btnEliminarASO_onclick(object sender, EventArgs e)
        {
            Negocio.Asociacion aso = new Negocio.Asociacion();
            aso.Id = int.Parse(txtnombreASO_eliminar.Text);

            
            if (aso.Delete())
            {
                Response.Redirect("Mantenedor.aspx");
            }
            txtnombreASO_eliminar.Text = "asociacion no eliminada";
            
        }

        protected void btnmodificarASO_onclick(object sender, EventArgs e)
        {
            Negocio.Asociacion aso = new Negocio.Asociacion();
            aso.Id = int.Parse(TextBox3.Text);
            aso.Read();
            TextBox1.Text = aso.Nombre_asociacion;
            TextBox2.Text = aso.Direccion;
            
            
            

        }

        protected void btnmodificarASO_onclick2(object sender, EventArgs e)
        {
            Negocio.Asociacion aso = new Negocio.Asociacion();
            aso.Id = int.Parse(TextBox3.Text);
            aso.Read();
            aso.Nombre_asociacion = TextBox1.Text;
            aso.Direccion = TextBox2.Text;
            

            if (aso.Update())
            {
                Response.Redirect("Mantenedor.aspx");
            }
            TextBox3.Text = "Datos no modificados";
        }
    }
}