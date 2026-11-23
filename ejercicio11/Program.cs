using System;
using System.Collections.Generic;

namespace ejercicio11
{
    internal class Program
    {
        class Libro
        {
            public string Titulo { get; set; }
            public string Categoria { get; set; }
        }

        delegate bool FiltroLibros(Libro libro);

        static void MostrarLibrosPorCategoria(List<Libro> libros, FiltroLibros delegado)
        {
            foreach (Libro libro in libros)
            {
                if (delegado(libro))
                {
                    Console.WriteLine("- " + libro.Titulo);
                }
            }
        }

        static void Main(string[] args)
        {
            List<Libro> libros = new List<Libro>();

            libros.Add(new Libro { Titulo = "El hobbit", Categoria = "Ficción" });
            libros.Add(new Libro { Titulo = "Harry Potter", Categoria = "Ficción" });

            string titulo;
            string categoria;

            Console.Write("Introduce el título de un libro: ");
            titulo = Console.ReadLine();

            Console.Write("Introduce la categoría del libro: ");
            categoria = Console.ReadLine();

            libros.Add(new Libro { Titulo = titulo, Categoria = categoria });

            FiltroLibros delegado = delegate (Libro libro)
            {
                return libro.Categoria.ToLower().Replace("ó", "o") == "ficcion";
            };

            Console.WriteLine("Libros de la categoría Ficción:");

            MostrarLibrosPorCategoria(libros, delegado);
        }
    }
}