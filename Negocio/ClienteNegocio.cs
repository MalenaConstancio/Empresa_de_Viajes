using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    class ClienteNegocio : IClienteNegocio
    {
        public int insertCliente(Cliente oCliente)
        {
            
            ClienteDao cdao = new ClienteDao();
            int filasAfectadas=cdao.insertCliente(oCliente);

            return filasAfectadas;

        }


    }
}
