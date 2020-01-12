using System;
using Chatbot.util;

namespace Chatbot
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Aery Chatbot";
            Menu.RunMenu();
            ChatEnvironment.CreateChatEnvironment();
        }
    }
}
