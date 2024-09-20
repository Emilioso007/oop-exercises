using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		int month = 4;

		switch (month) {
		case 10:
			Console.WriteLine("Efterårsferie");
			break;
		case 12:
			Console.WriteLine("Juleferie");
			break;
		case 4:
			Console.WriteLine("Påskeferie");
			break;
		case 7: case 8:
			Console.WriteLine("Sommerferie");
			break;
		default:
			Console.WriteLine("Hårdt arbejde");
			break;
		}

		Console.ReadKey();
	}
}