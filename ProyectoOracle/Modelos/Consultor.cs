using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOracle.Modelos
{
    public class Consultor
    {
        public String Rut_consultor { get; set; }
        public String Nombre_completo { get; set; }
        public String Email { get; set; }
        public int Telefono { get; set; }
        public int Resolucion { get; set; }
        public DateTime F_resolucion { get; set; }
        public String Categoria { get; set; }
    }
}
