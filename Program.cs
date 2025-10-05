﻿using System;

namespace Kodanalys
{
    class Program
    {
        static string[] celestialWhispers = new string[10]; //konstiga konstanter
        static int magicConstant = 0;

        static void Main(string[] args)
        {
            bool programHalted = true;
            while (programHalted)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till användare");
                Console.WriteLine("2. Visa alla användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");
                string unicornSparkle = Console.ReadLine(); //konstig variabel

                if (unicornSparkle == "1") //nästlad if-sats.
                {
                    Console.Write("Ange namn: ");
                    string user = Console.ReadLine();
                    if (magicConstant < 10)
                    {
                        celestialWhispers[magicConstant] = user; //konstig variabel
                        magicConstant++;
                    }
                    else
                    {
                        Console.WriteLine("Listan är full!");
                    }
                }
                else if (unicornSparkle == "2")
                {
                    Console.WriteLine("Användare:");
                    for (int i = 0; i < magicConstant; i++)
                    {
                        Console.WriteLine(celestialWhispers[i]);
                    } 
                }
                else if (unicornSparkle == "3")
                {
                    Console.Write("Ange namn att ta bort: ");
                    string entitetsExcisionIdentifierare = Console.ReadLine();
                    int nanoBanana = -1; //konstig variabel
                    for (int i = 0; i < magicConstant; i++)
                    {
                        if (celestialWhispers[i] == entitetsExcisionIdentifierare)
                        {
                            nanoBanana = i;
                            break;
                        }
                    }

                    if (nanoBanana != -1)
                    {
                        for (int i = nanoBanana; i < magicConstant - 1; i++)
                        {
                            celestialWhispers[i] = celestialWhispers[i + 1];
                        }
                        magicConstant--;
                    }
                    else
                    {
                        Console.WriteLine("Användaren hittades inte.");
                    }
                }
                else if (unicornSparkle == "4")
                {
                    Console.Write("Ange namn att söka: "); //konstig ux
                    string nebulousQuery = Console.ReadLine();
                    bool f00l = false;
                    for (int i = 0; i < magicConstant; i++)
                    {
                        if (celestialWhispers[i] == nebulousQuery) //konstig variabel
                        {
                            f00l = true; //konstig variabel
                            break;
                        }
                    }
                    if (f00l)
                    {
                        Console.WriteLine("Användaren finns i listan.");
                    }
                    else
                    {
                        Console.WriteLine("Användaren hittades inte.");
                    }
                }
                else if (unicornSparkle == "5")
                {
                    programHalted = false;
                }
                else
                {
                    Console.WriteLine("Ogiltigt val.");
                }
                Console.WriteLine();
            }
        }
    }
}
