using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteNegocio : IClienteNegocio
    {
        ClienteDao cdao = new ClienteDao();

        public bool existe(string query)
        {
            if (cdao.existe(query)) {
                return true;
            }
            return false;
        }

        public int insertCliente(Cliente oCliente)
        {
            int filasAfectadas=cdao.insertCliente(oCliente);

            return filasAfectadas;
        }

        public DataTable ObtenerTabla(string nombreTabla, string query)
        {
            DataTable tabla = cdao.ObtenerTabla(nombreTabla, query);
            return tabla;
        }
    }
}
