using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciciLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //FASE 1:

            int[] numbers = { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            //Query syntax:
            /*
            var pairs = from number in numbers
                        where number % 2 == 0
                        select number;
            */
            //Method syntax:
            var pairs = numbers.Where(s => s % 2 == 0);

            Console.WriteLine("Llistat de números parells:");

            foreach (var pair in pairs)
            {
                Console.Write(pair + " ");
            }

            Console.WriteLine();

            //FASE 2:

            Console.WriteLine("Valor màxim:");
            //Query syntax:
            /*
            var max = (from number in numbers
                       select number).Max();
            */
            //Method syntax:
            var max = numbers.Max();

            Console.WriteLine(max);

            Console.WriteLine("Valor mínim:");
            var min = (from number in numbers
                       select number).Min();

            Console.WriteLine(min);

            Console.WriteLine("Mitjana:");
            var avg = (from number in numbers
                       select number).Average();

            Console.WriteLine(avg);

            //FASE 3:

            //Query syntax
            /*
            IEnumerable<int> bigNums = from number in numbers
                                       where number > 5
                                       select number;
            */
            //Method syntax:
            var bigNums = numbers.Where(n => n > 5);

            Console.WriteLine("Llistat de números > 5:");

            foreach (var num in bigNums)
            {
                Console.Write(num + " ");
                Console.WriteLine();
            }

            IEnumerable<int> smallNums = from number in numbers
                                         where number < 5
                                         select number;

            Console.WriteLine("Llistat de números < 5:");

            foreach (var num in smallNums)
            {
                Console.Write(num + " ");
            }

            //FASE 4:

            string[] names = { "David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol" };

            //Query syntax:
            /*
            IEnumerable<string> namesStartO = from name in names
                                        where name.Substring(0,1) == "O"
                                        select name;
            */
            //Method syntax:
            var namesStartO = names.Where(n => n.Substring(0, 1) == "O");

            Console.WriteLine();
            Console.WriteLine("Llistat de noms que comencen amb 'O':");

            foreach (var name in namesStartO)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            IEnumerable<string> namesLength6 = from name in names
                                         where name.Length > 6
                                         select name;

            Console.WriteLine("Llistat de noms que tenen més de 6 lletres:");

            foreach (var name in namesLength6)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            //Query syntax:
            /*
            IEnumerable<string> namesOrdered = from name in names
                                               orderby name descending
                                               select name;
            */
            //Method syntax:
            var namesOrdered = names.OrderByDescending(n => n);

            Console.WriteLine("Llistat de noms ordenats descendentment:");

            foreach (var name in namesOrdered)
            {
                Console.WriteLine(name);
            }

        }
    }
}
