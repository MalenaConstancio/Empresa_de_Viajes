using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    interface IPaqueteDao
    {
         int insertPaquete(Paquete paq);
         int proximoIdPaquete();
    }
}
