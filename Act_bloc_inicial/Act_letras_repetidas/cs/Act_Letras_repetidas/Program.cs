using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Act_Letras_repetidas
{
    class Program
    {
        static string Escapeword = "ok";
        
        static void Main(string[] args)
        {
            //FASE 1:

            Console.WriteLine("FASE 1:");

            char[] caracteresNombre = { 'G', 'E', 'R', 'A', 'R', 'D' };

            for (int i = 0; i < caracteresNombre.Length; i++)
            {
                Console.Write(caracteresNombre[i]);
            }
            
        //FASE 2:            

            var nameList = new List<char>();
                        
            bool Keepdoing = true;

            Console.WriteLine("");
            Console.WriteLine("FASE 2:");
            Console.WriteLine("Escribe tu nombre:");
                            
            while (Keepdoing)
            {
                Console.WriteLine($"{nameList.Count + 1}a letra:");
                string caracterText = Console.ReadLine();

                if (caracterText == Escapeword)
                {
                    Keepdoing = false;
                }
                else
                {
                    if (char.TryParse(caracterText, out char letra))
                    {
                        if (char.IsLetter(letra))
                        {
                            nameList.Add(letra);

                            if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U'
                                || letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                            {
                                Console.WriteLine("Vocal");
                            }
                            else
                            {
                                Console.WriteLine("Consonante");
                            }
                        }                             
                                               
                        else if (char.IsDigit(letra))
                        {
                            Console.WriteLine($"Los nombres de personas no tienen números!");
                        }
                        else
                        {
                            Console.WriteLine($"Has introducido un carácter inválido.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Has introducido más de un carácter.");
                    }
                }
            }              
                       

            for (int i = 0; i < nameList.Count; i++)
            {
                Console.Write(nameList[i]);
            }

            //FASE 3:
            Console.WriteLine("");
            Console.WriteLine("FASE 3:");
            
            var midiccionario = new Dictionary<char, int>();

            bool Keepdoing2 = true;

            Console.WriteLine("");
            Console.WriteLine("Escribe tu nombre:");

            while (Keepdoing2)
            {
                Console.WriteLine($"{midiccionario.Count + 1}a letra:");
                string caracterText2 = Console.ReadLine();

                if (caracterText2 == Escapeword)
                {
                    Keepdoing2 = false;
                }
                else
                {                                  
                    if (char.TryParse(caracterText2, out char letra2))
                    {
                        if (char.IsLetter(letra2))
                        {
                            var letra2Upper = Char.ToUpper(letra2);
                            
                            if (midiccionario.TryGetValue(letra2Upper, out int value))
                            {
                                midiccionario[letra2Upper] = value + 1;
                            }
                            else
                            {                                
                                midiccionario.Add(letra2Upper, 1);
                            }
                        }

                        else if (char.IsDigit(letra2))
                        {
                            Console.WriteLine($"Los nombres de personas no tienen números!");
                        }
                        else
                        {
                            Console.WriteLine($"Has introducido un carácter inválido.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Has introducido más de un carácter.");
                    }
                }
            }

            Console.WriteLine("Veces que se repiten las letras de tu nombre:");
            
            foreach (var par in midiccionario)
            {
                Console.WriteLine($"{par.Key}: {par.Value}");
            }

            //FASE 4:
            Console.WriteLine("");
            Console.WriteLine("FASE 4:");

            var surnameList = new List<char>();

            bool Keepdoing3 = true;

            Console.WriteLine("");
            Console.WriteLine("Escribe tu apellido:");

            while (Keepdoing3)
            {
                Console.WriteLine($"{surnameList.Count + 1}a letra:");
                string caracterText3 = Console.ReadLine();

                if (caracterText3 == Escapeword)
                {
                    Keepdoing3 = false;
                }
                else
                {
                    if (char.TryParse(caracterText3, out char letra3))
                    {
                        if (char.IsLetter(letra3))
                        {
                            surnameList.Add(letra3);
                        }

                        else if (char.IsDigit(letra3))
                        {
                            Console.WriteLine($"Los nombres de personas no tienen números!");
                        }
                        else
                        {
                            Console.WriteLine($"Has introducido un carácter inválido.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Has introducido más de un carácter.");
                    }
                }
            }

            var fullNameList = new List<char>();
            fullNameList.AddRange(nameList);
            fullNameList.Add(' ');
            fullNameList.AddRange(surnameList);

            Console.WriteLine("Nombre completo:");
            
            foreach (var item in fullNameList)
            {
                Console.Write(item);
            }


        }
                
    }
    
}
