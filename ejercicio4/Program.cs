using System;

namespace ejercicio4
{
    internal class Program
    {
        delegate bool EsMayorQueDiez(int numero);

        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;

            Console.Write("Introduce un número para saber si es mayor o menor que 10: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = 8;
            num3 = 15;

            EsMayorQueDiez delegado = delegate (int numero)
            {
                return numero > 10;
            };

            Console.WriteLine(num1 + " es mayor que 10: " + delegado(num1));
            Console.WriteLine("Ejemplos: ");
            Console.WriteLine(num2 + " es mayor que 10: " + delegado(num2));
            Console.WriteLine(num3 + " es mayor que 10: " + delegado(num3));
        }
    }
}