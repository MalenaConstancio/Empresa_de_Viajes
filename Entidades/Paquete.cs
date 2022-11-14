using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete
    {
        private int idPaquete;
        private string nombrePaquete;
        private decimal precio;
        private int duracion;
        private DateTime fechaSalida;
        private bool estaVigente;
        private TipoPaquete oTipoPaquete;
        private List<DetallePaquete> detalles;

        public int IdPaquete { get; set; }
        public string NombrePaquete { get; set; }
        public decimal Precio { get; set; }
        public int Duracion { get; set; }
        public DateTime FechaSalida { get; set; }
        public bool EstaVigente { get; set; }
        public TipoPaquete OTipoPaquete { get; set; }

        public List<DetallePaquete> Detalles { get; set; }

        public Paquete()
        {
            Detalles = new List<DetallePaquete>();
        }

        public int calcularDuracion() {

            int duracion = 0;
            foreach (DetallePaquete detalle in Detalles) {

                duracion += detalle.CantDias;
            }
            return duracion;
        }

    }
}
