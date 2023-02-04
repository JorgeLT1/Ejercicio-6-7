using System;
using System.Collections.Generic;

namespace Ejercicio5
{
    class Programa
    {
        public static void Main(string[] args)
        {
            List<(string, string)> agenda = new List<(string, string)>();

            while (true)
            {
                Console.WriteLine("\nMenú de opciones:");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Ver contacto");
                Console.WriteLine("3. Salir");
                Console.Write("\nElige una opción: ");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        Console.Write("\nIngresa el nombre: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Ingresa el número: ");
                        string numero = Console.ReadLine();

                        agenda.Add((nombre, numero));
                        Console.WriteLine("Contacto agregado.");
                        break;
                        
                    case 2:

                        Console.Write("\nIngresa el nombre del contacto: ");
                        string nombreABuscar = Console.ReadLine();
                        bool encontrado = false;

                        foreach ((string, string) contacto in agenda)
                        {
                            if (contacto.Item1 == nombreABuscar)
                            {
                                Console.WriteLine($"Número de {contacto.Item1}: {contacto.Item2}");
                                encontrado = true;
                                break;
                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine("Contacto no encontrado.");
                        }

                        break;

                    case 3:
                        Console.WriteLine("Saliendo...");
                        return;
                }
            }
        }
    }
}
