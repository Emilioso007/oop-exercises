using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		int[,] sudoku = new int[9, 9] {
			{4, 3, 5, 2, 6, 9, 7, 8, 1},
			{6, 8, 2, 5, 7, 1, 4, 9, 3},
			{1, 9, 7, 8, 3, 4, 5, 6, 2},
			{8, 2, 6, 1, 9, 5, 3, 4, 7},
			{3, 7, 4, 6, 8, 2, 9, 1, 5},
			{9, 5, 1, 7, 4, 3, 6, 2, 8},
			{5, 1, 9, 3, 2, 6, 8, 7, 4},
			{2, 4, 8, 9, 5, 7, 1, 3, 6},
			{7, 6, 3, 4, 1, 8, 2, 5, 9}
		};


		for (int r = 0; r < sudoku.GetLength(0); r++) {
			if (r % 3 == 0) {
				Console.WriteLine(" ----- ----- ----- ");
			}
			for (int c = 0; c < sudoku.GetLength(1); c++) {
				if (c % 3 == 0) {
					Console.Write("|");
				} else {
					Console.Write(" ");
				}
				Console.Write(sudoku[r, c]);
			}
			Console.Write("|");
			Console.WriteLine();
		}
		Console.WriteLine(" ----- ----- ----- ");


		bool correct = true;
		int n = sudoku.GetLength(0);


		// Alle felter er udfyldt
		for (int r = 0; r < n; r++) {
			for (int c = 0; c < n; c++) {
				if (sudoku[r, c] == 0) {
					correct = false;
				}
			}
		}

		// Alle rækker indeholder 1-9
		for (int r = 0; r < n; r++) {
			int[] temp = new int[9];
			for (int c = 0; c < n; c++) {
				temp[sudoku[r, c] - 1]++;
			}
			foreach (int i in temp) {
				if (i == 0) {
					correct = false;
				}
			}
		}

		// Alle kolonner indeholder 1-9
		for (int c = 0; c < n; c++) {
			int[] temp = new int[9];
			for (int r = 0; r < n; r++) {
				temp[sudoku[r, c] - 1]++;
			}
			foreach (int i in temp) {
				if (i == 0) {
					correct = false;
				}
			}
		}

		// Alle 3x3 grupper indeholder 1-9
		for (int r = 1; r <= 7; r += 3) {
			for (int c = 1; c <= 7; c += 3) {
				int[] temp = new int[9];
				for (int r2 = -1; r2 <= 1; r2++) {
					for (int c2 = -1; c2 <= 1; c2++) {
						temp[sudoku[r + r2, c + c2] - 1]++;
					}
				}
				foreach (int i in temp) {
					if (i == 0) {
						correct = false;
					}
				}
			}
		}


		Console.WriteLine(correct);

		Console.ReadKey();
	}
}