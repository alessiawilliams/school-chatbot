using System;
using System.Collections.Generic;
using Chatbot.response;

namespace Chatbot
{
    public class Chatbot
    {
        // Fields
        private readonly ResponseSet _responses;
        
        // Constructor: When a ChatBot is instantiated, it creates a ResponseSet
        public Chatbot()
        {
            this._responses = new ResponseSet();
            Console.WriteLine("Responses assigned to bot");
        }

        public List<Response> GetResponses()
        {
            return _responses.Set;
        }
    }
}