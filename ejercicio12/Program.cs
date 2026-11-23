using System;
using System.Collections.Generic;

namespace ejercicio12
{
    internal class Program
    {
        class Vehiculo
        {
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int AnioFabricacion { get; set; }
        }

        delegate bool FiltroVehiculo(Vehiculo vehiculo);

        static void MostrarVehiculosAntiguos(List<Vehiculo> vehiculos, FiltroVehiculo delegado)
        {
            foreach (Vehiculo vehiculo in vehiculos)
            {
                if (delegado(vehiculo))
                {
                    Console.WriteLine("- " + vehiculo.Marca + " " + vehiculo.Modelo + " (" + vehiculo.AnioFabricacion + ")");
                }
            }
        }

        static void Main(string[] args)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            vehiculos.Add(new Vehiculo { Marca = "Toyota", Modelo = "Corolla", AnioFabricacion = 2005 });
            vehiculos.Add(new Vehiculo { Marca = "Honda", Modelo = "Civic", AnioFabricacion = 2008 });

            string marca;
            string modelo;
            int anio;

            Console.Write("Introduce la marca del vehículo: ");
            marca = Console.ReadLine();

            Console.Write("Introduce el modelo del vehículo: ");
            modelo = Console.ReadLine();

            Console.Write("Introduce el año de fabricación: ");
            anio = Convert.ToInt32(Console.ReadLine());

            vehiculos.Add(new Vehiculo { Marca = marca, Modelo = modelo, AnioFabricacion = anio });

            FiltroVehiculo delegado = delegate (Vehiculo vehiculo)
            {
                return vehiculo.AnioFabricacion < 2010;
            };

            Console.WriteLine("Vehículos fabricados antes de 2010:");

            MostrarVehiculosAntiguos(vehiculos, delegado);
        }
    }
}

