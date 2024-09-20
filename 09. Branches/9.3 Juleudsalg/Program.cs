using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		int secondsSinceNewYear = 30585600;

		double price = 599.95;

		int secondsPerDay = 60 * 60 * 24;

		int secondsPerMonth = secondsPerDay * 30;

		int month = secondsSinceNewYear / secondsPerMonth + 1;

		if (month == 12) {
			price -= price * 0.3;
		}

		Console.WriteLine(price);

		Console.ReadKey();
	}
}