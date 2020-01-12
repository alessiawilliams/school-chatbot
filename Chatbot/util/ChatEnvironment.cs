using System;
using Chatbot.response;

namespace Chatbot.util
{
	public abstract class ChatEnvironment
	{
		private static readonly Chatbot Bot = new Chatbot();
		public static void CreateChatEnvironment()
		{
			Console.Clear();
			Console.Title = "ACTIVE CHAT: Aery Chatbot";
			Console.WriteLine("To exit, press Ctrl-C.\n");
			Chat();
		}

		private static void Chat()
		{
			Console.WriteLine("Hello.");
			while (true) //TODO: handle shutdown
			{
				string lastInput = TakeInput();
				int respId = CheckInput(lastInput);
				Console.WriteLine(Respond(respId));
			}
		}

		private static string TakeInput()
		{
			Console.Write(">> ");
			return Console.ReadLine().ToLower(); //TODO: Error handling
		}

		private static int CheckInput(string str)
		{
			foreach (Response r in Bot.GetResponses())
			{
				if (r.Trigger.IsMatch(str))
				{
					return r.Id;
				}
			}

			return -1; // -1 is an invalid ID used when a response is not found.
		}

		private static string Respond(int id)
		{
			if (id == -1)
			{
				return "Hm, I'm not sure what you mean.";
			}
			
			return Bot.GetResponses()[id].Text;
		}
	}
}
