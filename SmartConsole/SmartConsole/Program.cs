using System;

namespace SmartConsole
{
	internal class Program
	{
		const string error = "И нахуя ты это сюда вставил, придурок?";
		const string hello = "Hello World!!!";

		private static void Main(string[] args)
		{
			string message = args.Length > 0 ? error : hello;
			Console.WriteLine(message);

			//это чтоб точно не закрылось.
			Console.ReadLine();
		}
	}
}
