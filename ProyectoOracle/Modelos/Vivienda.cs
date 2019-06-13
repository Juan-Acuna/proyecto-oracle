using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOracle.Modelos
{
    public class Vivienda
    {
        public int Rol { get; set; }
        public String Direccion { get; set; }
        public bool Usada { get; set; }
        public DateTime Construccion { get; set; }
        public int Dormitorios { get; set; }
        public int Banos { get; set; }
        public bool Estar { get; set; }
        public bool Comedor { get; set; }
        public bool Cocina { get; set; }
        public String Techo { get; set; }
        public String Muro { get; set; }
        public String Piso { get; set; }
        public int Id_comuna { get; set; }
        public int Id_tipo { get; set; }
    }
}
