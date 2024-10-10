class Circle
{

	private Coordinate _center;
	private double _diameter;

	public Circle (double x, double y, double diameter)
	{
		_center = new Coordinate(x, y);
		_diameter = diameter;
	}

	public void SetCenter(Coordinate center)
	{
		_center = center;
	}

	public Coordinate GetCenter()
	{
		return _center;
	}

	public double GetX()
	{
		return _center.GetX();
	}

	public double GetY()
	{
		return _center.GetY();
	}

	public double GetDiameter()
	{
		return _diameter;
	}

	public void SetCenter(double? x = null, double? y = null)
	{
		if (x != null)
		{
			_center.SetX((double)x);
		}
		if (y != null)
		{
			_center.SetY((double)y);
		}
	}

	public void SetDiameter(double diameter)
	{
		_diameter = diameter;
	}

	public override string ToString()
	{
		return $"x = {_center.GetX()}, y = {_center.GetY()}, diameter = {_diameter}";
	}

}

class TestCircle
{

	static void Main (string[] args)
	{
		Circle c = new Circle(1.24, 2.83, 12.7);
		Console.WriteLine(c.ToString());
		c.SetDiameter(c.GetDiameter() * 1.37);
		c.SetCenter(x: c.GetX() + 0.65);
		Console.WriteLine(c.ToString());
	}

}

class Coordinate
{
	private double _x;
	private double _y;

	public Coordinate(double x, double y)
	{
		_x = x;
		_y = y;
	}

	public double GetX()
	{
		return _x;
	}

	public double GetY()
	{
		return _y;
	}

	public void SetX(double x)
	{
		_x = x;
	}

	public void SetY(double y)
	{
		_y = y;
	}

}