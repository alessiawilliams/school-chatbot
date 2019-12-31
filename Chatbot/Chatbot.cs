using Chatbot.response;

namespace Chatbot
{
    public class Chatbot
    {
        // Fields
        public ResponseSet Responses;
        
        // Constructor: When a ChatBot is instantiated, it creates a ResponseSet
        public Chatbot()
        {
            this.Responses = new ResponseSet(this);
        }
    }
}