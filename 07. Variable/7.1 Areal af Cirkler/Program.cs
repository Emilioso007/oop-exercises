using System;

public class Program
{
	public static void Main(string[] args)
	{
		int radiusA = 1;
		int radiusB = 3;
		int radiusC = 5;
		double areaA = radiusA * radiusA * Math.PI;
		double areaB = radiusB * radiusB * Math.PI;
		double areaC = radiusC * radiusC * Math.PI;

		Console.WriteLine("Circle with radius " + radiusA + " has an area of " + areaA);
		Console.WriteLine("Circle with radius " + radiusB + " has an area of " + areaB);
		Console.WriteLine("Circle with radius " + radiusC + " has an area of " + areaC);

		Console.ReadKey();
	}
}