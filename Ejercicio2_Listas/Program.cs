using System;
using System.Collections.Generic;

namespace Ejercicio2_Listas
{
    class Ejercicio2
    {
        public void Ejecutar()
        {
            List<string> asignaturas = new List<string>()
            {
                "Matemáticas",
                "Física",
                "Química",
                "Historia",
                "Lengua"
            };

            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine($"Yo estudio {asignatura}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio2 ejercicio = new Ejercicio2();
            ejercicio.Ejecutar();

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
