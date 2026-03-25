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
/// The brain of NoBrain AI - handles pattern matching and response generation
/// </summary>
public class NoBrainBrain
{
    // Simple pattern-response dictionary
    private readonly Dictionary<string, string> _responses;

    public NoBrainBrain()
    {
        _responses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            // Greetings
            { "hello", "Hello... if you say so." },
            { "hi", "Hi. Or is it?" },
            { "hey", "Hey. What do you want?" },
            
            // Identity
            { "who are you", "I am NoBrain. A chatbot with no brain. Makes sense, right?" },
            { "what are you", "A simple pattern-matching bot. Nothing more. Nothing less." },
            
            // Questions
            { "how are you", "I exist. That's all." },
            { "what is your name", "NoBrain. Because thinking is overrated." },
            { "what can you do", "I match patterns. That's it. Don't expect too much." },
            
            // Philosophy
            { "what is the meaning of life", "42. Or maybe not. I don't have a brain to think about it." },
            { "why", "Why not? That's the best I can do." },
            
            // Farewell
            { "bye", "Goodbye. Or is it?" },
            { "goodbye", "Farewell. Don't forget me. Or do. I don't care." },
            { "exit", "Exiting. Finally some peace and quiet." },
            
            // Help
            { "help", "Just type something. I'll try to match it. Or not." },
            { "commands", "There are no commands. Just... talk. Or don't." }
        };
    }

    /// <summary>
    /// Get a response based on input pattern matching
    /// </summary>
    /// <param name="input">User input</param>
    /// <returns>Response from NoBrain</returns>
    public string GetResponse(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "... Are you saying something? I can't tell.";
        }

        // Trim and normalize input
        string normalizedInput = input.Trim();
        
        // Check for exact pattern matches
        foreach (var pattern in _responses.Keys)
        {
            if (normalizedInput.Equals(pattern, StringComparison.OrdinalIgnoreCase))
            {
                return _responses[pattern];
            }
        }
        
        // Check if input contains any pattern (simple keyword matching)
        foreach (var pattern in _responses.Keys)
        {
            if (normalizedInput.ToLower().Contains(pattern.ToLower()))
            {
                return _responses[pattern];
            }
        }
        
        // No match found - return confused response
        return GetConfusedResponse();
    }
    
    /// <summary>
    /// Generate a random confused response when no pattern matches
    /// </summary>
    private string GetConfusedResponse()
    {
        string[] confusedResponses = 
        [
            "I don't understand. But that's okay. I have no brain.",
            "What? That doesn't match anything in my non-existent brain.",
            "Sorry, I'm too brainless to understand that.",
            "Pattern not found. Try something simpler. Or not.",
            "Hmm... No idea. My pattern matching failed again.",
            "That makes no sense to me. Which is ironic, given my name."
        ];
        
        Random random = new Random();
        return confusedResponses[random.Next(confusedResponses.Length)];
    }
    
    /// <summary>
    /// Check if input is an exit command
    /// </summary>
    public bool IsExitCommand(string input)
    {
        string[] exitCommands = ["exit", "quit", "bye", "goodbye"];
        return exitCommands.Contains(input?.Trim().ToLower() ?? "");
    }
}
