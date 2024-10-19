using System;

namespace Lagersystem;

public class FoodItem : Item
{

	private DateTime _expires;

	public FoodItem(string name, double price, DateTime expires) : base(name, price) {
		_expires = expires;
	}

	public DateTime GetExpires() {
		return _expires;
	}

	public override string ToString() {

		return $"Name: {_name}, Price: {_price}, Expires: {_expires.ToLongDateString()}";

	}

}