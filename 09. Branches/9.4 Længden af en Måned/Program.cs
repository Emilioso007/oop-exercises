using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		int month = 5;

		switch (month) {
		case 1: case 3: case 5: case 7: case 8: case 10: case 12:
			Console.WriteLine(31);
			break;
		case 2:
			Console.WriteLine(28);
			break;
		default:
			Console.WriteLine(30);
			break;
		}

		Console.ReadKey();
	}
}