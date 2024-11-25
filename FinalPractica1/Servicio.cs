using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalPractica1;

namespace FinalPractica1
{
    public class Servicio
    {
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public override string ToString() => $"Descripción: {Descripcion}, Precio: {Precio:C}";
        public static Servicio CrearServicio()
        {
            Console.Write("Descripción del servicio: ");
            string descripcion = Console.ReadLine();
            Console.Write("Precio del servicio: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            return new Servicio { Descripcion = descripcion, Precio = precio };
        }
    }
}
