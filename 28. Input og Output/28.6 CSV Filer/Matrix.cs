using System.Text;
using Microsoft.CSharp.RuntimeBinder;

namespace _28._6_CSV_Filer;

public class Matrix
{
	private double[][] data;

	public (int width, int height) Dimensions
	{
		get
		{
			return (data[0].Length, data.Length);
		}
	}

	public Matrix(string filePath)
	{
		string csv = File.ReadAllText(filePath);

		string[] rows = csv.Split("\n");

		data = new double[rows.Length][];

		for (int i = 0 ; i < rows.Length ; i++)
		{
			string[] rowData = rows[i].Split(",");
			data[i] = new double[rowData.Length];
			for (int j = 0 ; j < rowData.Length ; j++)
			{
				data[i][j] = double.Parse(rowData[j]);
			}
		}
	}

	public Matrix(int width, int height)
	{
		data = new double[height][];
		for (int i = 0 ; i < data.Length ; i++)
		{
			data[i] = new double[width];
		}
	}

	public void Save(string filePath)
	{
		StringBuilder csv = new StringBuilder();
		foreach (double[] row in data)
		{
			csv.Append(string.Join(',', row)+"\n");
		}
		csv.Remove(csv.Length - 1, 1);
		
		File.WriteAllText(filePath, csv.ToString());
	}

	public void Set(int x, int y, double value)
	{
		data[y][x] = value;
	}

	public double Get(int x, int y)
	{
		return data[y][x];
	}
	
	public override string ToString ()
	{
		StringBuilder csv = new StringBuilder();
		foreach (double[] row in data)
		{
			csv.Append(string.Join(',', row)+"\n");
		}
		csv.Remove(csv.Length - 1, 1);

		return csv.ToString();
	}

}