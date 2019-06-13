using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOracle.Modelos
{
    public class InformeTecnico
    {
        public int Folio { get; set; }
        public DateTime F_solicitud { get; set; }
        public DateTime F_inspeccion { get; set; }
        public String Anomalias { get; set; }
        public int Rol { get; set; }
        public int Id_estado { get; set; }
        public String Rut_consultor { get; set; }
    }
}
