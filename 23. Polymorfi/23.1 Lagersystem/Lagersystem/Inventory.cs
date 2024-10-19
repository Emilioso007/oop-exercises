using System;

namespace Lagersystem;

public class Inventory
{

	private List<Item> _items;

	public Inventory()
	{
		_items = new List<Item>();
	}

	public void AddItem(Item item)
	{
		_items.Add(item);
	}

	public void RemoveItem(Item item)
	{
		_items.Remove(item);
	}

	public double GetInventoryValue()
	{
		double sum = 0;

		foreach (Item item in _items)
		{
			sum += item.GetPrice();
		}

		return sum;
	}

	public void PrintInventory()
	{
		foreach (Item item in _items)
		{
			Console.WriteLine(item.ToString());
		}
	}

}