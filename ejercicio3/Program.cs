using System;

namespace ejercicio3
{
    internal class Program
    {
        delegate double ConvertirTemperatura(double celsius);

        static void Main(string[] args)
        {
            double temperatura1 = 0;
            double temperatura2 = 30;

            ConvertirTemperatura delegado = delegate (double celsius)
            {
                return (celsius * 9 / 5) + 32;
            };

            Console.WriteLine(temperatura1 + "ºC -> " + delegado(temperatura1) + "ºF");
            Console.WriteLine(temperatura2 + "ºC -> " + delegado(temperatura2) + "ºF");

            Console.ReadKey();
        }
    }
}
