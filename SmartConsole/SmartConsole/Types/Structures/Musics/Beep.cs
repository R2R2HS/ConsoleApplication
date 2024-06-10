namespace SmartConsole.Types.Structures.Musics
{
	internal struct Beep
	{
		internal Beep(int frequency, int duration)
		{
			this.frequency = frequency;
			this.duration = duration;
		}

		internal int frequency, duration;
	}
}
