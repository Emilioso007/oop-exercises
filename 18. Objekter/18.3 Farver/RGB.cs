namespace Farver;

public class RGB
{

	public int R, G, B;

	public RGB(int r, int g, int b)
	{
		R = r;
		G = g;
		B = b;
	}

	// https://en.wikipedia.org/wiki/HSL_and_HSV#From_RGB
	public HSV AsHSV()
	{
		double xMax = Max(R / 255.0, G / 255.0, B / 255.0);

		double v = xMax;

		double xMin = Min(R / 255.0, G / 255.0, B / 255.0);

		double c = xMax - xMin;

		double h = 0;

		if (c == 0)
		{
			h = 0;
		}
		else if (v == R / 255.0)
		{
			h = 60 * (((G / 255.0) - (B / 255.0) / c) % 6);
		}
		else if (v == G / 255.0)
		{
			h = 60 * (((B / 255.0) - (R / 255.0) / c) + 2);
		}
		else if (v == B / 255.0)
		{
			h = 60 * (((R / 255.0) - (G / 255.0) / c) + 4);
		}

		double s = 0;

		if (v == 0)
		{
			s = 0;
		}
		else
		{
			s = c / v;
		}

		return new HSV((int)(h / 360.0 * 255), (int)(s * 255), (int)(v * 255));
	}

	public override string ToString() {
		return $"R: {R}, G: {G}, B: {B}";
	}

	private int Min(int a, int b, int c)
	{
		if (a < b && a < c)
		{
			return a;
		}
		if (b < a && b < c)
		{
			return b;
		}
		return c;
	}

	private double Min(double a, double b, double c)
	{
		if (a < b && a < c)
		{
			return a;
		}
		if (b < a && b < c)
		{
			return b;
		}
		return c;
	}

	private int Max(int a, int b, int c)
	{
		if (a > b && a > c)
		{
			return a;
		}
		if (b > a && b > c)
		{
			return b;
		}
		return c;
	}

	private double Max(double a, double b, double c)
	{
		if (a > b && a > c)
		{
			return a;
		}
		if (b > a && b > c)
		{
			return b;
		}
		return c;
	}
}