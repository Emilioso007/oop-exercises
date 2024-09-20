using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		for (int p = 2; p < 1000000; p++) {
			bool is_prime = true;
			for (int n = 2; n < p; n++) {
				if (p % n == 0) {
					is_prime = false;
				}
			}
			if (is_prime) {
				Console.WriteLine(p);
			}
		}

		Console.ReadKey();
	}
}