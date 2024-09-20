using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		for (double d = 40; d >= -5; d -= 0.5) {
			Console.WriteLine($"{d}°C = {32+9.0/5.0*d}°F");
		}

		Console.ReadKey();
	}
}