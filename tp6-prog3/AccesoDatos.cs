using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace tp6_prog3
{
    public class AccesoDatos
    {
        private string ruta;
        private SqlConnection conexion;

        public AccesoDatos(string baseDeDatos)
        {  ///RUTA DAVID
           ///ruta = "Data Source = DESKTOP - CIET1TI\\SQLEXPRESS01; Initial Catalog ="+ baseDeDatos +"; Integrated Security = True";
            ruta = "Data Source = localhost\\sqlexpress; Initial Catalog = " + baseDeDatos + "; Integrated Security = True";
            conexion = new SqlConnection(ruta);
        }

        public DataTable ObtenerTablas(string consultaSQL, string nombreTabla)
        {
            AbrirConexion();

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, conexion);
            DataSet ds = new DataSet();
            adapter.Fill(ds, nombreTabla);

            CerrarConexion();
            return ds.Tables[nombreTabla];
        }

        public int EjecutarConsulta(string consulta)
        {
            AbrirConexion();

            SqlCommand comando = new SqlCommand(consulta, conexion);
            int filasAfectadas = comando.ExecuteNonQuery();

            CerrarConexion();
            return filasAfectadas;
        }

        private void AbrirConexion()
        {
            conexion.Open();
        }

        private void CerrarConexion()
        {
            conexion.Close();
        }

    }
}