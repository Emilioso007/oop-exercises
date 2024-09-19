using System;

public class Program
{
	public static void Main(string[] args)
	{
		double celcius = 100.0;
		double fahrenheit = 32 + 9.0 / 5.0 * celcius;

		Console.WriteLine(celcius + "°C is equivalent to " + fahrenheit + "°F");
		Console.ReadKey();
	}
}