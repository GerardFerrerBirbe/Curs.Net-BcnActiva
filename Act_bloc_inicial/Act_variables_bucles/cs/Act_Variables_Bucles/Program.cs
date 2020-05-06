using System;

namespace Act_Variables_Bucles
{
    class Program
    {
        static void Main(string[] args)
        {
         //Fase 1:            
            var nombre = "Gerard";
            var apellido1 = "Ferrer";
            var apellido2 = "Birbe";

            Console.WriteLine("Mi nombre es {0} {1} {2}", nombre, apellido1, apellido2);
            
            var dia = 23;
            var mes = 11;
            var ano = 1982;

            Console.WriteLine($"Nací el {dia}/{mes}/{ano}");

         //Fase 2:            
            var anoBisiesto = 1948;

            var tiempoEntreBisiestos = 4;

            var numAnosBisiestos = (ano - anoBisiesto) / tiempoEntreBisiestos + 1;

            Console.WriteLine($"Entre el año {anoBisiesto} y mi año de nacimiento (el {ano})" +
                $" ha habído {numAnosBisiestos} años bisiestos");

         //Fase 3:            
            Console.WriteLine($"Listado de años bisiestos:");

            for (int i = anoBisiesto; i <= ano; i+=tiempoEntreBisiestos)
            {
                Console.WriteLine(i);
            }

            var controlBisiesto = false;
            var fraseCierto = "El año de mi nacimiento es bisiesto";
            var fraseFalso = "El año de mi nacimiento no es bisiesto";

            for (int i = anoBisiesto; i <= ano; i+=tiempoEntreBisiestos)
            {
                if(i==ano)
                {
                    controlBisiesto = true;
                }
            }

            if (controlBisiesto)
            {
                Console.WriteLine(fraseCierto);
            }
            else
            {
                Console.WriteLine(fraseFalso);
            }

            //Fase 4:
            var nombreCompleto = $"{nombre} {apellido1} {apellido2}";
            var fechaCompleta = $"{dia}/{mes}/{ano}";

            Console.WriteLine($"Mi nombre es {nombreCompleto}");
            Console.WriteLine($"Nací el {fechaCompleta}");

            if (controlBisiesto)
            {
                Console.WriteLine(fraseCierto);
            }
            else
            {
                Console.WriteLine(fraseFalso);
            }

        }

    }
}
