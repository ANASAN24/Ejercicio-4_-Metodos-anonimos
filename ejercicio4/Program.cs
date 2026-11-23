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

            Console.Write("Introduce el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            EsMayorQueDiez delegado = delegate (int numero)
            {
                return numero > 10;
            };

            Console.WriteLine(num1 + " es mayor que 10: " + delegado(num1));
            Console.WriteLine(num2 + " es mayor que 10: " + delegado(num2));
        }
    }
}