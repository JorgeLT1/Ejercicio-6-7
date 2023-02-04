using System;
using System.Collections;

namespace Ejercicio1
{
    class Programa
    {
       public static void Main(string[] args)
        {
            ArrayList calificaciones = new ArrayList() { 90, 85, 88, 95, 92 };

            Console.WriteLine("Calificaciones originales: ");
            ImprimirCalificaciones(calificaciones);

            double promedio = CalcularPromedio(calificaciones);
            int max = EncontrarMax(calificaciones);
            int min = EncontrarMin(calificaciones);

            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Calificación máxima: " + max);
            Console.WriteLine("Calificación mínima: " + min);
        }

       public static double CalcularPromedio(ArrayList calificaciones)
        {
            double suma = 0;
            foreach (int calificacion in calificaciones)
            {
                suma += calificacion;
            }
            return suma / calificaciones.Count;
        }

        public static int EncontrarMax(ArrayList calificaciones)
        {
            int max = (int)calificaciones[0];
            foreach (int calificacion in calificaciones)
            {
                if (calificacion > max)
                {
                    max = calificacion;
                }
            }
            return max;
        }

        public static int EncontrarMin(ArrayList calificaciones)
        {
            int min = (int)calificaciones[0];
            foreach (int calificacion in calificaciones)
            {
                if (calificacion < min)
                {
                    min = calificacion;
                }
            }
            return min;
        }

        public static void ImprimirCalificaciones(ArrayList calificaciones)
        {
            Console.WriteLine(string.Join(", ", calificaciones));
        }
    }
}
