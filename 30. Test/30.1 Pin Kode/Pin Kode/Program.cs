namespace CardTerminal;

class Program
{
	static void Main(string[] args)
	{
		Pin pin = new Pin();

		for (int i = 0 ; i < 20 ; i++)
		{
			bool give_pin = pin.Expend(42);
			Console.WriteLine(i + ": 42 -> " + give_pin);
		}
	}
}