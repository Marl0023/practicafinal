using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalPractica1;

namespace FinalPractica1
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Especie { get; set; }
        public override string ToString() => $"Nombre: {Nombre}, Edad: {Edad}, Especie: {Especie}";
        public static Mascota CrearMascota()
        {
            Console.Write("Nombre de la mascota: ");
            string nombre = Console.ReadLine();
            Console.Write("Edad de la mascota: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Especie de la mascota: ");
            string especie = Console.ReadLine();

            return new Mascota { Nombre = nombre, Edad = edad, Especie = especie };
        }
    }
}
