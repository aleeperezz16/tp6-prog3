using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

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

            string nombreprod = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("itLblNombreProducto")).Text;
            lblSeleccionado.Text = "Producto agregado " + nombreprod ;
            string IdProducto = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("itLblIdProducto")).Text;
            string IdProveedor= ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("itLblIdProveedor")).Text;
            string PrecioUnitario= ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("itLblPrecioUnitario")).Text;

            if (Session["tabla"]==null)
            {
                Session["tabla"] = crearTabla();
            }
            agregarFila((DataTable)Session["tabla"], IdProducto, nombreprod, IdProveedor, PrecioUnitario);
        }
        public DataTable crearTabla()
        {
            DataTable dt = new DataTable();
            DataColumn columna = new DataColumn("Id Producto", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);

            columna = new DataColumn("NombreProducto", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);

            columna = new DataColumn("IdProveedor", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);

            columna = new DataColumn("PrecioUnidad", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);

            return dt;
        }
        public void agregarFila(DataTable tabla, string idProducto, string nombre, string idProveedor, string pu)
        {
            DataRow dr = tabla.NewRow();
            dr["IdProducto"] = idProducto;
            dr["NombreProducto"] = nombre;
            dr["IdProveedor"] = idProveedor;
            dr["PrecioUnidad"] = pu;
            tabla.Rows.Add(dr);
        }

    }
}