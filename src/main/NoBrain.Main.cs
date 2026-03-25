using System;

namespace NoBrain;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== NoBrain AI ===");
        Console.WriteLine("Type something to chat. Type 'exit' to quit.");
        Console.WriteLine();
        
        NoBrainBrain brain = new NoBrainBrain();
        
        while (true)
        {
            Console.Write("You: ");
            string input = Console.ReadLine()?.ToLower().Trim() ?? "";
            
            if (input == "")
            {
                continue;
            }
            
            string response = brain.GetResponse(input);
            Console.WriteLine("NoBrain: " + response);
            Console.WriteLine();
            
            if (input == "exit" || input == "bye")
            {
                break;
            }
        }
        
        Console.WriteLine("Program ended. Press any key to exit...");
        Console.ReadKey();
    }
}
