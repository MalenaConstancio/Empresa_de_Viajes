using Datos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Implementaciones
{
    public class PaqueteDao : IPaqueteDao
    {
        public int insertPaquete(Paquete oPaquete)
        {
            SqlTransaction t = null;
            Conexion cnn = new Conexion();
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            int filasAfectadas;

            try { 

                armarParametrosInsertPaquete(ref cmd, oPaquete);
                conexion = cnn.ObtenerConexion();
                t = conexion.BeginTransaction();
                cmd = new SqlCommand("SP_insertPaquete", conexion, t);
                filasAfectadas = cmd.ExecuteNonQuery();

                int idPaquete = oPaquete.IdPaquete;
                int cDetalles = 0;
                foreach (DetallePaquete det in oPaquete.Detalles)
                {
                    SqlCommand cmdDet = new SqlCommand("SP_insertDetallePaquete", conexion, t);
                    cmdDet.CommandType = CommandType.StoredProcedure;

                    cmdDet.Parameters.AddWithValue("@idPaquete", idPaquete);
                    cmdDet.Parameters.AddWithValue("@detalle", cDetalles);
                    cmdDet.Parameters.AddWithValue("@idLugar", det.OLugar.IdLugar);
                    cmdDet.Parameters.AddWithValue("@cantdias", det.CantDias);
                    cmdDet.ExecuteNonQuery();
                    cDetalles++;
                }
                t.Commit();
            }

            catch (Exception)
            {
                t.Rollback();
                filasAfectadas = 0;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return filasAfectadas;


        }

        private void armarParametrosInsertPaquete(ref SqlCommand cmd, Paquete oPaquete)
        {

            cmd.Parameters.AddWithValue("@NombrePaquete", oPaquete.NombrePaquete);
            cmd.Parameters.AddWithValue("@Precio", oPaquete.Precio);
            cmd.Parameters.AddWithValue("@Duracion", oPaquete.Duracion);
            cmd.Parameters.AddWithValue("@FechaSalida", oPaquete.FechaSalida);
            cmd.Parameters.AddWithValue("@EstaVigente", oPaquete.EstaVigente);
            cmd.Parameters.AddWithValue("@TipoPaquete", oPaquete.OTipoPaquete.IdTipoPaquete);
        }

        public int proximoIdPaquete()
        {
            int nro = 0;
            try
            {
                Conexion cnn = new Conexion();
                SqlConnection conexion = new SqlConnection();
                SqlCommand cmd = new SqlCommand("SP_proximoPaquete", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@next", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                nro = Convert.ToInt32(param.Value);
                conexion.Close();

            }
            catch (Exception)
            {

            }
            return nro;

        }


    }
}
