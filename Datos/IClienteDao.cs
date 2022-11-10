using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    interface IClienteDao
    {
        int insertCliente(Cliente oCliente);
    }
}
