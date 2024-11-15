public class Program
{

	public static void Main(string[] args)
	{
		Console.WriteLine("Enter a string to reverse: ");

		/*
		string userInput = Console.ReadLine() ?? "";

		string reversedString = string.Join("", userInput.ToCharArray().Reverse());

		Console.WriteLine(reversedString);

		*/

		Console.WriteLine(string.Join("", (Console.ReadLine() ?? "").ToCharArray().Reverse()));

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey(true);

	}

}
