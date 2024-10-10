namespace  _21._1_Killinger;

public class Kitten
{

	public static int Count = 0;

	private double _cuteness;

	public Kitten(double cuteness)
	{
		_cuteness = cuteness;
		Kitten.Count++;
	}

}