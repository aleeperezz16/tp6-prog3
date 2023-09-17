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
        private SqlConnection _conexion;

        public AccesoDatos(string baseDeDatos)
        {  ///RUTA DAVID
           ///string ruta = "Data Source = DESKTOP - CIET1TI\\SQLEXPRESS01; Initial Catalog ="+ baseDeDatos +"; Integrated Security = True";
           string ruta = "Data Source = localhost\\sqlexpress; Initial Catalog = " + baseDeDatos + "; Integrated Security = True";
            _conexion = new SqlConnection(ruta);
        }

        public DataTable ObtenerTablas(string consultaSQL, string nombreTabla)
        {
            _conexion.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, _conexion);
            DataSet ds = new DataSet();
            adapter.Fill(ds, nombreTabla);

            _conexion.Close();
            return ds.Tables[nombreTabla];
        }

        public int EjecutarConsulta(string consulta)
        {
            _conexion.Open();

            SqlCommand comando = new SqlCommand(consulta, _conexion);
            int filasAfectadas = comando.ExecuteNonQuery();

            _conexion.Close();
            return filasAfectadas;
        }
    }
}