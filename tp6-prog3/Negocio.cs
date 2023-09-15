using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tp6_prog3
{
    public class Negocio
    {
        AccesoDatos conexion = new AccesoDatos("BDNeptuno");
        public DataTable ObtenerProductos()
        {
            string consultaSQL = "SELECT IdProducto AS Id Producto, NombreProducto AS Nombre Producto, IdProveedor AS Id Porveedor, CantidadPorUnidad AS Cantidad Por Unidad, PrecioUnidad AS Precio Unitario FROM Productos";
            string nombreTabla = "Productos";
            return conexion.ObtenerTablas(consultaSQL, nombreTabla);
        }

        
        // TODO: HAY QUE COMPLETAR ESTOS CAMPOS SOLO SI LOS QUIEREN USAR, ES UN TEMPLATE QUE ESTABA EN EL TRABAJO CON CLASES QUE SUBIERON COMO EJEMPLO

        /*
        public DataTable ObtenerProductoID()
        {
            string consultaSQL = "SELECT * FROM Productos";
            string nombreTabla = "Productos";
            return conexion.ObtenerTablas(consultaSQL, nombreTabla);
        }

        public DataTable ObtenerNombreProducto()
        {
            string consultaSQL = "SELECT * FROM Productos";
            string nombreTabla = "Productos";
            return conexion.ObtenerTablas(consultaSQL, nombreTabla);
        }

        public DataTable ObtenerIdProveedor()
        {
            string consultaSQL = "SELECT * FROM Productos";
            string nombreTabla = "Productos";
            return conexion.ObtenerTablas(consultaSQL, nombreTabla);
        }

        public DataTable ObtenerCantidadPorUnidad()
        {
            string consultaSQL = "SELECT * FROM Productos";
            string nombreTabla = "Productos";
            return conexion.ObtenerTablas(consultaSQL, nombreTabla);
        }

        public DataTable ObtenerPrecioUnidad()
        {
            string consultaSQL = "SELECT * FROM Productos";
            string nombreTabla = "Productos";
            return conexion.ObtenerTablas(consultaSQL, nombreTabla);
        }*/

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

        //TODO: Hay que agregar un metodo para 
    }
}