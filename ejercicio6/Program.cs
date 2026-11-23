using System;

namespace ejercicio6
{
    internal class Program
    {
        delegate int CalcularFactorial(int numero);

        static void Main(string[] args)
        {
            int num1;

            Console.Write("Introduce un número para calcular su factorial: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            CalcularFactorial delegado = delegate (int numero)
            {
                int factorial = 1;

                for (int i = 1; i <= numero; i++)
                {
                    factorial = factorial * i;
                }

                return factorial;
            };

            Console.WriteLine("El factorial de " + num1 + " es: " + delegado(num1));

            Console.WriteLine("Ejemplos:");
            Console.WriteLine("El factorial de 4 es: " + delegado(4));
            Console.WriteLine("El factorial de 6 es: " + delegado(6));
        }
    }
}
