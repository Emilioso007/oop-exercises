using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		double monday = 21.5;
		double tuesday = 23.7;
		double wednesday = 19.6;
		double thursday = 22.5;
		double friday = 25.3;
		double saturday = 21.7;
		double sunday = 18.9;

		Console.WriteLine(tuesday - monday);
		Console.WriteLine(wednesday - tuesday);
		Console.WriteLine(thursday - wednesday);
		Console.WriteLine(friday - thursday);
		Console.WriteLine(saturday - friday);
		Console.WriteLine(sunday - saturday);

		//Error caused by floating point arithmetic

		Console.ReadKey();
	}
}