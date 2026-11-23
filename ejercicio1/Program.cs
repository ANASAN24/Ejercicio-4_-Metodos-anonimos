using System;

namespace ejercicio1
{
    internal class Program
    {
        delegate int Multiplicar(int x, int y);

        static void Main(string[] args)
        {
            Console.Write("Introduce el primer número para multiplicar: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el segundo número para multiplicar: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Multiplicar delegado = delegate (int x, int y)
            {
                return x * y;
            };

            Console.WriteLine(num1 + " * " + num2 + " = " + delegado(num1, num2));
        }
    }
}
