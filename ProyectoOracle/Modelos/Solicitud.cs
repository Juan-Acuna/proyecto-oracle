using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOracle.Modelos
{
    public class Solicitud
    {
        public int Folio { get; set; }
        public DateTime Fecha { get; set; }
        public String Receptor { get; set; }
        public bool A_cargas { get; set; }
        public bool A_indigena { get; set; }
        public bool A_titulo { get; set; }
        public bool Mandato_ahorro { get; set; }
        public int? Rol { get; set; }
        public String Rut { get; set; }
    }
}
