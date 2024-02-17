using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter something (type 'exit' to end):");

        string userInput;
        string collectedText = "";

        do
        {
            userInput = Console.ReadLine();
            if (userInput.ToLower() != "exit")
            {
                collectedText += userInput + " ";
                Console.WriteLine(collectedText.Trim()); 
            }
        } while (userInput.ToLower() != "exit");

        Console.WriteLine("\nClosing program...");
    }
}

