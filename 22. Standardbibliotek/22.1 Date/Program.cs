using System;

class Program
{
	static void Main(string[] args)
	{
		// Array med tidsstempler
		long[] timestamps = { (long)Math.Pow(10, 3), (long)Math.Pow(10, 4), (long)Math.Pow(10, 5), (long)Math.Pow(10, 6) };

		// Loop igennem hvert tidsstempel
		foreach (long timestamp in timestamps)
		{
			// Opret DateTimeOffset objekt fra UnixTimeMilliseconds
			DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(timestamp);

			// Tilgå DateTime attributten
			DateTime dateTime = dateTimeOffset.DateTime;

			// Udskriv tidspunktet til skærmen
			Console.WriteLine($"Timestamp: {timestamp}, DateTime: {dateTime.ToString("yyyy - MM - dd HH: mm: ss.fff")}");
		}
	}
}