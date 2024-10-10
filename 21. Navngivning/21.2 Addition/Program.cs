using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		Console.WriteLine(Adder.Solve(3, 5));

		Console.WriteLine(Adder.Solve(3.14, 5.12));

		Console.WriteLine(Adder.Solve(3, 5.12)); // int castes implicit til double

		Console.ReadKey();
	}
}

public class Adder
{

	public static string Solve(int a, int b)
	{
		return $"{a} + {b} = {a+b}";
	}

	public static string Solve(double a, double b)
	{
		return $"{a} + {b} = {a+b}";
	}

}