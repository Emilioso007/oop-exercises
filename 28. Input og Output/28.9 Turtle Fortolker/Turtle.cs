namespace _28._9_Turtle_Fortolker;

public class Turtle
{
	private int x, y;

	public int X
	{
		get
		{
			return x;
		}
		set
		{
			x = Math.Clamp(value, 0, canvas.Dimensions.width-1);
		}
	}

	public int Y 
	{ 
		get
		{
			return y;
		}
		set
		{
			y = Math.Clamp(value, 0, canvas.Dimensions.height-1);
		} 
	}
	
	private bool draw;
	private Canvas canvas;

	public Turtle(Canvas canvas, int x, int y)
	{
		this.canvas = canvas;
		X = x;
		Y = y;
		draw = false;
	}

	public void Go(Direction direction, int amount = 1)
	{
		Draw();
		for (int i = 0 ; i < amount ; i++)
		{
			switch (direction)
			{
				case Direction.North:
					Y--;
					break;
				case Direction.South:
					Y++;
					break;
				case Direction.East:
					X++;
					break;
				case Direction.West:
					X--;
					break;
			}
		Draw();
		}
	}

	public void Draw ()
	{
		if (draw)
		{
			canvas.Set(X, Y, true);
		}
	}

	public Canvas GetCanvas ()
	{
		return canvas;
	}
	
	public void TapDraw ()
	{
		draw = true;
		Draw();
		draw = false;
	}

	public void EnableDraw ()
	{
		draw = true;
		Draw();
	}

	public void DisableDraw ()
	{
		draw = false;
	}

}

public enum Direction
{
	North,
	South,
	East,
	West
}