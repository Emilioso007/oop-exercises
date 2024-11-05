/// <summary>
/// Represents a sheep that can move along a path.
/// </summary>
class Sheep
{
	/// <summary>
	/// The size of the sheep.
	/// </summary>
	public const int SHEEP_SIZE = 3;

	private Path path;
	private bool rightbound;
	private int position = -1;

	/// <summary>
	/// Initializes a new instance of the <see cref="Sheep"/> class.
	/// </summary>
	/// <param name="path">The path the sheep will move along.</param>
	/// <param name="rightbound">Indicates if the sheep is moving to the right.</param>
	public Sheep(Path path, bool rightbound)
	{
		this.path = path;
		this.rightbound = rightbound;
	}

	/// <summary>
	/// Prints the sheep's representation to the console.
	/// </summary>
	public void Print()
	{
		Console.Write(rightbound ? "-m*" : "*m-");
	}

	/// <summary>
	/// Sets the position of the sheep on the path.
	/// </summary>
	/// <param name="i">The position to set.</param>
	public void SetPosition(int i)
	{
		position = i;
		path.SetPosition(this, i);
	}

	/// <summary>
	/// Moves the sheep one position forward or backward on the path.
	/// </summary>
	public void Walk()
	{
		path.MovePosition(position, rightbound ? ++position : --position);
	}

	/// <summary>
	/// Makes the sheep jump two positions forward or backward on the path.
	/// </summary>
	public void Jump()
	{
		int old_pos = position;
		position += rightbound ? 2 : -2;
		path.MovePosition(old_pos, position);
	}

	/// <summary>
	/// Checks if the sheep is moving to the right.
	/// </summary>
	/// <returns>True if the sheep is moving to the right; otherwise, false.</returns>
	public bool IsRightbound()
	{
		return rightbound;
	}
}

/// <summary>
/// Represents a path that sheep can move along.
/// </summary>
class Path
{
    private Display display;
    private Sheep?[] spots;
    private int problemsize;
    private int spotcount;

    /// <summary>
    /// Initializes a new instance of the <see cref="Path"/> class.
    /// </summary>
    /// <param name="display">The display to update when the path changes.</param>
    /// <param name="problemsize">The size of the problem, which determines the number of spots on the path.</param>
    public Path(Display display, int problemsize)
    {
        this.problemsize = problemsize;
        this.spotcount = 2 * problemsize + 1;

        spots = new Sheep[spotcount];
        this.display = display;
        display.SetPath(this);
    }

    /// <summary>
    /// Prints the current state of the path to the console.
    /// </summary>
    public void Print()
    {
        for (int i = 0; i < spots.Length; i++)
        {
            Sheep? spot = spots[i];
            Console.Write(" ");
            if (spot == null)
            {
                for (int j = 0; j < Sheep.SHEEP_SIZE; j++)
                {
                    Console.Write(" ");
                }
            }
            else
            {
                spot.Print();
            }
        }
        Console.WriteLine("");
        for (int i = 0; i < spots.Length; i++)
        {
            Console.Write("+");
            for (int j = 0; j < Sheep.SHEEP_SIZE; j++)
            {
                Console.Write("-");
            }
        }
        Console.WriteLine("+");
        Console.WriteLine("");
    }

    /// <summary>
    /// Sets the position of a sheep on the path.
    /// </summary>
    /// <param name="sheep">The sheep to set the position for.</param>
    /// <param name="i">The position to set.</param>
    public void SetPosition(Sheep sheep, int i)
    {
        if (i < 0 || i >= spotcount)
            throw new Exception("Invalid position: " + i);
        spots[i] = sheep;
        display.Update();
    }

    /// <summary>
    /// Moves a sheep from one position to another on the path.
    /// </summary>
    /// <param name="src">The source position.</param>
    /// <param name="dst">The destination position.</param>
    public void MovePosition(int src, int dst)
    {
        if (src < 0 || src >= spotcount)
            throw new Exception("Invalid source position: " + src);
        if (spots[src] == null)
            throw new Exception("Trying to move null sheep");
        if (dst >= 0 && dst < spotcount)
        {
            if (spots[dst] != null) throw new DeadSheepException();
            spots[dst] = spots[src];
        }
        spots[src] = null;

        display.Update();
    }

    /// <summary>
    /// Gets the sheep at a specific position on the path.
    /// </summary>
    /// <param name="i">The position to check.</param>
    /// <returns>The sheep at the specified position, or null if the position is empty.</returns>
    public Sheep? Peek(int i)
    {
        if (i < 0 || i >= spotcount) return null;
        return spots[i];
    }

    /// <summary>
    /// Gets the total number of spots on the path.
    /// </summary>
    /// <returns>The total number of spots.</returns>
    public int GetSpotcount()
    {
        return spotcount;
    }

    /// <summary>
    /// Checks if the path is solved, meaning all sheep have moved to the correct positions.
    /// </summary>
    /// <returns>True if the path is solved; otherwise, false.</returns>
    public bool IsSolved()
    {
        for (int i = 0; i < problemsize; i++)
        {
            if (spots[i] != null) return false;
        }
        return true;
    }
}

public class DeadSheepException : Exception
{
}

class Display
{
    bool running = false;
    Path? path;

    public Display()
    {
    }

    public void SetPath(Path path)
    {
        this.path = path;
    }

    public void Start()
    {
        running = true;
    }

    public void Update()
    {
        if (running && path != null)
        {
            path.Print();
        }
    }
}

class Test
{
    private const int PROBLEM_SIZE = 5;

    static void Main(string[] args)
    {
        Display display = new Display();
        Path path = new Path(display, PROBLEM_SIZE);
        Solver solver = new Solver(path);
        // init puzzle
        for (int i = 0; i < PROBLEM_SIZE; i++)
        {
            Sheep s1 = new Sheep(path, true);
            s1.SetPosition(i);
            Sheep s2 = new Sheep(path, false);
            s2.SetPosition(PROBLEM_SIZE + 1 + i);
        }
        // start displaying state
        display.Start();
        display.Update();
        // perform test
        //try
        //{
            solver.Solve();
            if (path.IsSolved())
            {
                Console.WriteLine("You have graduated!");
            }
            else
            {
                Console.WriteLine("You have given up!");
            }
        //}
        //catch (DeadSheepException)
        //{
            Console.WriteLine("You have failed!");
        //}
    }
}

class Solver
{
	private Path path;

	public Solver(Path path)
	{
		this.path = path;
	}

	
	//DOES NOT WORK
	public void Solve()
	{
		while (!path.IsSolved())
		{

			for (int i = 0; i < path.GetSpotcount(); i++)
			{

				Sheep? sheep = path.Peek(i);
				
				if(sheep==null) continue;

				int direction = sheep.IsRightbound() ? 1 : -1;

				if (path.Peek(i + 1 * direction) == null)
				{
					sheep.Walk();
					continue;
				}

				if (path.Peek(i + 2 * direction) == null)
				{
					sheep.Jump();
					continue;
				}

			}
			
			path.Print();
		}
	}
}