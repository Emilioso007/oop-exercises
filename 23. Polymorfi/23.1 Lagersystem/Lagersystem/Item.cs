using System;

namespace Lagersystem;

public class Item
{

	protected string _name;
	protected double _price;

	public Item(string name, double price) {
		_name = name;
		_price = price;
	}

	public string GetName() {
		return _name;
	}

	public double GetPrice() {
		return _price;
	}
}