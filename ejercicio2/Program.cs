using System;

namespace ejercicio2
{
    internal class Program
    {
        delegate bool VerificarPalindromo(string palabra);

        static void Main(string[] args)
        {
            Console.Write("Introduce una palabra para saber si es un palíndromo: ");
            string palabra1 = Console.ReadLine();
            string palabra2 = "radar";
            string palabra3 = "puerta";

            VerificarPalindromo delegado = delegate (string palabra)
            {
                string palabraInvertida = "";

                for (int i = palabra.Length - 1; i >= 0; i--)
                {
                    palabraInvertida = palabraInvertida + palabra[i];
                }

                return palabra == palabraInvertida;
            };

            Console.WriteLine("'" + palabra1 + "' es un palíndromo: " + delegado(palabra1));
            Console.WriteLine("Ejemplos: ");
            Console.WriteLine("'" + palabra2 + "' es un palíndromo: " + delegado(palabra2));
            Console.WriteLine("'" + palabra3 + "' es un palíndromo: " + delegado(palabra3));
        }
    }
}
