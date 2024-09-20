using System;

public class Program
{
	public static void Main(string[] args)
	{
		long seconds = 1234567890;

		long secondsPerYear = 60 * 60 * 24 * 365;

		long secondsPerDay = 60 * 60 * 24;

		long years = seconds / secondsPerYear;

		long days = (long)(seconds % secondsPerYear / secondsPerDay);

		Console.WriteLine($"{seconds} seconds is equivalent to {years} years and {days} days!");

		Console.ReadKey();
	}
}