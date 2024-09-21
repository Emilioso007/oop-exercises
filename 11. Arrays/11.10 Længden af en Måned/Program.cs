using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		int month = 2;

		int[] monthLengths = new int[] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

		Console.WriteLine(monthLengths[month - 1]);

		Console.ReadKey();
	}
}