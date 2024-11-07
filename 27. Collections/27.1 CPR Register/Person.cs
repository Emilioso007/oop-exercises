namespace _27._1_CPR_Register;

public class Person
{
	private string name;
	private int age;
	private string cpr;

	public Person(string name, int age, string cpr)
	{
		this.name = name;
		this.age = age;
		this.cpr = cpr;
	}

	public string GetName ()
	{
		return name;
	}

	public int GetAge ()
	{
		return age;
	}

	public string GetCpr ()
	{
		return cpr;
	}

	public override string ToString ()
	{
		return $"Name: {name} Age: {age} Cpr: {cpr}";
	}
}