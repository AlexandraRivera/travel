using productos.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace productos
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lb_alerta.Visible = false;
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            int respuesta = metodos.loginUsuario(txt_email.Text, txt_password.Text);

            if (respuesta == 0)
            {
                lb_alerta.Visible = true;
                lb_alerta.Text = "El usuario o la clave son incorrectas";
            }
            else
            {
                Response.Redirect("productos.aspx");
            }
        }
    }
}