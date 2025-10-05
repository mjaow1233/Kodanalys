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
    }
}