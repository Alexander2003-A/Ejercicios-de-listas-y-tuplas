using System;
using System.Collections.Generic;

namespace Ejercicio10_Precios
{
    class Precios
    {
        public void Ejecutar()
        {
            List<double> precios = new List<double>()
            {
                12.50, 8.99, 25.30, 4.75, 19.90
            };

            double menor = precios[0];
            double mayor = precios[0];

            foreach (double precio in precios)
            {
                if (precio < menor)
                    menor = precio;

                if (precio > mayor)
                    mayor = precio;
            }

            Console.WriteLine("Lista de precios:");
            Console.WriteLine(string.Join(", ", precios));

            Console.WriteLine($"\nPrecio menor: {menor}");
            Console.WriteLine($"Precio mayor: {mayor}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Precios ejercicio = new Precios();
            ejercicio.Ejecutar();

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
