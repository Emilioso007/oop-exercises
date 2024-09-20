using System;

public class Program {
	public static void Main(string[] args) {

		Random random = new Random();

		int dice = random.Next(1, 7);

		bool b = dice >= 3;

		Console.WriteLine(b);

		Console.ReadKey();

	}
}