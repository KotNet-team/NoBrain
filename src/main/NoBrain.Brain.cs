using System;

namespace NoBrain
{
    class Program
    {
        private static readonly Random _random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("=== NoBrain AI Chatbot ===");
            Console.WriteLine("Type 'exit' to quit");
            Console.WriteLine("------------------------");
            
            while (true)
            {
                Console.Write("\nYou: ");
                string input = Console.ReadLine();
                
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("NoBrain: Say something?");
                    continue;
                }
                
                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("NoBrain: Goodbye!");
                    break;
                }
                
                string response = GetResponse(input);
                Console.WriteLine($"NoBrain: {response}");
            }
        }
        
        public static string GetResponse(string input)
        {
            string lowerInput = input.ToLower();
            
            return lowerInput switch
            {
                "i'm fine" => GetRandomFineResponse(),
                "im fine" => GetRandomFineResponse(),
                "i am fine" => GetRandomFineResponse(),
                "i'm sad" => GetRandomSadResponse(),
                "im sad" => GetRandomSadResponse(),
                "i am sad" => GetRandomSadResponse(),
                "hello" => GetRandomGreeting(),
                "hi" => GetRandomGreeting(),
                "hey" => GetRandomGreeting(),
                "help" => GetRandomHelpResponse(),
                _ => GetRandomDefaultResponse()
            };
        }
        
        private static string GetRandomFineResponse()
        {
            string[] responses = new string[]
            {
                "Glad to hear that! 😊",
                "That's great! What makes you feel good today?",
                "Awesome! Keep that energy!",
                "Nice! Anything exciting happened?",
                "Good for you! I'm... well, I'm just code, but I'm happy for you!"
            };
            
            return responses[_random.Next(responses.Length)];
        }
        
        private static string GetRandomSadResponse()
        {
            string[] responses = new string[]
            {
                "I'm sorry to hear that. Want to talk about it?",
                "That sucks. Remember, it's okay to not be okay.",
                "Sending virtual hugs your way! 🤗",
                "Sometimes even AI feels... wait, no I don't. But I hope you feel better!",
                "Hey, tomorrow is a new day. You've got this!"
            };
            
            return responses[_random.Next(responses.Length)];
        }
        
        private static string GetRandomGreeting()
        {
            string[] responses = new string[]
            {
                "Hi there! How can I help you today?",
                "Hello! Ready to chat?",
                "Hey! What's on your mind?",
                "Greetings, human!",
                "Yo! What's up?"
            };
            
            return responses[_random.Next(responses.Length)];
        }
        
        private static string GetRandomHelpResponse()
        {
            string[] responses = new string[]
            {
                "I can chat with you! Try saying 'hello', 'i'm fine', or 'i'm sad'",
                "Just type something and I'll do my best to respond!",
                "I'm a simple chatbot. Be nice to me please 😅",
                "Commands: hello, i'm fine, i'm sad — or just type anything!",
                "Help? I barely know what I'm doing myself!"
            };
            
            return responses[_random.Next(responses.Length)];
        }
        
        private static string GetRandomDefaultResponse()
        {
            string[] responses = new string[]
            {
                "Hmm, I don't quite understand. Can you rephrase?",
                "Interesting... tell me more?",
                "I'm just a simple AI. That went over my head 😅",
                "Not sure what you mean, but I'm listening!",
                "My pattern matching is confused right now...",
                "*confused AI noises*"
            };
            
            return responses[_random.Next(responses.Length)];
        }
    }
}
