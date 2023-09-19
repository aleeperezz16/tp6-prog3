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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grdProductos.DataSource = new Negocio().ObtenerProductos();
                grdProductos.DataBind();
            }
        }

        protected void grdProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdProductos.PageIndex = e.NewPageIndex;
            grdProductos.DataBind();
        }

        protected void grdProductos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            string nombreProducto = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lblNombreProducto")).Text;
            string idProducto = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lblIdProducto")).Text;
            string idProveedor= ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lblIdProveedor")).Text;
            string precioUnitario= ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lblPrecioUnitario")).Text;

            lblSeleccionado.Text = $"Producto agregado: {nombreProducto}";

            if (Session["Productos"] == null)
            {
                Session["Productos"] = CrearTabla();
            }

            AgregarFila(idProducto, nombreProducto, idProveedor, precioUnitario);
        }
        private DataTable CrearTabla()
        {
            DataTable dt = new DataTable();
            
            dt.Columns.Add(new DataColumn("IdProducto", Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("NombreProducto", Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("IdProveedor", Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("PrecioUnidad", Type.GetType("System.String")));

            return dt;
        }
        private void AgregarFila(string idProducto, string nombre, string idProveedor, string precio)
        {
            DataTable tabla = (DataTable)Session["Productos"];

            foreach (DataRow row in tabla.Rows)
            {
                if (row["IdProducto"].ToString() == idProducto)
                    return;
            }

            DataRow dr = tabla.NewRow();

            dr["IdProducto"] = idProducto;
            dr["NombreProducto"] = nombre;
            dr["IdProveedor"] = idProveedor;
            dr["PrecioUnidad"] = precio;

            tabla.Rows.Add(dr);
        }
    }
}