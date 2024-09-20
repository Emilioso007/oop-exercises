using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		int seconds = 0;

		int secondsPerDay = 60 * 60 * 24;

		int secondsPerMonth = secondsPerDay * 30;

		int month = seconds / secondsPerMonth + 1;

		int day = (seconds % secondsPerMonth) / secondsPerDay + 1;

		Console.WriteLine(month + ", " + day);

		if (month == 12 && day == 24) {
			Console.WriteLine("Det er jul!");
		} else {
			int daysUntilChristmas = 24 - day + (12 - month) * 30;
			if (daysUntilChristmas < 0)
			{
				daysUntilChristmas = 0; // or however you want to handle it
			}
			Console.WriteLine($"Der er {daysUntilChristmas} dage tilbage til jul.");
		}


		Console.ReadKey();
	}
}