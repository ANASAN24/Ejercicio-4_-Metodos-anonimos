using System;

namespace ejercicio2
{
    internal class Program
    {
        delegate bool VerificarPalindromo(string palabra);

        static void Main(string[] args)
        {
            Console.Write("Introduce la primera palabra para ver si es un palíndromo: ");
            string palabra1 = Console.ReadLine();
            Console.Write("Introduce la segunda palabra para ver si es un palíndromo: ");
            string palabra2 = Console.ReadLine();

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
            Console.WriteLine("'" + palabra2 + "' es un palíndromo: " + delegado(palabra2));
        }
    }
}
