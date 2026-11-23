using System;

namespace ejercicio3
{
    internal class Program
    {
        delegate double ConvertirTemperatura(double celsius);

        static void Main(string[] args)
        {
            Console.Write("Introduce una temperatura para convertir de Celcius a Fahrenheit: ");
            double temperatura1 = Convert.ToDouble(Console.ReadLine());
            double temperatura2 = 0;
            double temperatura3 = 30;

            ConvertirTemperatura delegado = delegate (double celsius)
            {
                return (celsius * 9 / 5) + 32;
            };

            Console.WriteLine(temperatura1 + "ºC -> " + delegado(temperatura1) + "ºF");
            Console.WriteLine("Ejemplos: ");
            Console.WriteLine(temperatura2 + "ºC -> " + delegado(temperatura2) + "ºF");
            Console.WriteLine(temperatura3 + "ºC -> " + delegado(temperatura3) + "ºF");
        }
    }
}
