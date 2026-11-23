using System;

namespace ejercicio1
{
    internal class Program
    {
        delegate int Multiplicar(int x, int y);

        static void Main(string[] args)
        {
            int num1 = 4;
            int num2 = 3;

            int num3 = 7;
            int num4 = 5;

            Multiplicar delegado = delegate (int x, int y)
            {
                return x * y;
            };

            Console.WriteLine(num1 + " * " + num2 + " = " + delegado(num1, num2));
            Console.WriteLine(num3 + " * " + num4 + " = " + delegado(num3, num4));
        }
    }
}
