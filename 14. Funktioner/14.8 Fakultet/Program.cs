using System;

public class Program
{

	public static void Main(string[] args)
	{
		Console.WriteLine(Fac(4));

		Console.ReadKey();
	}

	public static int Fac(int n)
	{
		if (n == 1)
		{
			return 1;
		} else
		{
			return n * Fac(n - 1);
		}
	}

}