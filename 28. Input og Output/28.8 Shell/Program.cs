namespace _28._8_Shell;

public class Program
{

	public static void Main(string[] args)
	{
		bool done = false;

		while (!done)
		{
			Console.Write("$ ");
			string input = Console.ReadLine() ?? "";
			if (input.Length == 0)
			{
				continue;
			}

			string[] command_args = input.Split(" ");

			string command = command_args[0];

			switch (command)
			{
				case "exit":
					done = true;
					break;
				case "echo":
					Console.WriteLine(string.Join(" ", command_args.Skip(1)));
					break;
				case "time":
					Console.WriteLine(DateTime.Now);
					break;
			}

			Console.WriteLine();
		}
		
	}
	
}
