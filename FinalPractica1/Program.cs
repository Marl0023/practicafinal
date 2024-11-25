using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalPractica1;

namespace FinalPractica1
{
    public class Program
    {

        static Mascota[] mascotas = new Mascota[10];
        static Servicio[] servicios = new Servicio[10];
        static Boleta[] boletas = new Boleta[10];

        static int mascotaCount = 0, servicioCount = 0, boletaCount = 0;
        static void Main(string[] args)
        {
            int opc = 0;
            do
            {
                Console.WriteLine("Menu de veterianria");
                Console.WriteLine("\n\t1-Crear Servicio\n\t2-Eliminar Servicio\n\t3-Listar Servicios");
                Console.WriteLine("\n\t4-Crear Mascota\n\t5-Eliminar Mascota\n\t6-Listar Mascotas");
                Console.WriteLine("\n\t7-Crear Boelta\n\t8-Listar Boletas\n\t9-Salir");
                Console.Write("Ingrese su opcion: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1: CrearServicio(); break;
                    case 2: EliminarServicio(); break;
                    case 3: ListarServicios(); break;
                    case 4: CrearMascota(); break;
                    case 5: EliminarMascota(); break;
                    case 6: ListarMascotas(); break;
                    case 7: CrearBoleta(); break;
                    case 8: ListarBoletas(); break;
                    case 9: break;
                    default:
                        Console.WriteLine("Error vuelva intentarlo");
                        break;
                }
            } while (opc!=9);
        }
        static void CrearServicio()
        {
            if (servicioCount < servicios.Length)
            {
                servicios[servicioCount++] = Servicio.CrearServicio();
                Console.WriteLine("Servicio creado con éxito.");
            }
            else
            {
                Console.WriteLine("No se pueden agregar más servicios.");
            }
            Console.ReadKey();
        }
        static void EliminarServicio()
        {
            ListarServicios();
            Console.Write("Seleccione el índice del servicio a eliminar: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < servicioCount)
            {
                for (int i = index; i < servicioCount - 1; i++)
                {
                    servicios[i] = servicios[i + 1];
                }
                servicios[--servicioCount] = null;
                Console.WriteLine("Servicio eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
            Console.ReadKey();
        }
        static void ListarServicios()
        {
            Console.WriteLine("=== Lista de Servicios ===");
            for (int i = 0; i < servicioCount; i++)
            {
                Console.WriteLine($"{i}. {servicios[i]}");
            }
            Console.ReadKey();
        }
        static void CrearMascota()
        {
            if (mascotaCount < mascotas.Length)
            {
                mascotas[mascotaCount++] = Mascota.CrearMascota();
                Console.WriteLine("Mascota creada con éxito.");
            }
            else
            {
                Console.WriteLine("No se pueden agregar más mascotas.");
            }
            Console.ReadKey();
        }
        static void EliminarMascota()
        {
            ListarMascotas();
            Console.Write("Seleccione el índice de la mascota a eliminar: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < mascotaCount)
            {
                for (int i = index; i < mascotaCount - 1; i++)
                {
                    mascotas[i] = mascotas[i + 1];
                }
                mascotas[--mascotaCount] = null;
                Console.WriteLine("Mascota eliminada con éxito.");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
            Console.ReadKey();
        }
        static void ListarMascotas()
        {
            Console.WriteLine("=== Lista de Mascotas ===");
            for (int i = 0; i < mascotaCount; i++)
            {
                Console.WriteLine($"{i}. {mascotas[i]}");
            }
            Console.ReadKey();
        }
        static void CrearBoleta()
        {
            ListarMascotas();
            Console.Write("Seleccione el índice de la mascota: ");
            int mascotaIndex = int.Parse(Console.ReadLine());

            if (mascotaIndex >= 0 && mascotaIndex < mascotaCount)
            {
                Mascota mascotaSeleccionada = mascotas[mascotaIndex];

                ListarServicios();
                Console.Write("Seleccione el índice del primer servicio: ");
                int servicio1Index = int.Parse(Console.ReadLine());
                Console.Write("Seleccione el índice del segundo servicio: ");
                int servicio2Index = int.Parse(Console.ReadLine());

                if (servicio1Index >= 0 && servicio1Index < servicioCount &&
                    servicio2Index >= 0 && servicio2Index < servicioCount)
                {
                    Servicio servicio1 = servicios[servicio1Index];
                    Servicio servicio2 = servicios[servicio2Index];

                    Boleta nuevaBoleta = new Boleta
                    {
                        Codigo = boletaCount + 1,
                        Mascota = mascotaSeleccionada,
                        Servicio1 = servicio1,
                        Servicio2 = servicio2
                    };
                    nuevaBoleta.CalcularTotal();

                    boletas[boletaCount++] = nuevaBoleta;
                    Console.WriteLine("Boleta creada con éxito.");
                }
                else
                {
                    Console.WriteLine("Índices de servicios inválidos.");
                }
            }
            else
            {
                Console.WriteLine("Índice de mascota inválido.");
            }
            Console.ReadKey();
        }
        static void ListarBoletas()
        {
            Console.WriteLine("=== Lista de Boletas ===");
            for (int i = 0; i < boletaCount; i++)
            {
                Console.WriteLine($"{i}. {boletas[i]}");
            }
            Console.ReadKey();
        }


    }
}
