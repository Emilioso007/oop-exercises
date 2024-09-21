using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		int year = 2024;
		int firstDay = 1; //1 == Monday etc.

		string[] days = {
			"Monday",
			"Tuesday",
			"Wednesday",
			"Thursday",
			"Friday",
			"Saturday",
			"Sunday"
		};

		string[] months = {
			"January",
			"February",
			"March",
			"April",
			"May",
			"June",
			"July",
			"August",
			"September",
			"October",
			"November",
			"December"
		};

		int[] monthLengths = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		int[] monthLengthsLeapYear = {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

		int[][] calendar = new int[12][];

		for (int m = 0; m < calendar.Length; m++) {
			if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) {
				calendar[m] = new int[monthLengthsLeapYear[m]];
			} else {
				calendar[m] = new int[monthLengths[m]];
			}
		}

		int wd = firstDay - 1;
		for (int m = 0; m < calendar.Length; m++) {
			for (int d = 0; d < calendar[m].Length; d++) {
				calendar[m][d] = wd;
				wd++;
				wd %= days.Length;
			}
		}

		for (int m = 0; m < calendar.Length; m++) {
			for (int d = 0; d < calendar[m].Length; d++) {
				Console.WriteLine($"{d+1, 2} - {m+1, 2} - {year,4}: {days[calendar[m][d]]}");
			}
		}

		Console.ReadKey();
	}
}