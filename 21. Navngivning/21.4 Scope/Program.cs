class Scope {

	static int bonus = 42;

	static int Doubler (int value)
	{
		int d = value * 2;
		return d;
	}

	public static void Main (string[] args)
	{
		int sum = 0;
		for (int i = 0; i < 100 ; i++)
		{
			int tmp = Doubler(i);
			sum += tmp;
		}

		Console.WriteLine(sum + bonus);
	}
}