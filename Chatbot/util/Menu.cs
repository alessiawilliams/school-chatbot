using System;
using System.Threading;

namespace Chatbot.util
{
	public abstract class Menu
	{
		public static void RunMenu()
		{
			Console.WriteLine("Hello, and welcome to Aery Chatbot. What would you like to do today? ::");
			Console.WriteLine("1 :: Enter Chatbot");
			Console.WriteLine("2 :: Quit");
			Console.Write("\nPlease select an option: ");
			try
			{
				int input = int.Parse(Console.ReadLine()); // May throw format exception.
				switch (input)
				{
					case 1:
						break;
					case 2:
						Environment.Exit(0);
						break;
					default:
						throw new ArgumentException();
				}
			}
			catch (SystemException)
			{
				Console.WriteLine("I'm not sure what you mean. Please try again:");
				Thread.Sleep(1000);
				Console.Clear();
				RunMenu();
			}
		}
	}
}
