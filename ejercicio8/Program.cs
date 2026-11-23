using System;

namespace ejercicio8
{
    internal class Program
    {
        delegate bool Operacion(int numero);

        static void ProcesarNumero(int numero, Operacion delegado)
        {
            Console.WriteLine("El número " + numero + " es par: " + delegado(numero));
        }

        static void Main(string[] args)
        {
            int num1;

            Console.Write("Introduce un número para saber si es par o impar: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Operacion delegado = delegate (int numero)
            {
                return numero % 2 == 0;
            };

            ProcesarNumero(num1, delegado);

            Console.WriteLine("Ejemplos:");
            ProcesarNumero(4, delegado);
            ProcesarNumero(7, delegado);
        }
    }
}