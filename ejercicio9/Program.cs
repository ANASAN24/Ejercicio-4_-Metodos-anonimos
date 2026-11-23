using System;
using System.Collections.Generic;

namespace ejercicio9
{
    internal class Program
    {
        class Producto
        {
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
        }

        delegate bool Filtro(Producto producto);

        static void MostrarProductosFiltrados(List<Producto> productos, Filtro delegado)
        {
            foreach (Producto producto in productos)
            {
                if (delegado(producto))
                {
                    Console.WriteLine("- " + producto.Nombre + " (Cantidad: " + producto.Cantidad + ")");
                }
            }
        }

        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>();

            productos.Add(new Producto { Nombre = "Televisor", Cantidad = 10 });
            productos.Add(new Producto { Nombre = "Refrigerador", Cantidad = 7 });
            productos.Add(new Producto { Nombre = "Ratón", Cantidad = 3 });
            productos.Add(new Producto { Nombre = "Teclado", Cantidad = 5 });

            string nombre;
            int cantidad;

            Console.Write("Introduce el nombre de un producto: ");
            nombre = Console.ReadLine();

            Console.Write("Introduce la cantidad en stock: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            productos.Add(new Producto { Nombre = nombre, Cantidad = cantidad });

            Filtro delegado = delegate (Producto producto)
            {
                return producto.Cantidad > 5;
            };

            Console.WriteLine("Productos con cantidad mayor a 5:");

            MostrarProductosFiltrados(productos, delegado);
        }
    }
}