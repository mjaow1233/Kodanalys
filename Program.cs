using System;

namespace Kodanalys
{
    class Program
    {
        private static readonly User user = new User();

        static void Main(string[] args)
        {

            Console.WriteLine("Användarhantering");
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
                            user.AddUser();
                            break;
                        case MenuChoice.ViewUsers:
                            Console.WriteLine("");
                            user.ViewUsers();
                            break;
                        case MenuChoice.RemoveUser:
                            Console.WriteLine("");
                            Console.WriteLine("Välj en användare att ta bort");
                            user.RemoveUser();
                            break;

                        case MenuChoice.SearchUser:
                            Console.WriteLine("");
                            Console.WriteLine("Sök efter en användare");
                            user.SearchUser();
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
                static MenuChoice GetMenuChoice()
                {
                    string? input = Console.ReadLine();
                    if (int.TryParse(input, out int num) && Enum.IsDefined(typeof(MenuChoice), num))
                    {
                        return (MenuChoice)num;
                    }
                    return MenuChoice.Invalid;
                }

            }
        }
    }
}
