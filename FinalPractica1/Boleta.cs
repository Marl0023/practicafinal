using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalPractica1;

namespace FinalPractica1
{
    public class Boleta
    {
        public int Codigo { get; set; }
        public Mascota Mascota { get; set; }
        public Servicio Servicio1 { get; set; }
        public Servicio Servicio2 { get; set; }
        public decimal Total1 { get; set; }
        public override string ToString() =>
            $"Código: {Codigo}, Mascota: {Mascota.Nombre}, Servicio 1: {Servicio1.Descripcion}, Servicio 2: {Servicio2.Descripcion}, Total: {Total1:C}";
        public void CalcularTotal()
        {
            Total1 = Servicio1.Precio + Servicio2.Precio;
        }
    }
}
