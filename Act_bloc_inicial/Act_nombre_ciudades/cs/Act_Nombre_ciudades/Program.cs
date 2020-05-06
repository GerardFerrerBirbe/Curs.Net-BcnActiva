using System;
using System.Collections;
using System.Collections.Immutable;
using System.Globalization;

namespace Act_Nombre_ciudades
{
    class Program
    {
        static void Main(string[] args)
        {

            //FASE 1:
            Console.WriteLine("FASE 1:");

            string ciudad1 = "";
            string ciudad2 = "";
            string ciudad3 = "";
            string ciudad4 = "";
            string ciudad5 = "";
            string ciudad6 = "";

            Console.WriteLine($"Introduzca el nombre de la 1a ciudad");
            ciudad1 = Console.ReadLine();
            Console.WriteLine($"Introduzca el nombre de la 2a ciudad");
            ciudad2 = Console.ReadLine();
            Console.WriteLine($"Introduzca el nombre de la 3a ciudad");
            ciudad3 = Console.ReadLine();
            Console.WriteLine($"Introduzca el nombre de la 4a ciudad");
            ciudad4 = Console.ReadLine();
            Console.WriteLine($"Introduzca el nombre de la 5a ciudad");
            ciudad5 = Console.ReadLine();
            Console.WriteLine($"Introduzca el nombre de la 6a ciudad");
            ciudad6 = Console.ReadLine();

            Console.WriteLine("Listado de las ciudades:");
            Console.WriteLine(ciudad1);
            Console.WriteLine(ciudad2);
            Console.WriteLine(ciudad3);
            Console.WriteLine(ciudad4);
            Console.WriteLine(ciudad5);
            Console.WriteLine(ciudad6);

            //FASE 2:
            Console.WriteLine("FASE 2:");
            Console.WriteLine("Listado de las ciudades ordenadas alfabéticamente:");

            string[] arrayCiudades = { ciudad1, ciudad2, ciudad3, ciudad4, ciudad5, ciudad6 };

            Array.Sort(arrayCiudades);

            for (int i = 0; i < arrayCiudades.Length; i++)
            {
                Console.WriteLine(arrayCiudades[i]);
            }

            //FASE 3:
            Console.WriteLine("FASE 3:");
            Console.WriteLine("Listado de las ciudades con el nombre modificado:");

            var n = 6;
            var arratCiudadesModificadas = new string[n];

            for (int i = 0; i < arratCiudadesModificadas.Length; i++)
            {
                arratCiudadesModificadas[i] = arrayCiudades[i].Replace('a', '4');
                Console.WriteLine(arratCiudadesModificadas[i]);
            }

            //FASE 4:
            Console.WriteLine("FASE 4:");
            Console.WriteLine("Listado de las ciudades con las letras invertidas:");

            var arrayCiudad1 = new string[ciudad1.Length];
            var arrayCiudad2 = new string[ciudad2.Length];
            var arrayCiudad3 = new string[ciudad3.Length];
            var arrayCiudad4 = new string[ciudad4.Length];
            var arrayCiudad5 = new string[ciudad5.Length];
            var arrayCiudad6 = new string[ciudad6.Length];

            for (int i = 0; i < ciudad1.Length; i++)
            {
                string letra = ciudad1.Substring(i, 1);
                arrayCiudad1[i] = letra;
            }

            Array.Reverse(arrayCiudad1);

            for (int i = 0; i < ciudad1.Length; i++)
            {
                Console.Write(arrayCiudad1[i]);
            }

            Console.WriteLine("");

            for (int i = 0; i < ciudad2.Length; i++)
            {
                string letra = ciudad2.Substring(i, 1);
                arrayCiudad2[i] = letra;
            }

            Array.Reverse(arrayCiudad2);

            for (int i = 0; i < ciudad2.Length; i++)
            {
                Console.Write(arrayCiudad2[i]);
            }

            Console.WriteLine("");

            for (int i = 0; i < ciudad3.Length; i++)
            {
                string letra = ciudad3.Substring(i, 1);
                arrayCiudad3[i] = letra;
            }

            Array.Reverse(arrayCiudad3);

            for (int i = 0; i < ciudad3.Length; i++)
            {
                Console.Write(arrayCiudad3[i]);
            }

            Console.WriteLine("");

            for (int i = 0; i < ciudad4.Length; i++)
            {
                string letra = ciudad4.Substring(i, 1);
                arrayCiudad4[i] = letra;
            }

            Array.Reverse(arrayCiudad4);

            for (int i = 0; i < ciudad4.Length; i++)
            {
                Console.Write(arrayCiudad4[i]);
            }

            Console.WriteLine("");

            for (int i = 0; i < ciudad5.Length; i++)
            {
                string letra = ciudad5.Substring(i, 1);
                arrayCiudad5[i] = letra;
            }

            Array.Reverse(arrayCiudad5);

            for (int i = 0; i < ciudad5.Length; i++)
            {
                Console.Write(arrayCiudad5[i]);
            }

            Console.WriteLine("");

            for (int i = 0; i < ciudad6.Length; i++)
            {
                string letra = ciudad6.Substring(i, 1);
                arrayCiudad6[i] = letra;
            }

            Array.Reverse(arrayCiudad6);

            for (int i = 0; i < ciudad6.Length; i++)
            {
                Console.Write(arrayCiudad6[i]);
            }
        }
    }
}
