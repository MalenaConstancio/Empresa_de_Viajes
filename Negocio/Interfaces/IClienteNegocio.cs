using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public interface IClienteNegocio
    {
         int insertCliente(Cliente oCliente);
        DataTable ObtenerTabla(String nombreTabla, String query);
    }
}
