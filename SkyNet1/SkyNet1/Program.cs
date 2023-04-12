using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;

namespace SkyNetConsoleApp
{
    

    namespace EjercicioEliminadores
    {
        class Program
        {
            static List<Eliminador> eliminadores = new List<Eliminador>();

            static void Main(string[] args)
            {
                bool salir = false;

                do
                {
                    Console.WriteLine("Seleccione una opción:");
                    Console.WriteLine("1. Ingresar Eliminador");
                    Console.WriteLine("2. Buscar Eliminador");
                    Console.WriteLine("3. Mostrar Eliminadores");
                    Console.WriteLine("4. Destruir SkyNet");
                    Console.WriteLine("5. Salir");

                    int opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            IngresarEliminador();
                            break;
                        case 2:
                            BuscarEliminador();
                            break;
                        case 3:
                            MostrarEliminadores();
                            break;
                        case 4:
                            DestruirSkyNet();
                            break;
                        case 5:
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Intente de nuevo.");
                            break;
                    }
                } while (!salir);
            }

            static void IngresarEliminador()
            {
                Console.WriteLine("Ingrese el número de serie del Eliminador:");
                string numeroSerie = Console.ReadLine();

                Console.WriteLine("Ingrese el tipo del Eliminador (T-1, T-800, T-1000 o T-3000):");
                string tipo = Console.ReadLine();

                Console.WriteLine("Ingrese la prioridad base del Eliminador (1, 2, 3, 4 o 5):");
                int prioridadBase = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el objetivo del Eliminador:");
                string objetivo = Console.ReadLine();

                Console.WriteLine("Ingrese el año de destino del Eliminador:");
                int anoDestino = int.Parse(Console.ReadLine());

                Eliminador eliminador = new Eliminador(numeroSerie, tipo, prioridadBase, objetivo, anoDestino);
                eliminadores.Add(eliminador);

                Console.WriteLine("Eliminador agregado exitosamente.");
            }

            static void BuscarEliminador()
            {
                Console.WriteLine("Ingrese el número de serie del Eliminador:");
                string numeroSerie = Console.ReadLine();

                Eliminador eliminador = eliminadores.Find(e => e.NumeroSerie == numeroSerie);

                if (eliminador == null)
                {
                    Console.WriteLine("Eliminador no encontrado.");
                }
                else
                {
                    Console.WriteLine(eliminador);
                }
            }

            static void MostrarEliminadores()
            {
                if (eliminadores.Count == 0)
                {
                    Console.WriteLine("No hay eliminadores registrados.");
                }
                else
                {
                    foreach (Eliminador eliminador in eliminadores)
                    {
                        Console.WriteLine(eliminador);
                        Console.WriteLine();
                    }
                }
            }

            static void DestruirSkyNet()
            {
                Console.WriteLine("¡SkyNet ha sido destruido! ¡La humanidad ha sido salvada!");
                eliminadores.Clear();
            }
        }
    }

}
