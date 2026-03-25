using System;

namespace NoBrain;

public class NoBrainBrain
{
    public string GetResponse(string input)
    {
        // LỜI CHÀO
        if (input == "hello" || input == "hi" || input == "hey")
        {
            return "Hello! I'm NoBrain!";
        }
        
        // HỎI TÊN
        if (input == "what is your name" || input == "who are you")
        {
            return "My name is NoBrain!";
        }
        
        // HỎI KHỎE
        if (input == "how are you")
        {
            return "I'm fine! I have no brain so I never get tired!";
        }
        
        // HỎI LÀM GÌ ĐƯỢC
        if (input == "what can you do")
        {
            return "I can chat with you! Just type something!";
        }
        
        // HỎI BAO NHIÊU TUỔI
        if (input == "how old are you")
        {
            return "I'm 1 year old! I was just born!";
        }
        
        // NÓI CẢM ƠN
        if (input == "thank you" || input == "thanks")
        {
            return "You're welcome!";
        }
        
        // NÓI TẠM BIỆT
        if (input == "bye" || input == "goodbye")
        {
            return "Goodbye! See you later!";
        }
        
        // NẾU KHÔNG HIỂU
        return "Sorry, I don't understand. I'm just a simple bot!";
    }
}
