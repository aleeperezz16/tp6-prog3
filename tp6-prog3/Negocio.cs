using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace tp6_prog3
{
    public class Negocio
    {
        AccesoDatos conexion = new AccesoDatos("Neptuno");
        public DataTable ObtenerProductos()
        {
            string consultaSQL = "SELECT IdProducto, NombreProducto, IdProveedor, CantidadPorUnidad, PrecioUnidad FROM Productos";
            string nombreTabla = "Productos";
            return conexion.ObtenerTablas(consultaSQL, nombreTabla);
        }

        //TODO: Falta terminar estos metodos para poder eliminar o buscar X producto

        public int EliminarProducto(string idProducto)
        {
            string consultaSQL = ""; // CONSTRUIR LA CONSULTA SQL PARA ELIMINAR UN PRODUCTO
            return conexion.EjecutarConsulta(consultaSQL);
        }

        public DataTable BuscarProdcuto(string idProducto)
        {
            string consultaSQL = ""; //CONSTRUIR LA CONSULTA SQL PARA BUSCAR UN DETERMINADO PRODUCTO
            string nombreTabla = "Productos";
            return conexion.ObtenerTablas(consultaSQL, nombreTabla);
        }

        //TODO: Hay que agregar un metodo para editar consultas
    }
}