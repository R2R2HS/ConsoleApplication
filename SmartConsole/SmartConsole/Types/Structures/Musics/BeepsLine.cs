using System.Runtime.Serialization.Formatters;

namespace SmartConsole.Types.Structures.Musics
{
	internal struct BeepsLine
	{
		public BeepsLine(int msSleepTime, params Beep[] beeps)
		{
			this.msSleepTime = msSleepTime;
			this.beeps = beeps;
		}

		internal int msSleepTime;
		internal Beep[] beeps;
	}
}
