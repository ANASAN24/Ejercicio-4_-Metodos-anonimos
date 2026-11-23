using System;

namespace ejercicio5
{
    internal class Program
    {
        delegate bool CompararLongitud(string palabra1, string palabra2);

        static void Main(string[] args)
        {
            string palabra1;
            string palabra2;

            Console.Write("Introduce la primera palabra: ");
            palabra1 = Console.ReadLine();

            Console.Write("Introduce la segunda palabra: ");
            palabra2 = Console.ReadLine();

            CompararLongitud delegado = delegate (string palabra1, string palabra2)
            {
                return palabra1.Length == palabra2.Length;
            };

            Console.WriteLine("Las palabras '" + palabra1 + "' y '" + palabra2 + "' tienen la misma longitud: " + delegado(palabra1, palabra2));

            Console.WriteLine("Ejemplo:");
            Console.WriteLine("Las palabras 'gato' y 'perro' tienen la misma longitud: " + delegado("gato", "perro"));
        }
    }
}
