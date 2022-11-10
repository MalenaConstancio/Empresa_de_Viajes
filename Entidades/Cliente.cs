using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private Ciudad ciudad;
        private string calle;
        private int nroCalle;
        private long telefono;
        private int idTipoCliente;
        private string nombre;
        private string apellido;
        private string nacionalidad;
        private long dni;
        private long cuit;
        private string razonSocial;

        public Ciudad Ciudad { get; set; }
        public string Calle { get; set; }
        public int NroCalle { get; set; }
        public long Telefono { get; set; }
        public int IdTipoCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }
        public long Dni { get; set; }
        public long Cuit { get; set; }
        public string RazonSocial { get; set; }

        public Cliente()
        {

        }

        
    }
}
