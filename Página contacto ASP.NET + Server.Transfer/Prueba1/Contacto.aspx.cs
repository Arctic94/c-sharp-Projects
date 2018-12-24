using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba1
{
    public partial class Contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text != string.Empty && TextBox1.Text != string.Empty && TextBox2.Text != string.Empty && TextBox3.Text != string.Empty)
            {
                if (TextBox1.Text.Contains('@') && TextBox1.Text.Contains('.'))
                {
                    int telefono;
                    if (int.TryParse(TextBox2.Text, out telefono))
                    {
                        Server.Transfer("respuesta.aspx?nombre="
                        + txtnombre.Text +
                        "&correo="
                        + TextBox1.Text +
                        "&telefono="
                        + TextBox2.Text +
                        "&mensaje="
                        + TextBox3.Text);
                    }
                    else
                    {
                        TextBox2.Text = "Ingrese solo numeros";
                    }
                }
                else
                {
                    TextBox1.Text = "Ingrese correo valido";
                }



            }
            else
            {
                TextBox1.Text = "Debe llenar todos los campos";
            }

            
        }
    }
}