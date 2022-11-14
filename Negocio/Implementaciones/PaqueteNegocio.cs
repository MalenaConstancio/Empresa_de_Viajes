using Datos.Implementaciones;
using Entidades;
using Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Implementaciones
{
    public class PaqueteNegocio : IPaqueteNegocio
    {

        PaqueteDao pdao = new PaqueteDao();

        public int insertPaquete(Paquete paq)
        {
           int filasAfectadas= pdao.insertPaquete(paq);

            return filasAfectadas;
        }

        public int proximoIdPaquete()
        {
          int proximoId=  pdao.proximoIdPaquete();

          return proximoId;

        }
    }
}
