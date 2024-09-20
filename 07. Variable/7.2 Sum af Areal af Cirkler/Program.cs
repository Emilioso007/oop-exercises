using System;

public class Program
{
	public static void Main(string[] args)
	{
		int radiusA = 1;
		int radiusB = 3;
		int radiusC = 5;
		double circumferenceA = 2 * radiusA * Math.PI;
		double circumferenceB = 2 * radiusB * Math.PI;
		double circumferenceC = 2 * radiusC * Math.PI;

		Console.WriteLine("Circle with radius " + radiusA + " has an circumference of " + circumferenceA);
		Console.WriteLine("Circle with radius " + radiusB + " has an circumference of " + circumferenceB);
		Console.WriteLine("Circle with radius " + radiusC + " has an circumference of " + circumferenceC);
		Console.WriteLine("Total circumference is " + (circumferenceA + circumferenceB + circumferenceC));

		Console.ReadKey();
	}
}