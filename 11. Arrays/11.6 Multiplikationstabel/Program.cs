using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		int size = 20;

		int[] array = new int[size];

		for (int i = 0; i < array.Length; i++) {
			array[i] = 3 * i;
		}

		Console.WriteLine(array[5]);
		Console.WriteLine(array[10]);

		Console.ReadKey();
	}
}