using System;

public class Program
{

	public static void Main(string[] args)
	{
		int[] radii = new int[] {1, 3, 5};

		foreach (int radius in radii) {
			Console.WriteLine("Circle with radius {0} has an area of {1:.0000}", radius, Area(radius));
		}

		Console.ReadKey();
	}

	public static double Area(int radius)
	{
		return Math.PI * radius * radius;
	}

}