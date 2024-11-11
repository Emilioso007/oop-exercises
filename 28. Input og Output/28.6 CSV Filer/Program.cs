namespace _28._6_CSV_Filer;

public class Program
{
	public static void Main(string[] args)
	{

		Matrix matrixA = new Matrix(4, 6);
		
		matrixA.Save("data.csv");

		
		Matrix matrixB = new Matrix("data.csv");
		
		Console.WriteLine(matrixB);

		Console.WriteLine();
		
		matrixB.Set(2, 3, 3.14);
		Console.WriteLine(matrixB);

		Matrix matrixC = new Matrix("data.csv");

		for (int y = 0 ; y < matrixC.Dimensions.height ; y++)
		{
			for (int x = 0 ; x < matrixC.Dimensions.width ; x++)
			{
				if (x == y)
				{
					matrixC.Set(x, y, 1.0);
				}
			}
		}
		
		matrixC.Save("newData.csv");

		Console.WriteLine();
		
		Console.WriteLine(matrixC);

	}
}