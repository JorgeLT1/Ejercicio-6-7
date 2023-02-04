using System;
using System.Collections;

namespace Ejercicio2
{
    class Programa
    {
        public static void Main(string[] args)
        {
            Hashtable diccionario = new Hashtable();

            diccionario.Add("Perro", "El perro es un descendiente domesticado del lobo.");
            diccionario.Add("Gato", "Es un animal pequeño. Es vertebrado porque tiene huesos y principalmente carnívoro porque se alimenta de carne y otros pequeños animales.");
            diccionario.Add("Leon", "Es un mamífero carnívoro de la familia de los félidos y una de las cinco especies del género Panthera.");
            Console.WriteLine("Ingresa una palabra para buscar en el diccionario:");
            
            string palabra = Console.ReadLine();

            if (diccionario.ContainsKey(palabra))
            {
                Console.WriteLine("Definición: " + diccionario[palabra]);
            }
            else
            {
                Console.WriteLine("La palabra no se encuentra en el diccionario.");
            }
        }
    }
}
