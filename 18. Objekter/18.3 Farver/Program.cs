namespace Farver;

using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		RGB rgb = new RGB(100, 200, 0);

		HSV hsv = rgb.AsHSV();

		RGB newRgb = hsv.AsRGB();

		Console.WriteLine(rgb.ToString());
		Console.WriteLine(hsv.ToString());
		Console.WriteLine(newRgb.ToString());

		Console.ReadKey();
	}
}