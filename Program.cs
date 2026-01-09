using System;
using System.Collections.Generic;

namespace EjercicioListas
{
    class Ejercicio1
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

            Console.WriteLine("Asignaturas del curso:");
            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine(asignatura);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1 ejercicio = new Ejercicio1();
            ejercicio.Ejecutar();

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
