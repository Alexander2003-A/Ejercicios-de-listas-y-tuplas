using System;
using System.Collections.Generic;

namespace Ejercicio4_Loteria
{
    class Loteria
    {
        public void Ejecutar()
        {
            List<int> numeros = new List<int>();

            Console.WriteLine("Ejercicio 4 - Números ganadores de la lotería");
            Console.WriteLine("Ingrese 6 números (uno por uno):");

            for (int i = 1; i <= 6; i++)
            {
                int num;
                while (true)
                {
                    Console.Write($"Número {i}: ");
                    if (int.TryParse(Console.ReadLine(), out num))
                    {
                        numeros.Add(num);
                        break;
                    }
                    Console.WriteLine("Entrada inválida. Ingrese un número entero.");
                }
            }

            numeros.Sort();

            Console.WriteLine("\nNúmeros ordenados de menor a mayor:");
            Console.WriteLine(string.Join(", ", numeros));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Loteria ejercicio = new Loteria();
            ejercicio.Ejecutar();

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
