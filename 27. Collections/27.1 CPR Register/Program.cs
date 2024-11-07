namespace _27._1_CPR_Register;

public class Program
{

	public static void Main(string[] args)
	{

		List<Person> persons = new List<Person>();
		persons.Add(new Person("Alfred", 31, "010101-0101"));
		persons.Add(new Person("Bente", 22, "020102-0102"));
		persons.Add(new Person("Charlie", 43, "313133-3313"));
		persons.Add(new Person("Emilie", 24, "444414-4414"));
		persons.Add(new Person("Freddy", 35, "555155-5155"));

		foreach (Person person in persons)
		{
			if (person.GetCpr().Equals("010101-0101"))
			{
				Console.WriteLine(person);
			}
		}

		
		
		Dictionary<string, Person> personsDictionary = new Dictionary<string, Person>();
		
		foreach (Person person in persons)
		{
			personsDictionary.Add(person.GetCpr(), person);
		}

		Console.WriteLine(personsDictionary["010101-0101"]);

	}
	
}