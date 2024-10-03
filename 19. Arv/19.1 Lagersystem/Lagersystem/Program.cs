using System;

namespace Lagersystem;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		FoodItem[] foodItems = new FoodItem[10];

		for (int i = 0; i < foodItems.Length; i++) {
			foodItems[i] = new FoodItem("Banana", 1, new DateTime(2024, 10, 8));
		}

		foreach (FoodItem fi in foodItems) {
			Console.WriteLine(fi.ToString());
		}

		NonFoodItem[] nonFoodItems = new NonFoodItem[10];

		for (int i = 0; i < nonFoodItems.Length; i++) {
			nonFoodItems[i] = new NonFoodItem("Lego", 540, ["Plastic", "Paper", "Love"]);
		}

		foreach (NonFoodItem nfi in nonFoodItems) {
			Console.WriteLine(nfi.ToString());
		}

		Console.ReadKey();
	}
}