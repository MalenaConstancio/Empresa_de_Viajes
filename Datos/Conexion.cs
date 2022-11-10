using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class Conexion
    {
        private string rutabd_Empresa_de_Viajes = @"Data Source=DESKTOP-69H27BO\SQLEXPRESS;Initial Catalog=bd_Empresa_de_Viajes;Integrated Security=True";


        private SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutabd_Empresa_de_Viajes);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int EjecutarProcedimientoAlmacenado(SqlCommand Comando, String NombreSP)
        {
            int filasAfectadas;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = Comando;
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSP;
            filasAfectadas = cmd.ExecuteNonQuery();
            Conexion.Close();
            return filasAfectadas;
        }

        private SqlDataAdapter ObtenerAdaptador(String consultaSql, SqlConnection cn)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, cn);
                return adaptador;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ObtenerTabla(String nombreTabla, String query)
        {
            DataSet ds = new DataSet();
            SqlConnection cnn = ObtenerConexion();
            SqlDataAdapter adp = ObtenerAdaptador(query, cnn);
            adp.Fill(ds, nombreTabla);
            cnn.Close();
            return ds.Tables[nombreTabla];
        }

        public Boolean existe(String query)
        {
            Boolean estado = false;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(query, Conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())
            {
                estado = true;
            }

            Conexion.Close();
            return estado;
        }


    }
}
