using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		int[] array = new int[] {4, 5, 2, 7, 4};

		int record = int.MinValue;
		int recordIndex = -1;

		for (int i = 0; i < array.Length; i++) {
			if (array[i] > record) {
				record = array[i];
				recordIndex = i;
			}
		}

		Console.WriteLine(recordIndex);

		Console.ReadKey();
	}
}