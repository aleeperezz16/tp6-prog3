using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp6_prog3.Ejercicio1
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        Negocio negocio = new Negocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            gdvProductos.DataSource = negocio.ObtenerProductos();
            gdvProductos.DataBind();
        }
    }
}