using System;

namespace _21._1_Killinger;

public class Program
{
	public static void Main(string[] args)
	{
		Random random = new Random();
		Kitten[] kittens = new Kitten[10];
		for (int k = 0 ; k < kittens.Length ; k++)
		{
			kittens[k] = new Kitten(random.NextDouble() * 100);
		}
		
		Console.WriteLine(Kitten.Count);
		
	}
}