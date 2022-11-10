using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciudad
    {
        private int idCiudad;
        private int idProvincia;
        private int idPais;
        private string nomCiudad;

        public int IdCiudad { get; set; }
        public int IdProvincia { get; set; }
        public int IdPais { get; set; }
        public string NomCiudad { get; set; }


        public Ciudad()
        {

        }
    }
}
