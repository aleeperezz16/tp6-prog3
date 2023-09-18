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
            cargarProductosEnGrilla();
        }

        protected void gdvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gdvProductos.PageIndex = e.NewPageIndex;
            gdvProductos.DataBind();
        }

        protected void gdvProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        { 
            
            string s_IdProducto = ((Label)gdvProductos.Rows[e.RowIndex].FindControl("lbl_it_idProducto")).Text;

            int Borro = negocio.EliminarProducto(s_IdProducto);

            if (Borro == 1)
            {
              ///SE ELIMINO CORRECTAMENTE

            }
            {
                ///NO SE ELIMINO
            }

            ///FALTA VOLVER A CARGAR LA GRILLA.
            cargarProductosEnGrilla();

        }

        protected void gdvProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gdvProductos.EditIndex = e.NewEditIndex;
            gdvProductos.DataBind();
        }

        protected void gdvProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gdvProductos.EditIndex = -1;
            cargarProductosEnGrilla();
        }

        private void cargarProductosEnGrilla()
        {
            gdvProductos.DataSource = negocio.ObtenerProductos();
            gdvProductos.DataBind();

        }

        protected void gdvProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string IdProducto = ((Label)gdvProductos.Rows[e.RowIndex].FindControl("lbl_eit_IdProducto")).Text;
            string NombreProducto = ((TextBox)gdvProductos.Rows[e.RowIndex].FindControl("txt_eit_Producto")).Text;
            string CantidadUnidad = ((TextBox)gdvProductos.Rows[e.RowIndex].FindControl("txt_eit_Cantidad")).Text;
            string PrecioUnidad = ((TextBox)gdvProductos.Rows[e.RowIndex].FindControl("txt_eit_PrecioUnidad")).Text;

            int modifico = negocio.ActualizarProducto(IdProducto,NombreProducto,CantidadUnidad,PrecioUnidad);

            if (modifico == 1)
            {
                ///SE MODIFICO CORRECTAMENTE

            }
            {
                ///NO SE MODIFICO
            }
            gdvProductos.EditIndex = -1;
            cargarProductosEnGrilla();
        }
    }
}