namespace _25._1_Gennemsnitlig_Alder;

class Program
{
	static void Main()
	{
		Person p1 = new Person(25);
		Person p2 = new Person(30);

		Console.WriteLine(Person.AverageAge()); // Output: 27.5

		p1.Dispose();
		Console.WriteLine(Person.AverageAge()); // Output: 30

		p2.Dispose();
		Console.WriteLine(Person.AverageAge()); // Output: 0
	}
}

