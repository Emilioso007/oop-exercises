using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		double[] temperatures = {21.5, 23.7, 19.6, 22.5, 25.3, 21.7, 18.9};

		for (int i = 1; i < temperatures.Length; i++) {
			Console.WriteLine(temperatures[i] - temperatures[i - 1]);
		}

		Console.ReadKey();
	}
}