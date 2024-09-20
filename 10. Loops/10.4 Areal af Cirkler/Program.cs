using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		for (int r = 1; r <= 5; r += 2) {
			Console.WriteLine($"Circle with radius {r} has area {r*r*Math.PI}");
		}

		Console.ReadKey();
	}
}