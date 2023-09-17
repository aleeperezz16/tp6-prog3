using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp6_prog3.Ejercicio2
{
    public partial class SeleccionarProductos : System.Web.UI.Page
    {
        private AccesoDatos _conexion = new AccesoDatos("Neptuno");
        protected void Page_Load(object sender, EventArgs e)
        {
            grdProductos.DataSource = _conexion.ObtenerTablas("SELECT IdProducto,NombreProducto,IdProveedor,PrecioUnidad FROM Productos", "Productos");
            grdProductos.DataBind();
        }

        protected void grdProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdProductos.PageIndex = e.NewPageIndex;
            grdProductos.DataBind();
        }

        protected void grdProductos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

            string nombreprod = ((Label)grdProductos.Rows[e.NewSelectedIndex).FindControl("itLblNombreProducto")).Text;

            lblSeleccionado.Text = "Producto agregado " + nombreprod ; 
        }
    }
}