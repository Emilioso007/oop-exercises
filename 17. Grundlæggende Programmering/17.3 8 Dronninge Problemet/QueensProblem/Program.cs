﻿using System;

//https://www.c-sharpcorner.com/article/fun-with-backtracking-the-n-queen-problem/

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		N = 8;
		int[,] board = new int[N, N];
		if (!TheBoardSolver(board, 0))
		{
			Console.WriteLine("Solution not found.");
		}
		PrintBoard(board);

		Console.ReadKey();
	}

	public static int N;

	public static void PrintBoard(int[,] board)
	{
		for (int i = 0; i < N; i++)
		{
			for (int j = 0; j < N; j++)
			{
				Console.Write(board[i, j] + " ");
			}
			Console.Write("\n");
		}
	}

	public static bool ToPlaceOrNotToPlace(int[,] board, int row, int col)
	{
		int i, j;
		for (i = 0; i < col; i++)
		{
			if (board[row, i] == 1)
			{ return false; }
		}
		for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
		{
			if (board[i, j] == 1)
			{ return false; }
		}
		for (i = row, j = col; j >= 0 && i < N; i++, j--)
		{
			if (board[i, j] == 1)
			{ return false; }
		}
		return true;
	}

	public static bool TheBoardSolver(int[,] board, int col)
	{
		if (col >= N)
		{ return true; }
		for (int i = 0; i < N; i++)
		{
			if (ToPlaceOrNotToPlace(board, i, col))
			{
				board[i, col] = 1;
				if (TheBoardSolver(board, col + 1))
				{ return true; }
				// Backtracking is important in this one.
				board[i, col] = 0;
			}
		}
		return false;
	}

}