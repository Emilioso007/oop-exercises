using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		double d = -5;

		do
		{
			Console.WriteLine($"{d}°C = {32+9.0/5.0*d}°F");
			d += 0.5;
		} while (d <= 40);

		Console.ReadKey();
	}
}