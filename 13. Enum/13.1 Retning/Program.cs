using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		Direction heading = Direction.North;

		Console.WriteLine(heading);

		Console.ReadKey();
	}

	public enum Direction {
		North,
		South,
		East,
		West,
	}
}