/*
 * NoBrain AI - A simple pattern-matching chatbot
 * Copyright (C) 2026 NoBrain Organization
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

namespace NoBrain;

/// <summary>
/// Entry point for NoBrain AI Console Application
/// </summary>
public static class Program
{
    private static NoBrainBrain? _brain;

    public static void Main(string[] args)
    {
        // Set console properties for better appearance
        Console.Title = "NoBrain AI - Chatbot with no brain";
        Console.ForegroundColor = ConsoleColor.Cyan;
        
        DisplayHeader();
        
        // Initialize the brain
        _brain = new NoBrainBrain();
        
        // Main conversation loop
        RunConversationLoop();
        
        // Exit message
        DisplayFooter();
    }
    
    private static void DisplayHeader()
    {
        Console.WriteLine("╔══════════════════════════════════════════╗");
        Console.WriteLine("║            N O B R A I N   A I          ║");
        Console.WriteLine("║     A chatbot with absolutely no brain  ║");
        Console.WriteLine("╚══════════════════════════════════════════╝");
        Console.WriteLine();
        Console.WriteLine("Type something. Or don't. I don't care.");
        Console.WriteLine("Type 'exit' or 'bye' to leave... if you want.");
        Console.WriteLine();
        Console.WriteLine(new string('─', 50));
        Console.WriteLine();
    }
    
    private static void RunConversationLoop()
    {
        while (true)
        {
            // Get user input
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("You > ");
            Console.ForegroundColor = ConsoleColor.White;
            string? input = Console.ReadLine();
            
            // Check for exit
            if (string.IsNullOrEmpty(input))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("NoBrain > Silence... Interesting.");
                Console.ForegroundColor = ConsoleColor.White;
                continue;
            }
            
            if (_brain!.IsExitCommand(input))
            {
                break;
            }
            
            // Get and display response
            string response = _brain.GetResponse(input);
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("NoBrain > ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(response);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
    
    private static void DisplayFooter()
    {
        Console.WriteLine();
        Console.WriteLine(new string('─', 50));
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("NoBrain > Shutting down... My non-existent brain needs rest.");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine("NoBrain AI - Copyright (C) 2026 NoBrain Organization");
        Console.WriteLine("This program comes with ABSOLUTELY NO WARRANTY.");
        Console.WriteLine("This is free software, and you are welcome to redistribute it");
        Console.WriteLine("under certain conditions. See GPLv3 for details.");
        Console.WriteLine();
        
        #if DEBUG
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        #endif
    }
}
