using System.Text;

namespace _28._9_Turtle_Fortolker;

public class Canvas
{

	private bool[,] data;

	public (int width, int height) Dimensions
	{
		get { return (data.GetLength(0), data.GetLength(1)); }
	}

	public Canvas(int width, int height)
	{
		data = new bool[width, height];
	}

	public void Set(int x, int y, bool b)
	{
		data[x, y] = b;
	}
	
	public bool[,] GetData ()
	{
		return data;
	}

	public void SetData (bool[,] input)
	{
		data = input;
	}

	public void Print ()
	{
		Console.WriteLine(ToString());
	}

	public override string ToString ()
	{
		StringBuilder result = new StringBuilder();

		result.Append("+" + new string('-', Dimensions.width) + "+");
		result.AppendLine();
		
		for (int y = 0 ; y < Dimensions.height ; y++)
		{
			result.Append('|');
			for (int x = 0 ; x < Dimensions.width ; x++)
			{
				if (data[x, y])
				{
					result.Append('X');
				}
				else
				{
					result.Append(' ');
				}
			}	
			result.Append('|');
			result.AppendLine();
		}

		result.Append("+" + new string('-', Dimensions.width) + "+");
		
		return result.ToString();
	}

}