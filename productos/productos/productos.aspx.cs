using productos.core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace productos
{
    public partial class productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        void cargarProductos()
        {
            DataSet producto = metodos.devuelveprod();

            gv_productos.DataSource = producto;
            gv_productos.DataBind();
        }
    }
}