﻿using System;

namespace Sudoku;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();
		
		int[,] board = new int[9, 9] {
			{0,0,0,0,0,0,0,0,0},
			{0,0, 2, 5, 7, 1, 4, 9, 3},
			{1, 9, 7, 8, 3, 4, 5, 6, 2},
			{8, 2, 6, 1, 9, 5, 3, 4, 7},
			{3, 7, 4, 6, 8, 2, 9, 1, 5},
			{9, 5, 1, 7, 4, 3, 6, 2, 8},
			{5, 1, 9, 3, 2, 6, 8, 7, 4},
			{2, 4, 8, 9, 5, 7, 1, 3, 6},
			{7, 6, 3, 4, 1, 8, 2, 5, 9}
		};
			
			/*
			new int[9, 9] {
			{0,9,0,2,8,0,3,6,0},
			{1,3,0,0,0,0,9,5,2},
			{2,0,6,9,3,5,0,0,0},
			{0,6,5,9,3,5,0,0,0},
			{9,8,0,0,0,6,1,0,3},
			{0,0,1,3,0,8,5,0,6},
			{4,0,7,8,2,0,0,0,5},
			{8,2,0,6,5,0,0,1,0},
			{0,0,3,0,0,7,2,8,9}
		};
		*/

		SudokuBoard sudokuBoard = new SudokuBoard(board);

		sudokuBoard.Print();
		sudokuBoard.Solve();
		sudokuBoard.Print();
		
		Console.ReadKey();
	}
}