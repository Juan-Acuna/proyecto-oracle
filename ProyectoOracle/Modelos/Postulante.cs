using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOracle.Modelos
{
    public class Postulante
    {
        public String Rut { get; set; }
        public String Nombre_completo { get; set; }
        public DateTime Nacimiento { get; set; }
        public String Nacionalidad { get; set; }
        public String Titulo { get; set; }
        public int Cargas_familiares { get; set; }
        public bool P_indigena { get; set; }
        public int? Fono_t { get; set; }
        public int? Fono_c { get; set; }
        public int? Fono_m { get; set; }
        public String Email { get; set; }
        public String Direccion { get; set; }
        public Int64 Codigo_postal { get; set; }
        public String Rut_conyuge { get; set; }
    }
}
