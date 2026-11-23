using System;

namespace ejercicio3
{
    internal class Program
    {
        delegate double ConvertirTemperatura(double celsius);

        static void Main(string[] args)
        {
            Console.Write("Introduce el primer número para convertir la temperatura: ");
            double temperatura1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce el segundo número para convertir la temperatura: ");
            double temperatura2 = Convert.ToDouble(Console.ReadLine());

            ConvertirTemperatura delegado = delegate (double celsius)
            {
                return (celsius * 9 / 5) + 32;
            };

            Console.WriteLine(temperatura1 + "ºC -> " + delegado(temperatura1) + "ºF");
            Console.WriteLine(temperatura2 + "ºC -> " + delegado(temperatura2) + "ºF");
        }
    }
}
