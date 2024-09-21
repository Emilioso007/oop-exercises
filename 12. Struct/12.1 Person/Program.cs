using System;

public class Program
{

	public struct Person {
		public string name;
	}

	public static void Main(string[] args)
	{
		Console.Clear();

		Person teacher = new Person();
		teacher.name = "Aslak";

		Console.WriteLine(teacher.name);

		Console.ReadKey();
	}
}