using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace tp6_prog3
{
    public class Negocio
    {
        private AccesoDatos _conexion = new AccesoDatos("Neptuno");
        public DataTable ObtenerProductos()
        {
            string consultaSQL = "SELECT IdProducto, NombreProducto, IdProveedor, CantidadPorUnidad, PrecioUnidad FROM Productos";
            string nombreTabla = "Productos";
            return _conexion.ObtenerTablas(consultaSQL, nombreTabla);
        }

        public int EliminarProducto(string idProducto)
        {
            string consultaSQL = "DELETE FROM Productos Where IdProducto ="+idProducto.Trim(); 
            return _conexion.EjecutarConsulta(consultaSQL);
        }

        public DataTable BuscarProdcuto(string idProducto)
        {
            string consultaSQL = ""; //CONSTRUIR LA CONSULTA SQL PARA BUSCAR UN DETERMINADO PRODUCTO
            string nombreTabla = "Productos";
            return _conexion.ObtenerTablas(consultaSQL, nombreTabla);
        }
        public int ActualizarProducto(string IdProducto, string NombreProducto, string CantidadPorUnidad, string PrecioUnidad)
        {
            string consultaSQL = "UPDATE Productos ";
            consultaSQL += "SET NombreProducto = '" + NombreProducto + "',";
            consultaSQL += "CantidadPorUnidad = '" + CantidadPorUnidad + "',";
            consultaSQL += "PrecioUnidad = '" + PrecioUnidad +  "' ";
            consultaSQL += "WHERE IdProducto = " + IdProducto.Trim();
            return _conexion.EjecutarConsulta(consultaSQL);
        }
    }
}