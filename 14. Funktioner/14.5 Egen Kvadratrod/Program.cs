using System;

public class Program {
	public static void Main(string[] args) {

		double n1 = 1024;
		double n2 = Sqrt(n1);

		Console.WriteLine(n2);

		Console.ReadKey();
	}

	public static double Sqrt(double a) {

		for (double d = 0; d < a; d += 0.0000001) {
			if (a - (d * d) < 0.0000001) {
				return d;
			}
		}

		return -1;

	}
}