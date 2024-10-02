namespace Farver;

public class HSV
{

	public int H, S, V;

	public HSV() {}

	public HSV(int h, int s, int v)
	{
		H = h;
		S = s;
		V = v;
	}

	// https://en.wikipedia.org/wiki/HSL_and_HSV#HSV_to_RGB
	public RGB AsRGB()
	{
		double c = (V / 255.0) * (S / 255.0);

		double h = ((H * 360) / 255.0) / 60.0;

		double x = c * (1 - Abs((h % 2) - 1));

		double m = (V / 255.0) - c;

		double r = 0, g = 0, b = 0;

		if (0 <= h && h < 1) {
			r = c; g = x; b = 0;
		}
		if (1 <= h && h < 2) {
			r = x; g = c; b = 0;
		}
		if (2 <= h && h < 3) {
			r = 0; g = c; b = x;
		}
		if (3 <= h && h < 4) {
			r = 0; g = x; b = c;
		}
		if (4 <= h && h < 5) {
			r = x; g = 0; b = c;
		}
		if (5 <= h && h < 6) {
			r = c; g = 0; b = x;
		}
		r += m; g += m; b += m;

		return new RGB((int)(r * 255), (int)(g * 255), (int)(b * 255));
	}

	public override string ToString()
	{
		return $"H: {H}, S: {S}, V: {V}";
	}

	private int Abs(int a)
	{
		return a >= 0 ? a : -a;
	}

	private double Abs(double a)
	{
		return a >= 0 ? a : -a;
	}
}