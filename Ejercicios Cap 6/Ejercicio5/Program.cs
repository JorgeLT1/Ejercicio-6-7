using System;

namespace Ejercicio5
{
    class Programa
    {
    public static void Main(string[] args)
        {
            int[][] arregloJagged = new int[3][];
            arregloJagged[0] = new int[] { 1, 2, 3 };
            arregloJagged[1] = new int[] { 4, 5 };
            arregloJagged[2] = new int[] { 6, 7, 8, 9 };

            Console.WriteLine("Arreglo jagged original: ");
            ImprimirArregloJagged(arregloJagged);

            // Pasar el arreglo jagged como parámetro a la función
            InvertirArregloJagged(arregloJagged);

            Console.WriteLine("Arreglo jagged invertido: ");
            ImprimirArregloJagged(arregloJagged);
        }

     public static void InvertirArregloJagged(int[][] arr)
        {
            foreach (int[] subArr in arr)
            {
                Array.Reverse(subArr);
            }
        }
     public static void ImprimirArregloJagged(int[][] arr)
        {
            foreach (int[] subArr in arr)
            {
                Console.WriteLine(string.Join(", ", subArr));
            }
        }        
    }

}
