using System;
using System.Threading;

namespace Chatbot.util
{
    public class Menu
    {
        Console.WriteLine("Hello, and welcome to Chatbot. What would you like to do today? ::" +
			"1 :: Enter Chatbot" +
			"2 :: Quit);
		Console.Write("Please select an option: ");
		try
		{
			int input = int.Parse(Console.ReadLine); // May throw format exception.
			switch(input)
			{
				case 1:
					// TODO: Enter chatbot
					break;
				case 2:
					Environment.Exit(0);
					break;
				default:
					throw new ArgumentException();
			}
		}
		catch(SystemException e)
		{
			Console.WriteLine("I'm not sure what you mean. Please try again:");
			Thread.Sleep(1000);
			Menu();
		}
    }
}
