using System;

public class AvgGradeError
{

	public static int[] grades = {4, 7, 02, 00, 10, 4, 12};

	public static void Main(string[] args)
	{
		Console.Clear();

		int count = 0;
		int sum = 0;

		for (int i = 0; i < grades.Length; i++) {
			try {
				sum += GetGrade(i);
				count++;
			} catch (Exception e) {
				Console.WriteLine($"courseId {i}: {e.Message}");
			}
		}

		Console.WriteLine($"Average: {(double)sum/count}");

		Console.ReadKey();
	}

	public static int GetGrade(int courseId) {
		int grade = grades[courseId];

		if (grade < 02) {
			throw new Exception("Failed!");
		}

		return grade;
	}
}