using System;

public class Program {
	public static void Main(string[] args) {

		double a = 1.0;
		double b = 2.0;
		double c = -4.0;

		double[] roots = Roots(a, b, c);

		foreach (double root in roots) {
			Console.WriteLine(root);
		}

		Console.ReadKey();
	}

	public static double[] Roots(double a, double b, double c) {
		double d = Discriminant(a, b, c);
		if (d < 0) {
			return new double[0];
		} else if (d == 0) {
			double root = (-b + d) / (2 * a);
			return new double[1] {root};
		} else {
			double root1 = (-b + d) / (2 * a);
			double root2 = (-b - d) / (2 * a);

			return new double[2] {root1, root2};
		}

	}

	public static double Discriminant(double a, double b, double c) {
		return Math.Sqrt(b * b - 4 * a * c);
	}

}