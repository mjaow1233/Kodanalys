using System;

namespace Kodanalys
{
    class Program
    {
        static string[] celestialWhispers = new string[10]; //konstiga konstanter
        static int magicConstant = 0;

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to your diary app");
            while (true)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("1. Lägg till användare");
                    Console.WriteLine("2. Visa alla användare");
                    Console.WriteLine("3. Ta bort en användare");
                    Console.WriteLine("4. Sök efter en användare");
                    Console.WriteLine("5. Avsluta");


                    MenuChoice choice = GetMenuChoice();
                    switch (choice)
                    {
                        case MenuChoice.AddUser:
                            Console.WriteLine("");
                            Console.WriteLine("Lägger till en ny användare");
                            AddUser();
                            break;
                        case MenuChoice.ViewUsers:
                            Console.WriteLine("");
                            ViewUsers();
                            break;
                        case MenuChoice.RemoveUser:
                            Console.WriteLine("");
                            Console.WriteLine("Välj en användare att ta bort");
                            RemoveUser();
                            break;

                        case MenuChoice.SearchUser:
                            Console.WriteLine("");
                            Console.WriteLine("Sök efter en användare");
                            SearchUser();
                            break;


                        case MenuChoice.Exit:
                            Console.WriteLine("");
                            Console.WriteLine("Avsluta programmet");
                            return;
                        default:
                            Console.WriteLine("");
                            Console.WriteLine("inte ett menyval");
                            break;
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine("Tryck på en knapp för att fortsätta");
                    Console.ReadKey(true);
                }

            }
        }
    }
}
