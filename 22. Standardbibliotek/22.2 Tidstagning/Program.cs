using System;

public class Program
{

	public static void Main(string[] args) {

		double x = 1.0000001;

		for (double y = 1; y <= 32; y++) {
			long start = DateTimeOffset.Now.ToUnixTimeMilliseconds();
			double result = Timing.Fun(x, y);
			long end = DateTimeOffset.Now.ToUnixTimeMilliseconds();

			Console.WriteLine($"result: {result}, time taken (ms): {end-start}");
		}

	}

}

public class Timing
{

	public static double Fun(double x, double y)
	{

		if (y <= 1)
		{
			return x;
		}

		return Fun(x, y - 1) * Fun(x, y - 1);

	}

}