using System;
using System.Collections.Generic;

namespace NotesExamen_bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenid@ al programa para gestión de alumnos");
            Console.WriteLine("Introduzca las notas de los alumnos");

            var notasDeAlumnos = new List<double>();

            var keepdoing = true;

            var escapeword = "exit";

            while (keepdoing)
            {
                Console.WriteLine($"Nota del alumno {notasDeAlumnos.Count + 1}:");

                var notatext = Console.ReadLine();

                if (notatext == escapeword)
                {
                    keepdoing = false;
                }
                else
                {
                    if (double.TryParse(notatext, out double nota))
                    {
                        notasDeAlumnos.Add(nota);
                    }
                    else
                    {
                        Console.WriteLine("El formato de la nota introducida es incorrecta, cap de suro!");
                    }
                }
            }

            var suma = 0.0;
            
            for (int i = 0; i < notasDeAlumnos.Count; i++)
            {
                suma += notasDeAlumnos[i];
            }

            var media = suma / notasDeAlumnos.Count;
                        
            Console.WriteLine($"La nota media es {media}");             

        }
    }
}

