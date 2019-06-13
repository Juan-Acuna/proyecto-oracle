using System;

namespace ProyectoOracle.Modelos
{
    public class Cuenta
    {
        public int Id_cuenta { get; set; }
        public DateTime Apertura { get; set; }
        public int Monto { get; set; }
        public int Id_banco { get; set; }
        public int Id_tipo { get; set; }
        public String Rut { get; set; }
    }
}
