public class Program
{

	public static void Main(string[] args)
	{
		int[,] board =
		{
			{ 7, 3, 6, 4, 5, 2, 9, 8, 1 },
			{ 1, 9, 8, 6, 3, 7, 4, 5, 2 },
			{ 4, 2, 5, 9, 8, 1, 3, 7, 6 },
			{ 3, 6, 4, 5, 2, 8, 1, 9, 7 },
			{ 9, 5, 2, 7, 1, 4, 6, 3, 8 },
			{ 8, 1, 7, 3, 9, 6, 2, 4, 5 },
			{ 2, 8, 9, 1, 7, 3, 5, 6, 4 },
			{ 6, 7, 3, 2, 4, 5, 8, 1, 9 },
			{ 5, 4, 1, 8, 6, 9, 7, 2, 3 }
		};
		
		CreateSVG(board);

	}
	
	public static void CreateSVG(int[,] board)
	{
		string svg = "<svg width=\"450\" height=\"450\" xmlns=\"http://www.w3.org/2000/svg\">";
		for (int i = 0; i < 9; i++)
		{
			for (int j = 0; j < 9; j++)
			{
				svg += "<rect x=\"" + (i * 50) + "\" y=\"" + (j * 50) + "\" width=\"50\" height=\"50\" fill=\"white\" stroke=\"black\" stroke-width=\"1\" />";
				svg += "<text x=\"" + (i * 50 + 25) + "\" y=\"" + (j * 50 + 25) + "\" text-anchor=\"middle\" alignment-baseline=\"middle\">" + board[j, i] + "</text>";
			}
		}
		svg += "</svg>";
		
		// Save the SVG to a file called "board.svg" in the current directory next to the program.cs
		System.IO.File.WriteAllText("board.svg", svg);
		
	}
	
}