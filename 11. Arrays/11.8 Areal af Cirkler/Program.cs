using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		int[] radii = new int[] {1, 3, 5};

		foreach (int r in radii) {
			Console.WriteLine($"Circle with radius {r} has an area of {r*r*Math.PI}");
		}

		Console.ReadKey();
	}
}