using System;
using System.Collections.Generic;

namespace ejercicio10
{
    internal class Program
    {
        class Empleado
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
        }

        delegate bool FiltroEmpleado(Empleado empleado);

        static void FiltrarEmpleados(List<Empleado> empleados, FiltroEmpleado delegado)
        {
            foreach (Empleado empleado in empleados)
            {
                if (delegado(empleado))
                {
                    Console.WriteLine("- " + empleado.Nombre + " (Edad: " + empleado.Edad + ")");
                }
            }
        }

        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

            empleados.Add(new Empleado { Nombre = "Ana", Edad = 35 });
            empleados.Add(new Empleado { Nombre = "Luis", Edad = 42 });

            string nombre;
            int edad;

            Console.Write("Introduce el nombre de un empleado: ");
            nombre = Console.ReadLine();

            Console.Write("Introduce la edad del empleado: ");
            edad = Convert.ToInt32(Console.ReadLine());

            empleados.Add(new Empleado { Nombre = nombre, Edad = edad });

            FiltroEmpleado delegado = delegate (Empleado empleado)
            {
                return empleado.Edad > 30;
            };

            Console.WriteLine("Empleados mayores de 30 años:");

            FiltrarEmpleados(empleados, delegado);
        }
    }
}
