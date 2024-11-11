public class Program
{

	public static void Main(string[] args)
	{

		if (args.Length == 0)
		{
			Console.WriteLine("No arguments provided!");
		}

		foreach (string s in args)
		{
			Console.WriteLine($"Hello {s}");
		}

		Console.WriteLine("\nPress any key to exit...");
		Console.ReadKey(true);
	}

}