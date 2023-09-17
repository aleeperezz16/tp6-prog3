using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tp6_prog3
{
    public class Producto
    {
        private int i_IdProducto;
        private string i_NombreProducto;
        private int i_IdProveedor;
        private string i_CantidadPorUnidad;
        private decimal i_PrecioUnidad;


        public Producto ()
        {
        }

        public Producto(int i_IdProducto, string i_NombreProducto, string i_CantidadPorUnidad, decimal i_PrecioUnidad)
        {
            //EJ1
            this.i_IdProducto = i_IdProducto;
            this.i_NombreProducto = i_NombreProducto;
            this.i_CantidadPorUnidad = i_CantidadPorUnidad;
            this.i_PrecioUnidad = i_PrecioUnidad;

        }


        public Producto (int i_IdProducto, string i_NombreProducto, int i_IdProveedor, decimal i_PrecioUnidad)
        {
            //EJ2
            this.i_IdProducto = i_IdProducto;
            this.i_NombreProducto = i_NombreProducto;
            this.i_IdProveedor = i_IdProveedor;
            this.i_PrecioUnidad = i_PrecioUnidad;
        }

        public int IdProducto
        {
            get { return i_IdProducto; }
            set { i_IdProducto = value; }
        }
        public string NombreProducto
        {
            get { return i_NombreProducto; }
            set { i_NombreProducto = value; }
        }
        public int IdProveedor
        {
            get { return i_IdProveedor; }
            set { i_IdProveedor = value; }
        }
        public string CantidadPorUnidad
        {
            get { return i_CantidadPorUnidad; }
            set { i_CantidadPorUnidad = value; }
        }
        public decimal PrecioUnidad
        {
            get { return i_PrecioUnidad; }
            set { i_PrecioUnidad = value; }
        }

    }
}