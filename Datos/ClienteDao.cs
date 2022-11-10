using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class ClienteDao:IClienteDao
    {
        public int insertCliente (Cliente oCliente) {

            Conexion cnn = new Conexion();
            SqlCommand cmd = new SqlCommand();
            armarParametrosInsertCliente(ref cmd, oCliente);
            int filasAfectadas = cnn.EjecutarProcedimientoAlmacenado(cmd, "SP_insertCliente");
            return filasAfectadas;
        }

        private void armarParametrosInsertCliente(ref SqlCommand cmd, Cliente oCliente) {
            cmd.Parameters.AddWithValue("@IdCiudad", oCliente.IdCiudad);
            cmd.Parameters.AddWithValue("@Calle", oCliente.Calle);
            cmd.Parameters.AddWithValue("@NroCalle", oCliente.NroCalle);
            cmd.Parameters.AddWithValue("@Telefono", oCliente.Telefono);
            cmd.Parameters.AddWithValue("@IdTipoCliente", oCliente.IdTipoCliente);
            cmd.Parameters.AddWithValue("@NombreCliente", oCliente.Nombre);
            cmd.Parameters.AddWithValue("@ApellidoCliente", oCliente.Apellido);
            cmd.Parameters.AddWithValue("@Nacionalidad", oCliente.Nacionalidad);
            cmd.Parameters.AddWithValue("@Dni", oCliente.Dni);
            cmd.Parameters.AddWithValue("@Cuit", oCliente.Cuit);
            cmd.Parameters.AddWithValue("@RazonSocial", oCliente.RazonSocial);

        }

    }
}
