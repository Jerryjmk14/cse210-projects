using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string response;
        
        do
        {
            Reference reference = new Reference("John", 3, 16);

            Scripture scripture = new Scripture(reference, "For God so loved the world that He gave His one and only Son, that whoever believes in Him shall not perish but have eternal life.");
            Console.WriteLine(scripture.GetDisplayText());

            Console.Write("Press Enter to continue or type 'quit' to exit. ");
            response = Console.ReadLine();

        } while (response.ToLower() != "quit");

    }
}