using System;

namespace SmartConsole
{
	internal class Program
	{
		const string error = "И нахуя ты это сюда вставил, придурок?";
		const string hello = "Hello World!!!";

		private static void Main(string[] args)
		{
			if (args.Length > 0)
			{
				Console.WriteLine(error);
				return;
			}

			Console.WriteLine(hello);

			//Это чтоб не закрывалось, пон?
			Console.ReadLine();
		}
	}
}
