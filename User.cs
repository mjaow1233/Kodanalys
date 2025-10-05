using System;
using System.Collections.Generic;
using System.Linq;

namespace Kodanalys
{
    public class User
    {
        private readonly List<String> users = new List<string>();
        private const int MaxUsers = 10;

        public void AddUser()
        {
            string? name;
            bool validNameEntered = false;

            while (!validNameEntered)
            {
                Console.Write("Ange namn: ");
                name = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Namnet kan inte vara tomt. Försök igen.");
                    continue;
                }

                if (users.Count >= MaxUsers)
                {
                    Console.WriteLine($"Max antal användare ({MaxUsers}) är nått.");
                    return;
                }

                if (users.Any(u => u.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine($"Användaren '{name}' finns redan. Försök igen.");
                    continue;
                }

                users.Add(name);
                Console.WriteLine($"Användaren '{name}' har lagts till.");
                validNameEntered = true;
            }



        }




        public void SearchUser()
        {
            while (true)
            {
                Console.Write("Ange namn att söka efter ");
                string? input = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Namnet kan inte vara tomt. Försök igen.");
                    continue;
                }

                var matches = users
                    .Where(u => u.Contains(input, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (matches.Count > 0)
                {
                    Console.WriteLine("Resultat:");
                    foreach (var match in matches)
                    {
                        Console.WriteLine($"- {match}");
                    }
                }
                else
                {
                    Console.WriteLine("Inga användare hittades i sökningen");
                }

                break;
            }
        }


        public void RemoveUser()
        {
            ViewUsers();
            if (users.Count == 0)
                return;

            Console.Write("Ange numret på användaren att ta bort: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int number) || number < 1 || number > users.Count)
            {
                Console.WriteLine("Ogiltigt nummer.");
                return;
            }

            string userToRemove = users[number - 1];

            Console.Write($"Är du säker på att du vill ta bort '{userToRemove}'? (j/n): ");
            string? confirm = Console.ReadLine()?.Trim().ToLower();

            if (confirm == "j")
            {
                users.RemoveAt(number - 1);
                Console.WriteLine($"Användaren '{userToRemove}' har tagits bort.");
            }
            else
            {
                Console.WriteLine("Borttagning avbruten.");
            }
        }


        public void ViewUsers()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("Inga användare.");
                return;
            }

            Console.WriteLine("Användare:");
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {users[i]}");
            }
        }

    }
}

