using System;

namespace NoBrain
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to NoBrain AI!");
            Console.WriteLine("Type 'exit','quit' or say bye to exit");
            bool run = true;
            while (run)
            {
                Console.Write("You:\n");
                string input = Console.ReadLine()?.ToLower().ToLower() ?? "";
                Console.Write("NoBrain:\n");
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Sorry,please type anything!");
                    continue;
                }
                else if (input.Contains("exit") || input.Contains("quit"))
                {
                    run = false;
                }
                // Tạm thời là thế này đã
            }
        }
    }
}
