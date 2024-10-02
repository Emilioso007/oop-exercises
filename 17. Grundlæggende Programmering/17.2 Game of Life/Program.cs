using System;

public class Program
{

	public static void Main(string[] args)
	{
		Console.Clear();

		int[,] board = new int[,] {
			{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
			{0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0},
			{0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0},
			{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
		};
		string? input;
		do {
			Console.Clear();
			Print(board);
			Tick(ref board);
			input = Console.ReadLine();
		} while (input?.Length == 0);
	}

	public static void Tick(ref int[,] before) {
		int[,] after = (int[,])before.Clone();

		for (int r = 1; r < before.GetLength(0) - 1; r++) {
			for (int c = 1; c < before.GetLength(1) - 1; c++) {

				//count neighbours
				int count = 0;
				for (int x = -1; x <= 1; x++)
				{
					for (int y = -1; y <= 1; y++)
					{
						if (x == 0 && y == 0)
						{
							continue;
						}

						count += before[r + x, c + y];

					}
				}

				int me = before[r, c];

				if (me == 1 && count < 2) {
					after[r, c] = 0;
				}

				if (me == 1 && (count == 2 || count == 3)) {
					after[r, c] = 1;
				}

				if (me == 1 && count > 3) {
					after[r, c] = 0;
				}

				if (me == 0 && count == 3) {
					after[r, c] = 1;
				}

			}
		}

		before = after;
	}

	public static void Print(int[,] board) {
		for (int r = 0; r < board.GetLength(0); r++) {
			for (int c = 0; c < board.GetLength(1); c++) {
				char toPrint = board[r, c] == 1 ? '■' : '◻';
				Console.Write(toPrint + " ");
			}
			Console.WriteLine();
		}
	}

}