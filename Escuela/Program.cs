using System;
using System.Net.Security;

namespace Escuela
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudiante estudiante1 = new Estudiante("Maria", "Sanchez", 1);
            Estudiante estudiante2 = new Estudiante("Juan", "Jesus", 2);

            Curso cursoS = new Curso { Nombre = "Sociales", Recuento = 5, Ejercicio = 10 };
            Profesor pro1 = new Profesor("Juan", "Agusto");
            Clase claseB = new Clase { Id = "Clase B" };

            pro1.Cursos.Add(cursoS);
            claseB.Estudiantes.Add(estudiante1);
            claseB.Estudiantes.Add(estudiante2);
            claseB.Profesores.Add(pro1);

            Console.WriteLine($"Información de la {claseB.Id}:");
            Console.WriteLine("Estudiantes:");

            foreach (var estudiante in claseB.Estudiantes)
            {
                Console.WriteLine($"- {estudiante.Nombre} (N° {estudiante.id})");
            }

            Console.WriteLine("\nProfesores:");
            foreach (var profesor in claseB.Profesores)
            {
                Console.WriteLine($"- {profesor.Nombre}");
                foreach (var curso in profesor.Cursos)
                {
                    Console.WriteLine($"  Imparte: {curso.Nombre} ({curso.Recuento} clases, {curso.Ejercicio} ejercicios)");
                }
            }
        }
    }
}
