﻿public class Program
{
	public static int Sum (int[] numbers)
	{
		int result = 0;
		for (int i = 1 ; i <= numbers.Length ; i++)
		{
			result += numbers[i - 1]; //Changed from i to numbers[i - 1]
		}

		return result;
	}


	public static void Main (string[] args)
	{
		int[] testcase1 = {1, 3, 5, 2, 3, 7};
		int[] testcase2 = {5, 6, 2, 3};
		Console.WriteLine(Sum(testcase1));
		Console.WriteLine(Sum(testcase2));
	}

}