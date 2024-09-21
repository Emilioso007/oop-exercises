using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		int[] daysInMonth = new int[] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		int[] daysInMonthLeapYear = new int[] {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

		int[] pointer = new int[0];

		for (int i = 2000; i < 2020; i++) {
			if (i % 4 == 0) {
				pointer = daysInMonthLeapYear;
			} else {
				pointer = daysInMonth;
			}
			Console.Write(i + ": ");
			foreach (int m in pointer) {
				Console.Write(m + " ");
			}
			Console.WriteLine();
		}

		Console.ReadKey();
	}
}