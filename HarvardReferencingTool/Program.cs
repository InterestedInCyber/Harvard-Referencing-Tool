using System;

namespace HarvardReferencingTool
{
    sealed class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Harvard Referencing Tool");
                Console.WriteLine();

                Console.Write("Last Name: ");
                string? Name = Console.ReadLine();

                Console.Write("First Initial: ");
                string? Initial = Console.ReadLine();

                Console.Write("Year Created: ");
                string? Year = Console.ReadLine();

                Console.Write("Title: ");
                string? Title = Console.ReadLine();

                Console.Write("Location: ");
                string? Place = Console.ReadLine();

                Console.Write("Publisher: ");
                string? Publisher = Console.ReadLine();

                Console.Write("Website: ");
                string? Website = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("[*] Structuring Reference...");
                Console.WriteLine();

                Console.WriteLine($"[+] {Name}, {Initial}. ({Year}). {Title}. {Place}: {Publisher}. Available At: {Website}.");
                Console.WriteLine();

                Console.Write("[?] Generate Another Reference (y/n) ");
                string? anotherReferenceQuery = Console.ReadLine();

                if (anotherReferenceQuery == "y")
                {
                }
                if (anotherReferenceQuery == "n")
                {
                    Console.Clear();
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Option");
                }
            }
        }
    }
}