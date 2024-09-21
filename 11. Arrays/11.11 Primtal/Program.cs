using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		int n = 999999;

		bool[] A = new bool[n];
		for (int i = 0; i < n; i++) {
			A[i] = true;
		}

		for (int i = 2; i < Math.Sqrt(n); i++) {
			if (A[i]) {
				for (int j = i * i; j < n; j += i) {
					A[j] = false;
				}
			}
		}

		for (int i = 2; i < n; i++) {
			if (A[i]) {
				Console.WriteLine(i);
			}
		}

		Console.ReadKey();
	}
}