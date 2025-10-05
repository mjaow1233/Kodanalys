using System;
using System.Collections.Generic;
using System.Linq;

namespace Kodanalys
{
    public class User
    {
        private readonly List<string> users = new List<string>();
        private const int MaxUsers = 10;

        public void AddUser()
        {
            Console.Write("Ange namn: ");
            string? name = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Skriv in ett namn");
                return;
            }

            if (users.Count >= MaxUsers)
            {
                Console.WriteLine("Max antal användare nått.");
                return;
            }

            if (users.Any(u => u.Equals(name, StringComparison.OrdinalIgnoreCase))) //använder listan och ser även till att versaler/gemener inte bråkar
            {
                Console.WriteLine("Användaren finns redan.");
                return;
            }

            users.Add(name);
            Console.WriteLine($"Användaren '{name}' har lagts till.");
        }

        public void SearchUser()
        {
            Console.Write("Ange namn att söka efter");
            string? name = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Kan inte vara tomt");
                return;
            }

            bool found = users.Any(u => u.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (found)
                Console.WriteLine("Användaren finns i listan.");
            else
                Console.WriteLine("Användaren hittades inte.");
        }
        public void RemoveUser()
        {
            Console.Write("Ange namn att ta bort: ");
            string? name = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Namnet kan inte vara tomt.");
                return;
            }
            int index = users.FindIndex(u => u.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (index >= 0)
            {
                users.RemoveAt(index);
                Console.WriteLine($"Användaren '{name}' har tagits bort.");
            }
            else
            {
                Console.WriteLine("Användaren hittades inte.");
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

