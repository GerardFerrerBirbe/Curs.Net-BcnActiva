using System;

namespace NotesExamen2
{
        class Program
        {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenid@ al programa para gestión de alumnos");
            Console.WriteLine("Introduzca las notas de los alumnos");


            // 1 cambiar el tamaño del array a 10 y meter 10 notas en vez 5
            var notasDeAlumnos = new double[10];

            notasDeAlumnos[0] = 4.6;
            notasDeAlumnos[1] = 2.3;
            notasDeAlumnos[2] = 6;
            notasDeAlumnos[3] = 3.9;
            notasDeAlumnos[4] = 8.5;
            notasDeAlumnos[5] = 8.6;
            notasDeAlumnos[6] = 3.3;
            notasDeAlumnos[7] = 8;
            notasDeAlumnos[8] = 6.9;
            notasDeAlumnos[9] = 5.5;

            // 2 ajustar la media
            var suma = notasDeAlumnos[0] +
                        notasDeAlumnos[1] +
                        notasDeAlumnos[2] +
                        notasDeAlumnos[3] +
                        notasDeAlumnos[4] +
                        notasDeAlumnos[5] +
                        notasDeAlumnos[6] +
                        notasDeAlumnos[7] +
                        notasDeAlumnos[8] +
                        notasDeAlumnos[9];

            var media = suma / notasDeAlumnos.Length;
            Console.WriteLine($"la media es {media}");

            // 3 extraer la nota más alta del array y enseñarla en pantalla

            var max = notasDeAlumnos[0];

            for (int i = 0; i < notasDeAlumnos.Length; i++)
            {
                if (notasDeAlumnos[i] > max)
                {
                    max = notasDeAlumnos[i];
                }
            }
            Console.WriteLine($"la nota máxima es {max}");

            // 4 extraer la nota más baja del array y enseñarña en pantalla

            var min = notasDeAlumnos[0];

            for (int i = 0; i < notasDeAlumnos.Length; i++)
            {
                if (notasDeAlumnos[i] < min)
                {
                    min = notasDeAlumnos[i];
                }
            }
            Console.WriteLine($"la nota mínima es {min}");

            }
        }
}

