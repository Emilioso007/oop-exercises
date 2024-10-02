using System;

namespace Sudoku;

public class SudokuBoard
{

	public int[,] Board;

	public SudokuBoard(int[,] board) {
		Board = board;
	}

	public void Solve ()
	{
		int[] count = new int[10];

		foreach (int i in Board)
		{
			count[i]++;
		}

		List<int> toBePlaced = new List<int>();

		for (int i = 1 ; i < count.Length ; i++)
		{
			for (int j = 0 ; j < 9 - count[i] ; j++)
			{
				toBePlaced.Add(i);
			}
		}

		foreach (var VARIABLE in toBePlaced)
		{
			Console.WriteLine(VARIABLE);
		}

		int[,] resultBoard = (int[,])Board.Clone();
		
		while (!Correct(resultBoard))
		{
			Shuffle(toBePlaced);

			int i = 0;
			
			for (int r = 0 ; r < 9 ; r++)
			{
				for (int c = 0 ; c < 9 ; c++)
				{
					if (Board[r, c] == 0)
					{
						resultBoard[r, c] = toBePlaced[i];
						i++;
					}
				}
			}

			//Console.WriteLine("Solving...");
		}

		Board = resultBoard;

	}

	private void Shuffle(List<int> arr)
	{
		Random rand = new Random();
		for (int i = 0 ; i < arr.Count ; i++)
		{
			int rand1 = rand.Next(arr.Count);
			int rand2 = rand.Next(arr.Count);
			(arr[rand1], arr[rand2]) = (arr[rand2], arr[rand1]);
		}
	}

	public void Print ()
	{
		for (int r = 0; r < 9; r++) {
			if (r % 3 == 0) {
				Console.WriteLine(" ----- ----- ----- ");
			}
			for (int c = 0; c < 9; c++) {
				if (c % 3 == 0) {
					Console.Write("|");
				} else {
					Console.Write(" ");
				}
				Console.Write(Board[r, c]);
			}
			Console.Write("|");
			Console.WriteLine();
		}
		Console.WriteLine(" ----- ----- ----- ");
	}


	private bool Correct (int[,] board)
	{
		bool correct = true;

		int n = 9;
		
		// Alle felter er udfyldt
		for (int r = 0; r < n; r++) 
		{
			for (int c = 0; c < n; c++) 
			{
				if (board[r, c] == 0)
				{
					correct = false;
					return correct;
				}
			}
		}

		// Alle rækker indeholder 1-9
		for (int r = 0; r < n; r++) {
			int[] temp = new int[9];
			for (int c = 0; c < n; c++) {
				temp[board[r, c] - 1]++;
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
				temp[board[r, c] - 1]++;
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
						temp[board[r + r2, c + c2] - 1]++;
					}
				}
				foreach (int i in temp) {
					if (i == 0) {
						correct = false;
					}
				}
			}
		}

		return correct;
	}

}