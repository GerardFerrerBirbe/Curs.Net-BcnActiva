using System;
using System.Collections.Generic;

namespace NotasExamen
{
    class Program
    {
        static string EscapeWord = "exit";

        static void Main(string[] args)
        {
            Console.WriteLine("Introducció de les notes d'exàmen:");
            
            var notesAlumnes = new List<double>();

            var keepDoing = true;

            while (keepDoing)
            {
                Console.WriteLine($"Nota de l'alumne: {notesAlumnes.Count + 1}:");
                var notaText = Console.ReadLine();

                if (notaText == EscapeWord)
                {
                    keepDoing = false;
                }
                else 
                {
                    var nota = 0.0;

                    if (double.TryParse(notaText.Replace(".",","), out nota))
                        //Segons la configuració pels decimals, invertir l'ordre de la , i el .
                    {
                        notesAlumnes.Add(nota);
                    }
                    else
                    {
                        Console.WriteLine("La nota introduida és incorrecte");
                    }
                }
            }

            var suma = 0.0;
            for (var i = 0; i < notesAlumnes.Count; i++)
            {
                suma += notesAlumnes[i];
            }
            var average = suma / notesAlumnes.Count;
            Console.WriteLine("La nota mitja dels exàmens és {0}", average);
        }
    }
}
