using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);

        Scripture scripture = new Scripture(
            reference,
            "For God so loved the world that he gave his only begotten Son"
        );

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllHidden())
            {
                break;
            }

            Console.WriteLine("\nPress Enter or type 'quit':");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // hides 3 words each time
        }
    }
}