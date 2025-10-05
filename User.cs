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
                Console.WriteLine("Listan är full.");
                return;
            }

            if (users.Any(u => u.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Användaren finns redan.");
                return;
            }

            users.Add(name);
            Console.WriteLine($"Användaren '{name}' har lagts till.");
        }
    }
}
