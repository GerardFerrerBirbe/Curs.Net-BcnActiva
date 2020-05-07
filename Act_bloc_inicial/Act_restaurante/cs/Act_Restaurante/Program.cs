using System;
using System.Collections.Generic;

namespace Act_Restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //FASE 1:         
            
            int unEuro = 0;
            int dosEuros = 0;
            int cincoEuros = 0;
            int diezEuros = 0;
            int veinteEuros = 0;
            int cincuentaEuros = 0;
            int cienEuros = 0;
            int doscientosEuros = 0;
            int quinientosEuros = 0;

            int precioTotal = 0;

            int numPlatosMenu = 5;

            var menu = new string[numPlatosMenu];
            var precioMenu = new int[numPlatosMenu];

            //FASE 2 i 3:

            Console.WriteLine("Rellena los platos y precio de cada uno que ofreces como restaurante:");
            
            for (int i = 0; i < numPlatosMenu; i++)
            {
                Console.Write($"Plato {i + 1}:");
                menu[i] = Console.ReadLine();
                Console.Write($" - Precio:");
                precioMenu[i] = int.Parse(Console.ReadLine());                
            }

            Console.WriteLine("Lista de platos a escoger:");
            
            for (int i = 0; i < numPlatosMenu; i++)
            {
                Console.WriteLine($"{menu[i]} - {precioMenu[i]} euros");
            }           
            
            int keepdoing = 1;
            var menuSelecc = new List<string>();

            Console.WriteLine("Escribe los platos que quieres:");
            
            while (keepdoing == 1)
            {
                var platoSelecc = Console.ReadLine();


                if (!Array.Exists(menu, element => element == platoSelecc))
                {
                    Console.WriteLine("Este plato no existe en el menú");
                }
                else
                {
                    menuSelecc.Add(platoSelecc);
                    
                    Console.WriteLine("Quieres seguir pidiendo?");
                    Console.WriteLine("Sí: pulsa 1, No: pulsa 0");
                    keepdoing = int.Parse(Console.ReadLine());
                    if (keepdoing != 1)
                    {
                        Console.WriteLine("Gracias");
                    }
                    else
                    {
                        Console.WriteLine("Que quieres más?");
                    }
                }
            }

            Console.WriteLine("Pedido:");                      
            
            foreach (var item in menuSelecc)
            {
                Console.WriteLine(item);

                for (int i = 0; i < menu.Length; i++)
                {
                    if (item == menu[i])
                    {
                        precioTotal += precioMenu[i];
                    }
                }
            }

            Console.WriteLine($"Precio del pedido: {precioTotal}");

            //FASE 4:
            
            int precioAcum = 0;
            
            while (precioAcum != precioTotal)
            {
                if (precioAcum <= precioTotal - 500 )
                {
                    precioAcum += 500;
                    quinientosEuros++;
                }                
                else
                {
                    if (precioAcum <= precioTotal - 200)
                    {
                        precioAcum += 200;
                        doscientosEuros++;
                    }
                    else
                    {
                        if (precioAcum <= precioTotal - 100)
                        {
                            precioAcum += 100;
                            cienEuros++;
                        }
                        else
                        {
                            if (precioAcum <= precioTotal - 50)
                            {
                                precioAcum += 50;
                                cincuentaEuros++;
                            }
                            else
                            {
                                if (precioAcum <= precioTotal - 20)
                                {
                                    precioAcum += 20;
                                    veinteEuros++;
                                }
                                else
                                {
                                    if (precioAcum <= precioTotal - 10)
                                    {
                                        precioAcum += 10;
                                        diezEuros++;
                                    }
                                    else
                                    {
                                        if (precioAcum <= precioTotal - 5)
                                        {
                                            precioAcum += 5;
                                            cincoEuros++;
                                        }
                                        else
                                        {
                                            if (precioAcum <= precioTotal - 2)
                                            {
                                                precioAcum += 2;
                                                dosEuros++;
                                            }
                                            else
                                            {
                                                precioAcum += 1;
                                                unEuro++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }

            Console.WriteLine("Número de billetes y monedas que necesitas para pagar la comida:");
            
            if(quinientosEuros > 0)
            {
                Console.WriteLine($"500 euros: {quinientosEuros}");
            }
            if (doscientosEuros > 0)
            {
                Console.WriteLine($"200 euros: {doscientosEuros}");
            }
            if (cienEuros > 0)
            {
                Console.WriteLine($"100 euros: {cienEuros}");
            }
            if (cincuentaEuros > 0)
            {
                Console.WriteLine($"50 euros: {cincuentaEuros}");
            }
            if (veinteEuros > 0)
            {
                Console.WriteLine($"20 euros: {veinteEuros}");
            }
            if (diezEuros > 0)
            {
                Console.WriteLine($"10 euros: {diezEuros}");
            }
            if (cincoEuros > 0)
            {
                Console.WriteLine($"5 euros: {cincoEuros}");
            }
            if (dosEuros > 0)
            {
                Console.WriteLine($"2 euros: {dosEuros}");
            }
            if (unEuro > 0)
            {
                Console.WriteLine($"1 euro: {unEuro}");
            }
            
        }
    }
}
