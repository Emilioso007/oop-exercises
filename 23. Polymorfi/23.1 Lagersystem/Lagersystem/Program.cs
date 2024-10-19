using System;

namespace Lagersystem;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		Test.RunTest();

		Console.ReadKey();
	}
}

public class Test
{
	public static void RunTest()
	{
		Inventory inventory = new Inventory();

		inventory.AddItem(new FoodItem("Banana", 1, (new DateTime(2024, 10, 21))));

		Console.WriteLine(inventory.GetInventoryValue());

		inventory.PrintInventory();

	}
}