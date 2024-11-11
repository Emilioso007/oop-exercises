namespace _28._9_Turtle_Fortolker;

public class Program
{

	public static void Main(string[] args)
	{
		if (args.Length == 0)
		{
			Console.WriteLine("No input arguments!");
			Environment.Exit(0);
		}
		Console.WriteLine("Instruction file: " + args[0]);
		Queue<string> instructions = new Queue<string>(File.ReadLines(args[0]));
		
		Canvas canvas;
		Turtle turtle;

		string[] sizeCommand = instructions.Dequeue().Split(" ");
		canvas = new Canvas(int.Parse(sizeCommand[1]), int.Parse(sizeCommand[2]));
		string[] startCommand = instructions.Dequeue().Split(" ");
		turtle = new Turtle(canvas, int.Parse(startCommand[1]), int.Parse(startCommand[2]));
		
		while (instructions.Count > 0)
		{	
			string[] command = instructions.Dequeue().Split(" ");

			Console.WriteLine(string.Join(" ", command));
			
			switch (command[0])
			{
				case "pen":
					switch (command[1])
					{
						case "tap":
							turtle.TapDraw();
							break;
						case "up":
							turtle.DisableDraw();
							break;
						case "down":
							turtle.EnableDraw();
							break;
					}
					break;
				
				case "north":
					turtle.Go(Direction.North, command.Length > 1 ? int.Parse(command[1]) : 1);
					break;
				case "south":
					turtle.Go(Direction.South, command.Length > 1 ? int.Parse(command[1]) : 1);
					break;
				case "east":
					turtle.Go(Direction.East, command.Length > 1 ? int.Parse(command[1]) : 1);
					break;
				case "west":
					turtle.Go(Direction.West, command.Length > 1 ? int.Parse(command[1]) : 1);
					break;
				
				case "save":
					File.WriteAllText(command[1], turtle.GetCanvas().ToString());
					break;
				
				case "exit":
					Environment.Exit(0);
					break;

			}

		}
		
	}
	
}