using System;

namespace ejercicio7
{
    internal class Program
    {
        delegate int ContarCaracteres(string palabra);

        static void Main(string[] args)
        {
            string palabra;

            Console.Write("Introduce una palabra para contar sus caracteres: ");
            palabra = Console.ReadLine();

            ContarCaracteres delegado = delegate (string palabra)
            {
                return palabra.Length;
            };

            Console.WriteLine("La palabra '" + palabra + "' tiene " + delegado(palabra) + " caracteres");

            Console.WriteLine("Ejemplos:");
            Console.WriteLine("La palabra 'mundo' tiene " + delegado("mundo") + " caracteres");
            Console.WriteLine("La palabra 'programa' tiene " + delegado("programa") + " caracteres");
        }
    }
}