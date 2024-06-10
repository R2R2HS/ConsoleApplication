using SmartConsole.Types.Structures.Musics;
using System;
using System.Threading;

namespace SmartConsole
{
	internal class Program
	{
		private const string error = "И нахуя ты это сюда вставил, придурок?";
		private const string hello = "Hello World!!!";

		private static readonly BeepsLine[] lines = new BeepsLine[]
		{
			new BeepsLine(125, new Beep(659, 125), new Beep(659, 125)),
	        new BeepsLine(167, new Beep(659, 125)),
	        new BeepsLine(125, new Beep(523, 125), new Beep(659, 125)),
	        new BeepsLine(375, new Beep(784, 125)),
	        new BeepsLine(375, new Beep(392, 125)),
	        new BeepsLine(250, new Beep(523, 125)),
	        new BeepsLine(250, new Beep(392, 125)),
	        new BeepsLine(250, new Beep(330, 125)),
	        new BeepsLine(125, new Beep(440, 125)),
	        new BeepsLine(125, new Beep(494, 125)),
	        new BeepsLine(42, new Beep(466, 125)),
	        new BeepsLine(125, new Beep(440, 125)),
	        new BeepsLine(125, new Beep(392, 125)),
	        new BeepsLine(125, new Beep(659, 125)),
	        new BeepsLine(125, new Beep(784, 125)),
	        new BeepsLine(125, new Beep(880, 125)),
	        new BeepsLine(125, new Beep(698, 125), new Beep(784, 125)),
	        new BeepsLine(125, new Beep(659, 125)),
	        new BeepsLine(125, new Beep(523, 125)),
	        new BeepsLine(125, new Beep(587, 125), new Beep(494, 125)),
	        new BeepsLine(250, new Beep(523, 125)),
	        new BeepsLine(250, new Beep(392, 125)),
	        new BeepsLine(250, new Beep(330, 125)),
	        new BeepsLine(125, new Beep(440, 125)),
	        new BeepsLine(125, new Beep(494, 125)),
	        new BeepsLine(42, new Beep(466, 125)),
	        new BeepsLine(125, new Beep(440, 125)),
	        new BeepsLine(125, new Beep(392, 125)),
	        new BeepsLine(125, new Beep(659, 125)),
	        new BeepsLine(125, new Beep(784, 125)),
	        new BeepsLine(125, new Beep(880, 125)),
	        new BeepsLine(125, new Beep(698, 125), new Beep(784, 125)),
	        new BeepsLine(125, new Beep(659, 125)),
	        new BeepsLine(125, new Beep(523, 125)),
	        new BeepsLine(125, new Beep(587, 125), new Beep(494, 125)),
	        new BeepsLine(375, new Beep(784, 125), new Beep(740, 125), new Beep(698, 125)),
	        new BeepsLine(42, new Beep(622, 125)),
	        new BeepsLine(125, new Beep(659, 125)),
	        new BeepsLine(167, new Beep(415, 125), new Beep(440, 125), new Beep(523, 125)),
	        new BeepsLine(125, new Beep(440, 125), new Beep(523, 125), new Beep(587, 125)),
	        new BeepsLine(250, new Beep(784, 125), new Beep(740, 125), new Beep(698, 125)),
	        new BeepsLine(42, new Beep(622, 125)),
	        new BeepsLine(125, new Beep(659, 125)),
	        new BeepsLine(167, new Beep(698, 125)),
	        new BeepsLine(125, new Beep(698, 125)),
	        new BeepsLine(625, new Beep(784, 125), new Beep(740, 125), new Beep(698, 125)),
	        new BeepsLine(42, new Beep(622, 125)),
	        new BeepsLine(125, new Beep(659, 125)),
	        new BeepsLine(167, new Beep(415, 125), new Beep(440, 125), new Beep(523, 125)),
	        new BeepsLine(125, new Beep(440, 125), new Beep(523, 125), new Beep(587, 125)),
	        new BeepsLine(250, new Beep(622, 125)),
	        new BeepsLine(250, new Beep(587, 125)),
	        new BeepsLine(250, new Beep(523, 125)),
	        new BeepsLine(1125, new Beep(784, 125), new Beep(740, 125), new Beep(698, 125)),
	        new BeepsLine(42, new Beep(622, 125)),
	        new BeepsLine(125, new Beep(659, 125)),
	        new BeepsLine(167, new Beep(415, 125), new Beep(440, 125), new Beep(523, 125)),
	        new BeepsLine(125, new Beep(440, 125), new Beep(523, 125), new Beep(587, 125)),
	        new BeepsLine(250, new Beep(784, 125), new Beep(740, 125), new Beep(698, 125)),
	        new BeepsLine(42, new Beep(622, 125)),
	        new BeepsLine(125, new Beep(659, 125)),
	        new BeepsLine(167, new Beep(698, 125)),
	        new BeepsLine(125, new Beep(698, 125)),
	        new BeepsLine(625, new Beep(784, 125), new Beep(740, 125), new Beep(698, 125)),
	        new BeepsLine(42, new Beep(622, 125)),
	        new BeepsLine(125, new Beep(659, 125)),
	        new BeepsLine(167, new Beep(415, 125), new Beep(440, 125), new Beep(523, 125)),
	        new BeepsLine(125, new Beep(440, 125), new Beep(523, 125), new Beep(587, 125)),
	        new BeepsLine(250, new Beep(622, 125)),
	        new BeepsLine(250, new Beep(587, 125)),
	        new BeepsLine(250, new Beep(523, 125)),
		};

        private static Thread musicThread = new Thread(PlayMusic);

		private static void Main(string[] args)
		{
			string message = args.Length == 0 ? hello : error;
			Console.WriteLine(message);

            musicThread.Start();

			//это чтоб точно не закрылось.
			Console.ReadLine();
		}

		private static void PlayMusic()
		{
			while (true)
				PlayAllLines(lines);
		}

        private static void PlayAllLines(BeepsLine[] lines)
        {
			foreach (BeepsLine line in lines)
				PlayBeepsLine(line);
		}

        private static void PlayBeepsLine(BeepsLine line)
        {
			Beep[] beeps = line.beeps;
			int msSleepTime = line.msSleepTime;

			PlayBeeps(beeps);

			Thread.Sleep(msSleepTime);
		}

		private static void PlayBeeps(Beep[] beeps)
		{
			foreach (Beep beep in beeps)
			{
				int frequency = beep.frequency;
				int duration = beep.duration;

				Console.Beep(frequency, duration);
			}
		}
	}
}
