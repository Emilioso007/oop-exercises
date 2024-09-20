using System;

public class Program {
	public static void Main(string[] args) {

		int a = 1;
		int b = 2;

		int sum = Sum(a, b);

		Console.WriteLine(sum);

		Console.ReadKey();
	}

	public static int Sum(int a, int b) {
		return a + b;
	}
}