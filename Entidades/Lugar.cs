using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lugar
    {
        private int idLugar;
        private string nombreLugar;
        private Ciudad ciudad;

        public string NombreLugar { get; set; }
        public Ciudad Ciudad { get; set; }
        public int IdLugar { get; set; }

        public Lugar()
        {

        }
    }
}
